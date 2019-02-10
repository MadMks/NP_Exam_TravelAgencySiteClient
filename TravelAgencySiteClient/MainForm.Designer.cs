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
            this.dataGridViewTours = new System.Windows.Forms.DataGridView();
            this.buttonSelectCity = new System.Windows.Forms.Button();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.buttonSelectCountry = new System.Windows.Forms.Button();
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.labelSelectTours = new System.Windows.Forms.Label();
            this.tabPageRegistration = new System.Windows.Forms.TabPage();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.tabPageAdminForm = new System.Windows.Forms.TabPage();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPageCountries = new System.Windows.Forms.TabPage();
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.buttonDelCountry = new System.Windows.Forms.Button();
            this.textBoxAddCountry = new System.Windows.Forms.TextBox();
            this.buttonAddCountry = new System.Windows.Forms.Button();
            this.tabPageCities = new System.Windows.Forms.TabPage();
            this.comboBoxCountriesForAddCity = new System.Windows.Forms.ComboBox();
            this.dataGridViewCities = new System.Windows.Forms.DataGridView();
            this.buttonDelCity = new System.Windows.Forms.Button();
            this.textBoxAddCity = new System.Windows.Forms.TextBox();
            this.buttonAddCity = new System.Windows.Forms.Button();
            this.tabPageHotels = new System.Windows.Forms.TabPage();
            this.tabPageImages = new System.Windows.Forms.TabPage();
            this.comboBoxHotelCityAndCountry = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDelHotel = new System.Windows.Forms.Button();
            this.textBoxHotelCost = new System.Windows.Forms.TextBox();
            this.buttonAddHotel = new System.Windows.Forms.Button();
            this.textBoxHotelName = new System.Windows.Forms.TextBox();
            this.textBoxHotelDesc = new System.Windows.Forms.TextBox();
            this.labelHotelDesc = new System.Windows.Forms.Label();
            this.labelHotelName = new System.Windows.Forms.Label();
            this.labelHotelCost = new System.Windows.Forms.Label();
            this.labelHotelStars = new System.Windows.Forms.Label();
            this.numericUpDownHotelStars = new System.Windows.Forms.NumericUpDown();
            this.tabControl.SuspendLayout();
            this.tabPageTours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).BeginInit();
            this.tabPageRegistration.SuspendLayout();
            this.tabPageAdminForm.SuspendLayout();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageCountries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            this.tabPageCities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).BeginInit();
            this.tabPageHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHotelStars)).BeginInit();
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
            this.tabControl.Size = new System.Drawing.Size(578, 416);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageTours
            // 
            this.tabPageTours.Controls.Add(this.dataGridViewTours);
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
            // dataGridViewTours
            // 
            this.dataGridViewTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTours.Location = new System.Drawing.Point(13, 123);
            this.dataGridViewTours.MultiSelect = false;
            this.dataGridViewTours.Name = "dataGridViewTours";
            this.dataGridViewTours.ReadOnly = true;
            this.dataGridViewTours.RowTemplate.Height = 23;
            this.dataGridViewTours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTours.Size = new System.Drawing.Size(544, 177);
            this.dataGridViewTours.TabIndex = 5;
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
            // comboBoxCities
            // 
            this.comboBoxCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(10, 82);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCities.TabIndex = 3;
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
            // comboBoxCountries
            // 
            this.comboBoxCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Location = new System.Drawing.Point(10, 44);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountries.TabIndex = 1;
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
            // tabPageRegistration
            // 
            this.tabPageRegistration.Controls.Add(this.buttonRegister);
            this.tabPageRegistration.Controls.Add(this.textBoxEmail);
            this.tabPageRegistration.Controls.Add(this.labelEmail);
            this.tabPageRegistration.Controls.Add(this.textBoxPassword);
            this.tabPageRegistration.Controls.Add(this.labelPassword);
            this.tabPageRegistration.Controls.Add(this.textBoxLogin);
            this.tabPageRegistration.Controls.Add(this.labelLogin);
            this.tabPageRegistration.Location = new System.Drawing.Point(4, 22);
            this.tabPageRegistration.Name = "tabPageRegistration";
            this.tabPageRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistration.Size = new System.Drawing.Size(570, 314);
            this.tabPageRegistration.TabIndex = 1;
            this.tabPageRegistration.Text = "Регистрация";
            this.tabPageRegistration.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(40, 117);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(124, 23);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "Регистрация";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(63, 76);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(134, 21);
            this.textBoxEmail.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(11, 79);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(63, 44);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(134, 21);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(11, 48);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(48, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Пароль:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(63, 13);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(134, 21);
            this.textBoxLogin.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(11, 16);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(41, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Логин:";
            // 
            // tabPageAdminForm
            // 
            this.tabPageAdminForm.Controls.Add(this.tabControlAdmin);
            this.tabPageAdminForm.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdminForm.Name = "tabPageAdminForm";
            this.tabPageAdminForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdminForm.Size = new System.Drawing.Size(570, 390);
            this.tabPageAdminForm.TabIndex = 2;
            this.tabPageAdminForm.Text = "Админ";
            this.tabPageAdminForm.UseVisualStyleBackColor = true;
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPageCountries);
            this.tabControlAdmin.Controls.Add(this.tabPageCities);
            this.tabControlAdmin.Controls.Add(this.tabPageHotels);
            this.tabControlAdmin.Controls.Add(this.tabPageImages);
            this.tabControlAdmin.Location = new System.Drawing.Point(7, 17);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(557, 367);
            this.tabControlAdmin.TabIndex = 4;
            // 
            // tabPageCountries
            // 
            this.tabPageCountries.Controls.Add(this.dataGridViewCountries);
            this.tabPageCountries.Controls.Add(this.buttonDelCountry);
            this.tabPageCountries.Controls.Add(this.textBoxAddCountry);
            this.tabPageCountries.Controls.Add(this.buttonAddCountry);
            this.tabPageCountries.Location = new System.Drawing.Point(4, 22);
            this.tabPageCountries.Name = "tabPageCountries";
            this.tabPageCountries.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCountries.Size = new System.Drawing.Size(549, 265);
            this.tabPageCountries.TabIndex = 0;
            this.tabPageCountries.Text = "Страны";
            this.tabPageCountries.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Location = new System.Drawing.Point(6, 8);
            this.dataGridViewCountries.MultiSelect = false;
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.ReadOnly = true;
            this.dataGridViewCountries.RowTemplate.Height = 23;
            this.dataGridViewCountries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCountries.Size = new System.Drawing.Size(537, 178);
            this.dataGridViewCountries.TabIndex = 0;
            // 
            // buttonDelCountry
            // 
            this.buttonDelCountry.Location = new System.Drawing.Point(458, 229);
            this.buttonDelCountry.Name = "buttonDelCountry";
            this.buttonDelCountry.Size = new System.Drawing.Size(75, 23);
            this.buttonDelCountry.TabIndex = 2;
            this.buttonDelCountry.Text = "Удалить";
            this.buttonDelCountry.UseVisualStyleBackColor = true;
            // 
            // textBoxAddCountry
            // 
            this.textBoxAddCountry.Location = new System.Drawing.Point(14, 202);
            this.textBoxAddCountry.Name = "textBoxAddCountry";
            this.textBoxAddCountry.Size = new System.Drawing.Size(219, 21);
            this.textBoxAddCountry.TabIndex = 3;
            // 
            // buttonAddCountry
            // 
            this.buttonAddCountry.Location = new System.Drawing.Point(14, 229);
            this.buttonAddCountry.Name = "buttonAddCountry";
            this.buttonAddCountry.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCountry.TabIndex = 1;
            this.buttonAddCountry.Text = "Добавить";
            this.buttonAddCountry.UseVisualStyleBackColor = true;
            // 
            // tabPageCities
            // 
            this.tabPageCities.Controls.Add(this.comboBoxCountriesForAddCity);
            this.tabPageCities.Controls.Add(this.dataGridViewCities);
            this.tabPageCities.Controls.Add(this.buttonDelCity);
            this.tabPageCities.Controls.Add(this.textBoxAddCity);
            this.tabPageCities.Controls.Add(this.buttonAddCity);
            this.tabPageCities.Location = new System.Drawing.Point(4, 22);
            this.tabPageCities.Name = "tabPageCities";
            this.tabPageCities.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCities.Size = new System.Drawing.Size(549, 265);
            this.tabPageCities.TabIndex = 1;
            this.tabPageCities.Text = "Города";
            this.tabPageCities.UseVisualStyleBackColor = true;
            // 
            // comboBoxCountriesForAddCity
            // 
            this.comboBoxCountriesForAddCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountriesForAddCity.FormattingEnabled = true;
            this.comboBoxCountriesForAddCity.Location = new System.Drawing.Point(301, 204);
            this.comboBoxCountriesForAddCity.Name = "comboBoxCountriesForAddCity";
            this.comboBoxCountriesForAddCity.Size = new System.Drawing.Size(202, 21);
            this.comboBoxCountriesForAddCity.TabIndex = 8;
            // 
            // dataGridViewCities
            // 
            this.dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCities.Location = new System.Drawing.Point(6, 10);
            this.dataGridViewCities.MultiSelect = false;
            this.dataGridViewCities.Name = "dataGridViewCities";
            this.dataGridViewCities.ReadOnly = true;
            this.dataGridViewCities.RowTemplate.Height = 23;
            this.dataGridViewCities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCities.Size = new System.Drawing.Size(537, 178);
            this.dataGridViewCities.TabIndex = 4;
            // 
            // buttonDelCity
            // 
            this.buttonDelCity.Location = new System.Drawing.Point(458, 231);
            this.buttonDelCity.Name = "buttonDelCity";
            this.buttonDelCity.Size = new System.Drawing.Size(75, 23);
            this.buttonDelCity.TabIndex = 6;
            this.buttonDelCity.Text = "Удалить";
            this.buttonDelCity.UseVisualStyleBackColor = true;
            // 
            // textBoxAddCity
            // 
            this.textBoxAddCity.Location = new System.Drawing.Point(14, 204);
            this.textBoxAddCity.Name = "textBoxAddCity";
            this.textBoxAddCity.Size = new System.Drawing.Size(219, 21);
            this.textBoxAddCity.TabIndex = 7;
            // 
            // buttonAddCity
            // 
            this.buttonAddCity.Location = new System.Drawing.Point(14, 231);
            this.buttonAddCity.Name = "buttonAddCity";
            this.buttonAddCity.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCity.TabIndex = 5;
            this.buttonAddCity.Text = "Добавить";
            this.buttonAddCity.UseVisualStyleBackColor = true;
            // 
            // tabPageHotels
            // 
            this.tabPageHotels.Controls.Add(this.numericUpDownHotelStars);
            this.tabPageHotels.Controls.Add(this.labelHotelStars);
            this.tabPageHotels.Controls.Add(this.labelHotelCost);
            this.tabPageHotels.Controls.Add(this.labelHotelName);
            this.tabPageHotels.Controls.Add(this.labelHotelDesc);
            this.tabPageHotels.Controls.Add(this.textBoxHotelDesc);
            this.tabPageHotels.Controls.Add(this.textBoxHotelName);
            this.tabPageHotels.Controls.Add(this.comboBoxHotelCityAndCountry);
            this.tabPageHotels.Controls.Add(this.dataGridView1);
            this.tabPageHotels.Controls.Add(this.buttonDelHotel);
            this.tabPageHotels.Controls.Add(this.textBoxHotelCost);
            this.tabPageHotels.Controls.Add(this.buttonAddHotel);
            this.tabPageHotels.Location = new System.Drawing.Point(4, 22);
            this.tabPageHotels.Name = "tabPageHotels";
            this.tabPageHotels.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHotels.Size = new System.Drawing.Size(549, 341);
            this.tabPageHotels.TabIndex = 2;
            this.tabPageHotels.Text = "Отели";
            this.tabPageHotels.UseVisualStyleBackColor = true;
            // 
            // tabPageImages
            // 
            this.tabPageImages.Location = new System.Drawing.Point(4, 22);
            this.tabPageImages.Name = "tabPageImages";
            this.tabPageImages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImages.Size = new System.Drawing.Size(549, 265);
            this.tabPageImages.TabIndex = 3;
            this.tabPageImages.Text = "Картинки";
            this.tabPageImages.UseVisualStyleBackColor = true;
            // 
            // comboBoxHotelCityAndCountry
            // 
            this.comboBoxHotelCityAndCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHotelCityAndCountry.FormattingEnabled = true;
            this.comboBoxHotelCityAndCountry.Location = new System.Drawing.Point(7, 166);
            this.comboBoxHotelCityAndCountry.Name = "comboBoxHotelCityAndCountry";
            this.comboBoxHotelCityAndCountry.Size = new System.Drawing.Size(289, 21);
            this.comboBoxHotelCityAndCountry.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 10);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(537, 138);
            this.dataGridView1.TabIndex = 9;
            // 
            // buttonDelHotel
            // 
            this.buttonDelHotel.Location = new System.Drawing.Point(468, 164);
            this.buttonDelHotel.Name = "buttonDelHotel";
            this.buttonDelHotel.Size = new System.Drawing.Size(75, 23);
            this.buttonDelHotel.TabIndex = 11;
            this.buttonDelHotel.Text = "Удалить";
            this.buttonDelHotel.UseVisualStyleBackColor = true;
            // 
            // textBoxHotelCost
            // 
            this.textBoxHotelCost.Location = new System.Drawing.Point(280, 223);
            this.textBoxHotelCost.Name = "textBoxHotelCost";
            this.textBoxHotelCost.Size = new System.Drawing.Size(75, 21);
            this.textBoxHotelCost.TabIndex = 12;
            // 
            // buttonAddHotel
            // 
            this.buttonAddHotel.Location = new System.Drawing.Point(468, 276);
            this.buttonAddHotel.Name = "buttonAddHotel";
            this.buttonAddHotel.Size = new System.Drawing.Size(75, 52);
            this.buttonAddHotel.TabIndex = 10;
            this.buttonAddHotel.Text = "Добавить";
            this.buttonAddHotel.UseVisualStyleBackColor = true;
            // 
            // textBoxHotelName
            // 
            this.textBoxHotelName.Location = new System.Drawing.Point(9, 223);
            this.textBoxHotelName.Name = "textBoxHotelName";
            this.textBoxHotelName.Size = new System.Drawing.Size(219, 21);
            this.textBoxHotelName.TabIndex = 14;
            // 
            // textBoxHotelDesc
            // 
            this.textBoxHotelDesc.Location = new System.Drawing.Point(7, 276);
            this.textBoxHotelDesc.Multiline = true;
            this.textBoxHotelDesc.Name = "textBoxHotelDesc";
            this.textBoxHotelDesc.Size = new System.Drawing.Size(435, 52);
            this.textBoxHotelDesc.TabIndex = 16;
            // 
            // labelHotelDesc
            // 
            this.labelHotelDesc.AutoSize = true;
            this.labelHotelDesc.Location = new System.Drawing.Point(6, 254);
            this.labelHotelDesc.Name = "labelHotelDesc";
            this.labelHotelDesc.Size = new System.Drawing.Size(60, 13);
            this.labelHotelDesc.TabIndex = 17;
            this.labelHotelDesc.Text = "Описание:";
            // 
            // labelHotelName
            // 
            this.labelHotelName.AutoSize = true;
            this.labelHotelName.Location = new System.Drawing.Point(6, 200);
            this.labelHotelName.Name = "labelHotelName";
            this.labelHotelName.Size = new System.Drawing.Size(92, 13);
            this.labelHotelName.TabIndex = 18;
            this.labelHotelName.Text = "Название отеля:";
            // 
            // labelHotelCost
            // 
            this.labelHotelCost.AutoSize = true;
            this.labelHotelCost.Location = new System.Drawing.Point(277, 200);
            this.labelHotelCost.Name = "labelHotelCost";
            this.labelHotelCost.Size = new System.Drawing.Size(37, 13);
            this.labelHotelCost.TabIndex = 19;
            this.labelHotelCost.Text = "Цена:";
            // 
            // labelHotelStars
            // 
            this.labelHotelStars.AutoSize = true;
            this.labelHotelStars.Location = new System.Drawing.Point(432, 200);
            this.labelHotelStars.Name = "labelHotelStars";
            this.labelHotelStars.Size = new System.Drawing.Size(78, 13);
            this.labelHotelStars.TabIndex = 20;
            this.labelHotelStars.Text = "Кол-во звезд:";
            // 
            // numericUpDownHotelStars
            // 
            this.numericUpDownHotelStars.Location = new System.Drawing.Point(435, 223);
            this.numericUpDownHotelStars.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownHotelStars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHotelStars.Name = "numericUpDownHotelStars";
            this.numericUpDownHotelStars.Size = new System.Drawing.Size(46, 21);
            this.numericUpDownHotelStars.TabIndex = 21;
            this.numericUpDownHotelStars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownHotelStars.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 440);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Клиент сайта ТурАгенства";
            this.tabControl.ResumeLayout(false);
            this.tabPageTours.ResumeLayout(false);
            this.tabPageTours.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).EndInit();
            this.tabPageRegistration.ResumeLayout(false);
            this.tabPageRegistration.PerformLayout();
            this.tabPageAdminForm.ResumeLayout(false);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageCountries.ResumeLayout(false);
            this.tabPageCountries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            this.tabPageCities.ResumeLayout(false);
            this.tabPageCities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).EndInit();
            this.tabPageHotels.ResumeLayout(false);
            this.tabPageHotels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHotelStars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageTours;
        private System.Windows.Forms.TabPage tabPageRegistration;
        private System.Windows.Forms.TabPage tabPageAdminForm;
        private System.Windows.Forms.Label labelSelectTours;
        private System.Windows.Forms.DataGridView dataGridViewTours;
        private System.Windows.Forms.Button buttonSelectCity;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Button buttonSelectCountry;
        private System.Windows.Forms.ComboBox comboBoxCountries;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.Button buttonDelCountry;
        private System.Windows.Forms.Button buttonAddCountry;
        private System.Windows.Forms.TextBox textBoxAddCountry;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabPageCountries;
        private System.Windows.Forms.TabPage tabPageCities;
        private System.Windows.Forms.TabPage tabPageHotels;
        private System.Windows.Forms.TabPage tabPageImages;
        private System.Windows.Forms.DataGridView dataGridViewCities;
        private System.Windows.Forms.Button buttonDelCity;
        private System.Windows.Forms.TextBox textBoxAddCity;
        private System.Windows.Forms.Button buttonAddCity;
        private System.Windows.Forms.ComboBox comboBoxCountriesForAddCity;
        private System.Windows.Forms.NumericUpDown numericUpDownHotelStars;
        private System.Windows.Forms.Label labelHotelStars;
        private System.Windows.Forms.Label labelHotelCost;
        private System.Windows.Forms.Label labelHotelName;
        private System.Windows.Forms.Label labelHotelDesc;
        private System.Windows.Forms.TextBox textBoxHotelDesc;
        private System.Windows.Forms.TextBox textBoxHotelName;
        private System.Windows.Forms.ComboBox comboBoxHotelCityAndCountry;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDelHotel;
        private System.Windows.Forms.TextBox textBoxHotelCost;
        private System.Windows.Forms.Button buttonAddHotel;
    }
}

