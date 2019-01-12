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

            this.tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            this.buttonSelectCountry.Click += ButtonSelectCountry_Click;
        }

        private void ButtonSelectCountry_Click(object sender, EventArgs e)
        {
            // Выбранная страна.
            string country = comboBoxCountries.SelectedItem.ToString();

            // Загрузка списка городов.
            this.FillingDataComboBoxCities(country);
            Console.WriteLine("--- main ");
            // Включение комббокса и кнопки для выбора города.
            this.comboBoxCities.Enabled = true;
            this.buttonSelectCity.Enabled = true;
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
