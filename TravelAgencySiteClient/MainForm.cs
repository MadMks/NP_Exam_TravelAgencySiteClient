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

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: Метод -> загрузить страны в комбо на странице туров.
            this.FillingDataComboBoxCountries();

            this.tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
        }

        private void FillingDataComboBoxCountries()
        {
            this.LoadCountriesData();

            this.comboBoxCountries.DataSource
                = JsonConvert.DeserializeObject<List<Country>>(responseJson)
                .Select(c => c.Name).ToList();
        }

        private void LoadCountriesData()
        {
            throw new NotImplementedException();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name == tabPageTours.Name)
            {
                Console.WriteLine("TODO: loading countries");
                this.FillingDataComboBoxCountries();
            }
            // Для вкаладки регистрация подгружать ничего не нужно
            else if (tabControl.SelectedTab.Name == tabPageAdminForm.Name)
            {
                Console.WriteLine("TODO: loading admins data all table");
            }
        }
    }
}
