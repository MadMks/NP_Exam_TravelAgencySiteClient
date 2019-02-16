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
using TravelAgencySiteClient.DescriptionForm;
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

            this.FillingDataComboBoxCountries();

            this.tabControl.SelectedIndexChanged 
                += TabControl_SelectedIndexChanged;


            // Tours tab
            this.dataGridViewTours.CellDoubleClick 
                += DataGridViewTours_CellDoubleClick;
            this.comboBoxCountries.SelectedIndexChanged 
                += ComboBoxCountries_SelectedIndexChanged;
            this.comboBoxCities.SelectedIndexChanged
                += ComboBoxCities_SelectedIndexChanged;


            // Register tab
            this.buttonRegister.Click += ButtonRegister_Click;


            // Admin tabs
            this.tabControlAdmin.SelectedIndexChanged
                += TabControlAdmin_SelectedIndexChanged;
            // Country tab
            this.buttonAddCountry.Click += ButtonAddCountry_Click;
            this.buttonDelCountry.Click += ButtonDelCountry_Click;
            // City tab
            this.buttonAddCity.Click += ButtonAddCity_Click;
            this.buttonDelCity.Click += ButtonDelCity_Click;
            // Hotel tab
            this.buttonAddHotel.Click += ButtonAddHotel_Click;
            this.buttonDelHotel.Click += ButtonDelHotel_Click;
            this.textBoxHotelCost.KeyPress += TextBoxHotelCost_KeyPress;
        }

        private void TextBoxHotelCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ввод в текстБокс только цифр
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void ComboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Выбранная страна.
            string country = comboBoxCountries.SelectedItem.ToString();
            // Выбранный город.
            string city = comboBoxCities.SelectedItem.ToString();

            // Заполнение таблицы отелей.
            this.FillingDataGridViewHotels(country, city);
        }

        private void ComboBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Выбранная страна.
            string country = comboBoxCountries.SelectedItem.ToString();

            // Заполнение списка городов.
            this.FillingDataComboBoxCities(country);
        }

        private void ButtonDelHotel_Click(object sender, EventArgs e)
        {
            string hotelId =
                this.dataGridViewHotels
                .SelectedRows[0]
                .Cells["id"]
                .Value.ToString();
            Console.WriteLine("hotel id = " + hotelId);
            this.DelHotel(hotelId);
        }

        private async void DelHotel(string hotelId)
        {
            responseJson = await api.DelHotelAsync(hotelId);

            await LoadAllHotelsForAdminTab();
        }

        private void ButtonDelCity_Click(object sender, EventArgs e)
        {
            string cityId =
                this.dataGridViewCities
                .SelectedRows[0]
                .Cells["id"]
                .Value.ToString();
            Console.WriteLine("city id = " + cityId);
            this.DelCity(cityId);
        }

        private async void DelCity(string cityId)
        {
            responseJson = await api.DelCityAsync(cityId);

            await LoadAllCitiesForAdminTab();
        }

        private void ButtonDelCountry_Click(object sender, EventArgs e)
        {
            string countryId =
                this.dataGridViewCountries
                .SelectedRows[0]
                .Cells["id"]
                .Value.ToString();

            this.DelCountry(countryId);
        }

        private async void DelCountry(string countryId)
        {
            responseJson = await api.DelCountryAsync(countryId);

            Console.WriteLine("Delete id: " + countryId + " = " + responseJson);

            await LoadAllCountriesForAdminTab();
        }

        private void ButtonAddHotel_Click(object sender, EventArgs e)
        {
            // TODO проверка заполнения полей

            Hotel hotel = new Hotel();

            hotel.hotelName = this.textBoxHotelName.Text;
            hotel.countryName
                = this.comboBoxHotelCityAndCountry.SelectedItem
                .ToString()
                .Split(':')[0]
                .TrimEnd();
            hotel.cityName 
                = this.comboBoxHotelCityAndCountry.SelectedItem
                .ToString()
                .Split(':')[1]
                .TrimStart();
            hotel.stars = Convert.ToInt32(this.numericUpDownHotelStars.Value);
            hotel.cost = Convert.ToInt32(this.textBoxHotelCost.Text);
            hotel.info = this.textBoxHotelDesc.Text;

            this.textBoxHotelName.Text = "";
            this.textBoxHotelCost.Text = "0";
            this.numericUpDownHotelStars.Value = 1;
            this.textBoxHotelDesc.Text = "";

            this.AddNewHotel(hotel);
        }

        private async void AddNewHotel(Hotel hotel)
        {
            responseJson = await api.AddHotelAsync(hotel);

            Console.WriteLine("AddNewHotel: " + responseJson);

            await LoadAllHotelsForAdminTab();
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

                await LoadAllHotelsForAdminTab();

                await FillingDataComboBoxCityAndCountry();
            }
        }

        private async Task FillingDataComboBoxCityAndCountry()
        {
            responseJson = await api.LoadAllCitiesDataAsync();

            this.comboBoxHotelCityAndCountry.DataSource
                = JsonConvert.DeserializeObject<List<City>>(responseJson)
                .Select(c => c.countryName + " : " + c.cityName).Distinct()
                .ToList<string>();
        }

        private async Task LoadAllHotelsForAdminTab()
        {
            responseJson = await api.LoadAllHotelsDataAsync();

            this.dataGridViewHotels.DataSource
                = JsonConvert.DeserializeObject<List<Hotel>>(responseJson)
                .ToList();

            this.dataGridViewHotels.Columns["stars"].Visible = false;
            this.dataGridViewHotels.Columns["cost"].Visible = false;
            this.dataGridViewHotels.Columns["info"].Visible = false;
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
            responseJson = await api.LoadAllCitiesDataAsync();

            this.dataGridViewCities.DataSource
                = JsonConvert.DeserializeObject<List<City>>(responseJson)
                .ToList();
        }

        private void ButtonAddCountry_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxAddCountry.Text))
            {
                string country = textBoxAddCountry.Text;

                this.textBoxAddCountry.Text = "";

                this.AddNewCountry(country);
            }
            else
            {
                MessageBox.Show(
                    "Введите название страны!",
                    "Не заполнено поле!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        private void ButtonAddCity_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxAddCity.Text))
            {
                string country = this.comboBoxCountriesForAddCity.SelectedItem as string;
                string city = this.textBoxAddCity.Text;

                this.textBoxAddCity.Text = "";

                this.AddNewCity(country, city);
            }
            else
            {
                MessageBox.Show(
                    "Введите название города!",
                    "Не заполнено поле!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private async void AddNewCountry(string country)
        {
            responseJson = await api.AddCountryAsync(country);

            Console.WriteLine("AddNewCountry: " + responseJson);
            
            await LoadAllCountriesForAdminTab();
        }

        private async void AddNewCity(string country, string city)
        {
            responseJson = await api.AddCityAsync(country, city);

            Console.WriteLine("AddNewCity: " + responseJson);

            await LoadAllCitiesForAdminTab();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (this.IsRegFieldsAreFilled())
            {
                string login = textBoxLogin.Text;
                string pass = textBoxPassword.Text;
                string email = textBoxEmail.Text;

                this.NewUserRegistration(login, pass, email);
            }
            else
            {
                MessageBox.Show(
                    "Заполните все поля!",
                    "Не заполнены поля!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool IsRegFieldsAreFilled()
        {
            if (String.IsNullOrEmpty(textBoxLogin.Text)
                || String.IsNullOrEmpty(textBoxPassword.Text)
                || String.IsNullOrEmpty(textBoxEmail.Text))
            {
                return false;
            }

            return true;
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
        }

        private void DataGridViewTours_CellDoubleClick
            (object sender, DataGridViewCellEventArgs e)
        {
            string hotel 
                = this.dataGridViewTours.SelectedCells[1].Value.ToString();
            string desc 
                = this.dataGridViewTours.SelectedCells[6].Value.ToString();

            Console.WriteLine("Показываем страницу отеля");
            Console.WriteLine((sender as DataGridView).SelectedCells[1].Value);

            DescForm descForm = new DescForm();
            descForm.Text += ": " + hotel;
            descForm.Description = desc;
            descForm.Show();
        }

        private async void FillingDataGridViewHotels(string country, string city)
        {
            responseJson = await api.LoadHotelsDataAsync(country, city);

            Console.WriteLine(" > Загрузка отелей в таблицу.");

            this.dataGridViewTours.DataSource
                = JsonConvert.DeserializeObject<List<Hotel>>(responseJson)
                .ToList();

            this.dataGridViewTours.Columns["cityName"].Visible = false;
            this.dataGridViewTours.Columns["countryName"].Visible = false;
        }

        private async void FillingDataComboBoxCities(string country)
        {
            responseJson = await api.LoadCitiesDataAsync(country);

            this.comboBoxCities.DataSource
                = JsonConvert.DeserializeObject<List<City>>(responseJson)
                .Select(c => c.cityName).ToList();
        }

        private async void FillingDataComboBoxCountries()
        {
            responseJson = await api.LoadCountriesDataAsync();

            this.comboBoxCountries.DataSource
                = JsonConvert.DeserializeObject<List<Country>>(responseJson)
                .Select(c => c.countryName).ToList();
        }

        private async void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name == tabPageTours.Name)
            {
                this.FillingDataComboBoxCountries();
            }
            // Для вкаладки регистрация ничего не подгружаем.
            // Для вкладки админа загрузим по умолчанию все страны.
            else if (tabControl.SelectedTab.Name == tabPageAdminForm.Name)
            {
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
