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
            this.buttonSelectCountry.Click += ButtonSelectCountry_Click;
            this.buttonSelectCity.Click += ButtonSelectCity_Click;
            this.dataGridViewTours.CellDoubleClick 
                += DataGridViewTours_CellDoubleClick;
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
                .ToList();
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

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name == tabPageTours.Name)
            {
                this.FillingDataComboBoxCountries();
            }
            // Для вкаладки регистрация подгружать ничего не нужно.
            else if (tabControl.SelectedTab.Name == tabPageAdminForm.Name)
            {
                Console.WriteLine("TODO: loading admins data all table");
            }
        }
    }
}
