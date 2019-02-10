using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgencySiteClient.Entities;

namespace TravelAgencySiteClient
{
    public partial class MainForm : Form
    {
        private string responseJson;
        private ApiTravelAgency api = null;

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            api = new ApiTravelAgency();

            this.comboBoxCities.Enabled = false;
            this.buttonSelectCity.Enabled = false;

            this.FillingDataComboBoxCountries();

            this.tabControl.SelectedIndexChanged 
                += TabControl_SelectedIndexChanged;


            // Tours tab
            this.buttonSelectCountry.Click += ButtonSelectCountry_Click;
            this.buttonSelectCity.Click += ButtonSelectCity_Click;
            this.dataGridViewTours.CellDoubleClick 
                += DataGridViewTours_CellDoubleClick;


            // Register tab
            this.buttonRegister.Click += ButtonRegister_Click;


            // Admin tabs
            this.tabControlAdmin.SelectedIndexChanged
                += TabControlAdmin_SelectedIndexChanged;
            // Country tab
            this.buttonAddCountry.Click += ButtonAddCountry_Click;
            
        }

        private async void TabControlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlAdmin.SelectedTab.Name == tabPageCountries.Name)
            {
                Console.WriteLine(">> Загрузка стран");

                await LoadAllCountriesForAdminTab();
            }
            else if (tabControlAdmin.SelectedTab.Name == tabPageCities.Name)
            {
                Console.WriteLine(">> Загрузка городов");

                await LoadAllCitiesForAdminTab();

                this.FillingDataComboBoxAllCountries();
            }
            else if (tabControlAdmin.SelectedTab.Name == tabPageHotels.Name)
            {
                Console.WriteLine(">> Загрузка отелей");

                await FillingDataGridAllHotelsForAdminTab();

                // TODO заполнение комбобоксов
            }
            else if (tabControlAdmin.SelectedTab.Name == tabPageImages.Name)
            {
                Console.WriteLine(">> Загрузка картинок");

                // TODO загрузка отелей

                // TODO заполнение комбобоксов
            }
        }

        private async Task FillingDataGridAllHotelsForAdminTab()
        {
            responseJson = await api.LoadAllHotelsDataAsync();

            this.dataGridViewHotels.DataSource
                = JsonConvert.DeserializeObject<List<Hotel>>(responseJson)
                .ToList();
        }

        private async void FillingDataComboBoxAllCountries()
        {
            responseJson = await api.LoadAllCountriesDataAsync();

            this.comboBoxCountriesForAddCity.DataSource
                = JsonConvert.DeserializeObject<List<Country>>(responseJson)
                .Select(c => c.countryName).ToList();
        }

        private async Task LoadAllCitiesForAdminTab()
        {
            // Загрузка всех городов
            responseJson = await api.LoadAllCitiesDataAsync();

            this.dataGridViewCities.DataSource
                = JsonConvert.DeserializeObject<List<City>>(responseJson)
                .ToList();
        }

        private async void ButtonAddCountry_Click(object sender, EventArgs e)
        {
            // TODO проверитть на заполненность текстбокса.
            string country = textBoxAddCountry.Text;
            this.AddNewCountry(country);

            this.textBoxAddCountry.Text = "";

            await LoadAllCountriesForAdminTab();
        }

        private async void AddNewCountry(string country)
        {
            responseJson = await api.AddCountryAsync(country);

            Console.WriteLine("AddNewCountry: " + responseJson);
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            // TODO проверка на заполнение всех полей.

            string login = textBoxLogin.Text;
            string pass = textBoxPassword.Text;
            string email = textBoxEmail.Text;

            this.NewUserRegistration(login, pass, email);
        }

        private async void NewUserRegistration(string login, string pass, string email)
        {
            responseJson = await api.UserRegistrationAsync(login, pass, email);
            
            if (responseJson == "200")
            {
                MessageBox.Show(
                    "Пользователь добавлен!",
                    "Добавление успешно",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                // TODO не сервере не реализован возврат ошибки.

                MessageBox.Show(
                    "Пользователь не добавлен!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // DEBUG
            Console.WriteLine("Ответ при регистрации User: " + responseJson);
        }

        private void DataGridViewTours_CellDoubleClick
            (object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Показываем страницу отеля");
            Console.WriteLine((sender as DataGridView).SelectedCells[1].Value);
        }

        private void ButtonSelectCity_Click(object sender, EventArgs e)
        {
            // Выбранная страна.
            string country = comboBoxCountries.SelectedItem.ToString();
            // Выбранный город.
            string city = comboBoxCities.SelectedItem.ToString();

            // Заполнение таблицы отелей.
            this.FillingDataGridViewHotels(country, city);
        }

        private async void FillingDataGridViewHotels(string country, string city)
        {
            responseJson = await api.LoadHotelsDataAsync(country, city);

            Console.WriteLine(" > Загрузка отелей в таблицу.");

            this.dataGridViewTours.DataSource
                = JsonConvert.DeserializeObject<List<Hotel>>(responseJson)
                //.Select(TODO только то чно нужно ИЛИ все)
                .ToList();

            this.dataGridViewTours.Columns["cityName"].Visible = false;
            this.dataGridViewTours.Columns["countryName"].Visible = false;
        }

        private void ButtonSelectCountry_Click(object sender, EventArgs e)
        {
            // Выбранная страна.
            string country = comboBoxCountries.SelectedItem.ToString();

            // Заполнение списка городов.
            this.FillingDataComboBoxCities(country);
        }

        private async void FillingDataComboBoxCities(string country)
        {
            responseJson = await api.LoadCitiesDataAsync(country);

            this.comboBoxCities.DataSource
                = JsonConvert.DeserializeObject<List<City>>(responseJson)
                .Select(c => c.cityName).ToList();

            // Включение комбоБокса и кнопки для выбора города.
            this.comboBoxCities.Enabled = true;
            this.buttonSelectCity.Enabled = true;
        }

        private async void FillingDataComboBoxCountries()
        {
            Console.WriteLine(">>> loading Countries");

            //this.comboBoxCountries.UseWaitCursor = true;  // TODO ???
            this.buttonSelectCountry.Enabled = false;

            responseJson = await api.LoadCountriesDataAsync();

            this.comboBoxCountries.DataSource
                = JsonConvert.DeserializeObject<List<Country>>(responseJson)
                .Select(c => c.countryName).ToList();

            //this.comboBoxCountries.UseWaitCursor = false;   // TODO ???
            this.buttonSelectCountry.Enabled = true;
        }

        private async void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name == tabPageTours.Name)
            {
                this.FillingDataComboBoxCountries();
            }
            // Для вкаладки регистрация ничего не подгружаем.
            else if (tabControl.SelectedTab.Name == tabPageAdminForm.Name)
            {
                Console.WriteLine("TODO: loading admins data all table");
                await LoadAllCountriesForAdminTab();
            }
        }

        private async Task LoadAllCountriesForAdminTab()
        {
            // Загрузка стран
            responseJson = await api.LoadAllCountriesDataAsync();

            this.dataGridViewCountries.DataSource
                = JsonConvert.DeserializeObject<List<Country>>(responseJson)
                .ToList();
        }
    }
}
