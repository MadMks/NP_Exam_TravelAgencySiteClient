namespace TravelAgencySiteClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTours = new System.Windows.Forms.TabPage();
            this.tabPageRegistration = new System.Windows.Forms.TabPage();
            this.tabPageAdminForm = new System.Windows.Forms.TabPage();
            this.labelSelectTours = new System.Windows.Forms.Label();
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.buttonSelectCountry = new System.Windows.Forms.Button();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.buttonSelectCity = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPageTours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTours);
            this.tabControl.Controls.Add(this.tabPageRegistration);
            this.tabControl.Controls.Add(this.tabPageAdminForm);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(578, 340);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageTours
            // 
            this.tabPageTours.Controls.Add(this.dataGridView1);
            this.tabPageTours.Controls.Add(this.buttonSelectCity);
            this.tabPageTours.Controls.Add(this.comboBoxCities);
            this.tabPageTours.Controls.Add(this.buttonSelectCountry);
            this.tabPageTours.Controls.Add(this.comboBoxCountries);
            this.tabPageTours.Controls.Add(this.labelSelectTours);
            this.tabPageTours.Location = new System.Drawing.Point(4, 22);
            this.tabPageTours.Name = "tabPageTours";
            this.tabPageTours.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTours.Size = new System.Drawing.Size(570, 314);
            this.tabPageTours.TabIndex = 0;
            this.tabPageTours.Text = "Туры";
            this.tabPageTours.UseVisualStyleBackColor = true;
            // 
            // tabPageRegistration
            // 
            this.tabPageRegistration.Location = new System.Drawing.Point(4, 22);
            this.tabPageRegistration.Name = "tabPageRegistration";
            this.tabPageRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistration.Size = new System.Drawing.Size(570, 314);
            this.tabPageRegistration.TabIndex = 1;
            this.tabPageRegistration.Text = "Регистрация";
            this.tabPageRegistration.UseVisualStyleBackColor = true;
            // 
            // tabPageAdminForm
            // 
            this.tabPageAdminForm.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdminForm.Name = "tabPageAdminForm";
            this.tabPageAdminForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdminForm.Size = new System.Drawing.Size(570, 314);
            this.tabPageAdminForm.TabIndex = 2;
            this.tabPageAdminForm.Text = "Админ";
            this.tabPageAdminForm.UseVisualStyleBackColor = true;
            // 
            // labelSelectTours
            // 
            this.labelSelectTours.AutoSize = true;
            this.labelSelectTours.Location = new System.Drawing.Point(7, 16);
            this.labelSelectTours.Name = "labelSelectTours";
            this.labelSelectTours.Size = new System.Drawing.Size(66, 13);
            this.labelSelectTours.TabIndex = 0;
            this.labelSelectTours.Text = "Выбор тура";
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Location = new System.Drawing.Point(10, 44);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountries.TabIndex = 1;
            // 
            // buttonSelectCountry
            // 
            this.buttonSelectCountry.Location = new System.Drawing.Point(153, 44);
            this.buttonSelectCountry.Name = "buttonSelectCountry";
            this.buttonSelectCountry.Size = new System.Drawing.Size(105, 23);
            this.buttonSelectCountry.TabIndex = 2;
            this.buttonSelectCountry.Text = "Выбрать страну";
            this.buttonSelectCountry.UseVisualStyleBackColor = true;
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(10, 82);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCities.TabIndex = 3;
            // 
            // buttonSelectCity
            // 
            this.buttonSelectCity.Location = new System.Drawing.Point(153, 82);
            this.buttonSelectCity.Name = "buttonSelectCity";
            this.buttonSelectCity.Size = new System.Drawing.Size(105, 23);
            this.buttonSelectCity.TabIndex = 4;
            this.buttonSelectCity.Text = "Выбрать город";
            this.buttonSelectCity.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(544, 177);
            this.dataGridView1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 364);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Клиент сайта ТурАгенства";
            this.tabControl.ResumeLayout(false);
            this.tabPageTours.ResumeLayout(false);
            this.tabPageTours.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageTours;
        private System.Windows.Forms.TabPage tabPageRegistration;
        private System.Windows.Forms.TabPage tabPageAdminForm;
        private System.Windows.Forms.Label labelSelectTours;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSelectCity;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Button buttonSelectCountry;
        private System.Windows.Forms.ComboBox comboBoxCountries;
    }
}

