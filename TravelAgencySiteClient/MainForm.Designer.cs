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
            this.tabPageAdminForm = new System.Windows.Forms.TabPage();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxAdding = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPageTours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).BeginInit();
            this.tabPageRegistration.SuspendLayout();
            this.tabPageAdminForm.SuspendLayout();
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
            // tabPageAdminForm
            // 
            this.tabPageAdminForm.Controls.Add(this.textBoxAdding);
            this.tabPageAdminForm.Controls.Add(this.buttonDel);
            this.tabPageAdminForm.Controls.Add(this.buttonAdd);
            this.tabPageAdminForm.Controls.Add(this.dataGridView1);
            this.tabPageAdminForm.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdminForm.Name = "tabPageAdminForm";
            this.tabPageAdminForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdminForm.Size = new System.Drawing.Size(570, 314);
            this.tabPageAdminForm.TabIndex = 2;
            this.tabPageAdminForm.Text = "Админ";
            this.tabPageAdminForm.UseVisualStyleBackColor = true;
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
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(63, 13);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(134, 21);
            this.textBoxLogin.TabIndex = 1;
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
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(63, 44);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(134, 21);
            this.textBoxPassword.TabIndex = 3;
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
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(63, 76);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(134, 21);
            this.textBoxEmail.TabIndex = 5;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(377, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(25, 270);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(327, 270);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // textBoxAdding
            // 
            this.textBoxAdding.Location = new System.Drawing.Point(25, 237);
            this.textBoxAdding.Name = "textBoxAdding";
            this.textBoxAdding.Size = new System.Drawing.Size(219, 21);
            this.textBoxAdding.TabIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).EndInit();
            this.tabPageRegistration.ResumeLayout(false);
            this.tabPageRegistration.PerformLayout();
            this.tabPageAdminForm.ResumeLayout(false);
            this.tabPageAdminForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAdding;
    }
}

