namespace MyOrganizerApplication
{
    partial class SalaryCalculator
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
            this.grpBox_language = new System.Windows.Forms.GroupBox();
            this.LblOtherLanguage = new System.Windows.Forms.Label();
            this.cmbBox_otherLanguage = new System.Windows.Forms.ComboBox();
            this.chckBox_GEnglish = new System.Windows.Forms.CheckBox();
            this.chckBox_DEnglish = new System.Windows.Forms.CheckBox();
            this.grpBox_education = new System.Windows.Forms.GroupBox();
            this.chckBox_NprfPhd = new System.Windows.Forms.CheckBox();
            this.chckBox_NprfMaster = new System.Windows.Forms.CheckBox();
            this.chckBox_PrfAssociate = new System.Windows.Forms.CheckBox();
            this.chckBox_PrfPhD = new System.Windows.Forms.CheckBox();
            this.chckBox_PrfMaster = new System.Windows.Forms.CheckBox();
            this.cmbBox_experience = new System.Windows.Forms.ComboBox();
            this.cmbBox_city = new System.Windows.Forms.ComboBox();
            this.LblExperience = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.grpBox_family = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBox18 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBox0 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBox7 = new System.Windows.Forms.ComboBox();
            this.chckBox_Married = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBoxSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBox_title = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.grpBox_language.SuspendLayout();
            this.grpBox_education.SuspendLayout();
            this.grpBox_family.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_language
            // 
            this.grpBox_language.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_language.Controls.Add(this.LblOtherLanguage);
            this.grpBox_language.Controls.Add(this.cmbBox_otherLanguage);
            this.grpBox_language.Controls.Add(this.chckBox_GEnglish);
            this.grpBox_language.Controls.Add(this.chckBox_DEnglish);
            this.grpBox_language.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBox_language.ForeColor = System.Drawing.SystemColors.Control;
            this.grpBox_language.Location = new System.Drawing.Point(630, 376);
            this.grpBox_language.Margin = new System.Windows.Forms.Padding(6);
            this.grpBox_language.Name = "grpBox_language";
            this.grpBox_language.Padding = new System.Windows.Forms.Padding(6);
            this.grpBox_language.Size = new System.Drawing.Size(609, 212);
            this.grpBox_language.TabIndex = 1;
            this.grpBox_language.TabStop = false;
            this.grpBox_language.Text = "Foreign Language";
            // 
            // LblOtherLanguage
            // 
            this.LblOtherLanguage.AutoSize = true;
            this.LblOtherLanguage.BackColor = System.Drawing.Color.Transparent;
            this.LblOtherLanguage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOtherLanguage.ForeColor = System.Drawing.SystemColors.Control;
            this.LblOtherLanguage.Location = new System.Drawing.Point(4, 97);
            this.LblOtherLanguage.Name = "LblOtherLanguage";
            this.LblOtherLanguage.Size = new System.Drawing.Size(408, 24);
            this.LblOtherLanguage.TabIndex = 8;
            this.LblOtherLanguage.Text = "Other documented foreign language knowledge";
            // 
            // cmbBox_otherLanguage
            // 
            this.cmbBox_otherLanguage.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBox_otherLanguage.FormattingEnabled = true;
            this.cmbBox_otherLanguage.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbBox_otherLanguage.Location = new System.Drawing.Point(8, 127);
            this.cmbBox_otherLanguage.Margin = new System.Windows.Forms.Padding(6);
            this.cmbBox_otherLanguage.Name = "cmbBox_otherLanguage";
            this.cmbBox_otherLanguage.Size = new System.Drawing.Size(126, 36);
            this.cmbBox_otherLanguage.TabIndex = 7;
            // 
            // chckBox_GEnglish
            // 
            this.chckBox_GEnglish.AutoSize = true;
            this.chckBox_GEnglish.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckBox_GEnglish.Location = new System.Drawing.Point(9, 66);
            this.chckBox_GEnglish.Name = "chckBox_GEnglish";
            this.chckBox_GEnglish.Size = new System.Drawing.Size(326, 28);
            this.chckBox_GEnglish.TabIndex = 4;
            this.chckBox_GEnglish.Text = "English language school graduation";
            this.chckBox_GEnglish.UseVisualStyleBackColor = true;
            // 
            // chckBox_DEnglish
            // 
            this.chckBox_DEnglish.AutoSize = true;
            this.chckBox_DEnglish.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckBox_DEnglish.Location = new System.Drawing.Point(8, 32);
            this.chckBox_DEnglish.Name = "chckBox_DEnglish";
            this.chckBox_DEnglish.Size = new System.Drawing.Size(298, 28);
            this.chckBox_DEnglish.TabIndex = 3;
            this.chckBox_DEnglish.Text = "Documented English knowledge";
            this.chckBox_DEnglish.UseVisualStyleBackColor = true;
            // 
            // grpBox_education
            // 
            this.grpBox_education.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_education.Controls.Add(this.chckBox_NprfPhd);
            this.grpBox_education.Controls.Add(this.chckBox_NprfMaster);
            this.grpBox_education.Controls.Add(this.chckBox_PrfAssociate);
            this.grpBox_education.Controls.Add(this.chckBox_PrfPhD);
            this.grpBox_education.Controls.Add(this.chckBox_PrfMaster);
            this.grpBox_education.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBox_education.ForeColor = System.Drawing.SystemColors.Control;
            this.grpBox_education.Location = new System.Drawing.Point(15, 50);
            this.grpBox_education.Margin = new System.Windows.Forms.Padding(6);
            this.grpBox_education.Name = "grpBox_education";
            this.grpBox_education.Padding = new System.Windows.Forms.Padding(6);
            this.grpBox_education.Size = new System.Drawing.Size(582, 207);
            this.grpBox_education.TabIndex = 2;
            this.grpBox_education.TabStop = false;
            this.grpBox_education.Text = "Education Level";
            // 
            // chckBox_NprfPhd
            // 
            this.chckBox_NprfPhd.AutoSize = true;
            this.chckBox_NprfPhd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckBox_NprfPhd.Location = new System.Drawing.Point(20, 161);
            this.chckBox_NprfPhd.Name = "chckBox_NprfPhd";
            this.chckBox_NprfPhd.Size = new System.Drawing.Size(290, 28);
            this.chckBox_NprfPhd.TabIndex = 4;
            this.chckBox_NprfPhd.Text = "Non-profession PhD/Associate ";
            this.chckBox_NprfPhd.UseVisualStyleBackColor = true;
            // 
            // chckBox_NprfMaster
            // 
            this.chckBox_NprfMaster.AutoSize = true;
            this.chckBox_NprfMaster.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckBox_NprfMaster.Location = new System.Drawing.Point(20, 131);
            this.chckBox_NprfMaster.Name = "chckBox_NprfMaster";
            this.chckBox_NprfMaster.Size = new System.Drawing.Size(304, 28);
            this.chckBox_NprfMaster.TabIndex = 3;
            this.chckBox_NprfMaster.Text = "Non-profession  Master\'s degree";
            this.chckBox_NprfMaster.UseVisualStyleBackColor = true;
            // 
            // chckBox_PrfAssociate
            // 
            this.chckBox_PrfAssociate.AutoSize = true;
            this.chckBox_PrfAssociate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckBox_PrfAssociate.Location = new System.Drawing.Point(20, 101);
            this.chckBox_PrfAssociate.Name = "chckBox_PrfAssociate";
            this.chckBox_PrfAssociate.Size = new System.Drawing.Size(409, 28);
            this.chckBox_PrfAssociate.TabIndex = 2;
            this.chckBox_PrfAssociate.Text = "Associate professor related to the profession";
            this.chckBox_PrfAssociate.UseVisualStyleBackColor = true;
            // 
            // chckBox_PrfPhD
            // 
            this.chckBox_PrfPhD.AutoSize = true;
            this.chckBox_PrfPhD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckBox_PrfPhD.Location = new System.Drawing.Point(20, 68);
            this.chckBox_PrfPhD.Name = "chckBox_PrfPhD";
            this.chckBox_PrfPhD.Size = new System.Drawing.Size(279, 28);
            this.chckBox_PrfPhD.TabIndex = 1;
            this.chckBox_PrfPhD.Text = "PhD related to the profession";
            this.chckBox_PrfPhD.UseVisualStyleBackColor = true;
            // 
            // chckBox_PrfMaster
            // 
            this.chckBox_PrfMaster.AutoSize = true;
            this.chckBox_PrfMaster.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckBox_PrfMaster.Location = new System.Drawing.Point(20, 39);
            this.chckBox_PrfMaster.Name = "chckBox_PrfMaster";
            this.chckBox_PrfMaster.Size = new System.Drawing.Size(379, 28);
            this.chckBox_PrfMaster.TabIndex = 0;
            this.chckBox_PrfMaster.Text = "Master\'s degree related to the profession";
            this.chckBox_PrfMaster.UseVisualStyleBackColor = true;
            // 
            // cmbBox_experience
            // 
            this.cmbBox_experience.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBox_experience.FormattingEnabled = true;
            this.cmbBox_experience.Items.AddRange(new object[] {
            "2-4 Years",
            "5-9 Years",
            "10-14 Years",
            "15-20 Years",
            "20+ Years",
            "None"});
            this.cmbBox_experience.Location = new System.Drawing.Point(35, 312);
            this.cmbBox_experience.Margin = new System.Windows.Forms.Padding(6);
            this.cmbBox_experience.Name = "cmbBox_experience";
            this.cmbBox_experience.Size = new System.Drawing.Size(365, 36);
            this.cmbBox_experience.TabIndex = 6;
            // 
            // cmbBox_city
            // 
            this.cmbBox_city.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBox_city.FormattingEnabled = true;
            this.cmbBox_city.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cmbBox_city.Location = new System.Drawing.Point(35, 391);
            this.cmbBox_city.Margin = new System.Windows.Forms.Padding(6);
            this.cmbBox_city.Name = "cmbBox_city";
            this.cmbBox_city.Size = new System.Drawing.Size(365, 36);
            this.cmbBox_city.TabIndex = 7;
            // 
            // LblExperience
            // 
            this.LblExperience.AutoSize = true;
            this.LblExperience.BackColor = System.Drawing.Color.Transparent;
            this.LblExperience.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblExperience.ForeColor = System.Drawing.SystemColors.Control;
            this.LblExperience.Location = new System.Drawing.Point(37, 282);
            this.LblExperience.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblExperience.Name = "LblExperience";
            this.LblExperience.Size = new System.Drawing.Size(119, 28);
            this.LblExperience.TabIndex = 8;
            this.LblExperience.Text = "Experience:";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.BackColor = System.Drawing.Color.Transparent;
            this.LblCity.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCity.ForeColor = System.Drawing.SystemColors.Control;
            this.LblCity.Location = new System.Drawing.Point(37, 357);
            this.LblCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(53, 28);
            this.LblCity.TabIndex = 9;
            this.LblCity.Text = "City:";
            // 
            // grpBox_family
            // 
            this.grpBox_family.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_family.Controls.Add(this.label4);
            this.grpBox_family.Controls.Add(this.label3);
            this.grpBox_family.Controls.Add(this.cmbBox18);
            this.grpBox_family.Controls.Add(this.label2);
            this.grpBox_family.Controls.Add(this.cmbBox0);
            this.grpBox_family.Controls.Add(this.label1);
            this.grpBox_family.Controls.Add(this.cmbBox7);
            this.grpBox_family.Controls.Add(this.chckBox_Married);
            this.grpBox_family.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBox_family.ForeColor = System.Drawing.SystemColors.Control;
            this.grpBox_family.Location = new System.Drawing.Point(630, 50);
            this.grpBox_family.Margin = new System.Windows.Forms.Padding(6);
            this.grpBox_family.Name = "grpBox_family";
            this.grpBox_family.Padding = new System.Windows.Forms.Padding(6);
            this.grpBox_family.Size = new System.Drawing.Size(609, 314);
            this.grpBox_family.TabIndex = 11;
            this.grpBox_family.TabStop = false;
            this.grpBox_family.Text = "Marriage & Children Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "(University undergraduate / associate student)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Child over 18 ";
            // 
            // cmbBox18
            // 
            this.cmbBox18.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBox18.FormattingEnabled = true;
            this.cmbBox18.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbBox18.Location = new System.Drawing.Point(8, 262);
            this.cmbBox18.Margin = new System.Windows.Forms.Padding(6);
            this.cmbBox18.Name = "cmbBox18";
            this.cmbBox18.Size = new System.Drawing.Size(173, 36);
            this.cmbBox18.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "0-6 years old child";
            // 
            // cmbBox0
            // 
            this.cmbBox0.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBox0.FormattingEnabled = true;
            this.cmbBox0.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbBox0.Location = new System.Drawing.Point(9, 93);
            this.cmbBox0.Margin = new System.Windows.Forms.Padding(6);
            this.cmbBox0.Name = "cmbBox0";
            this.cmbBox0.Size = new System.Drawing.Size(172, 36);
            this.cmbBox0.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "7-17 years old child";
            // 
            // cmbBox7
            // 
            this.cmbBox7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBox7.FormattingEnabled = true;
            this.cmbBox7.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbBox7.Location = new System.Drawing.Point(9, 161);
            this.cmbBox7.Margin = new System.Windows.Forms.Padding(6);
            this.cmbBox7.Name = "cmbBox7";
            this.cmbBox7.Size = new System.Drawing.Size(172, 36);
            this.cmbBox7.TabIndex = 7;
            // 
            // chckBox_Married
            // 
            this.chckBox_Married.AutoSize = true;
            this.chckBox_Married.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckBox_Married.Location = new System.Drawing.Point(8, 32);
            this.chckBox_Married.Name = "chckBox_Married";
            this.chckBox_Married.Size = new System.Drawing.Size(305, 28);
            this.chckBox_Married.TabIndex = 3;
            this.chckBox_Married.Text = "Married and spouse not working";
            this.chckBox_Married.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalculate.Location = new System.Drawing.Point(438, 311);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(144, 39);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(438, 473);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 39);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBoxSalary
            // 
            this.txtBoxSalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxSalary.Location = new System.Drawing.Point(438, 391);
            this.txtBoxSalary.Name = "txtBoxSalary";
            this.txtBoxSalary.ReadOnly = true;
            this.txtBoxSalary.Size = new System.Drawing.Size(144, 32);
            this.txtBoxSalary.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(37, 439);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Title:";
            // 
            // cmbBox_title
            // 
            this.cmbBox_title.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBox_title.FormattingEnabled = true;
            this.cmbBox_title.Items.AddRange(new object[] {
            "Team Leader / Group Manager / Technical Manager / Software Architect",
            "Project Manager",
            "Director / Projects Manager",
            "CTO / General Manager",
            "IT Manager(max 5 personel)",
            "IT Manager(+5 personel)",
            "None"});
            this.cmbBox_title.Location = new System.Drawing.Point(35, 473);
            this.cmbBox_title.Margin = new System.Windows.Forms.Padding(6);
            this.cmbBox_title.Name = "cmbBox_title";
            this.cmbBox_title.Size = new System.Drawing.Size(365, 36);
            this.cmbBox_title.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::OOP2_2_PreLab.Properties.Resources.geriLogo;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(15, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 45);
            this.btnBack.TabIndex = 18;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_kapat.BackgroundImage = global::OOP2_2_PreLab.Properties.Resources.exitXLogo;
            this.btn_kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kapat.Location = new System.Drawing.Point(1194, 5);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(45, 45);
            this.btn_kapat.TabIndex = 66;
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // SalaryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::OOP2_2_PreLab.Properties.Resources.login_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 629);
            this.ControlBox = false;
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBox_title);
            this.Controls.Add(this.txtBoxSalary);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpBox_family);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.LblExperience);
            this.Controls.Add(this.cmbBox_city);
            this.Controls.Add(this.cmbBox_experience);
            this.Controls.Add(this.grpBox_education);
            this.Controls.Add(this.grpBox_language);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SalaryCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalaryCalculator";
            this.Load += new System.EventHandler(this.SalaryCalculator_Load);
            this.grpBox_language.ResumeLayout(false);
            this.grpBox_language.PerformLayout();
            this.grpBox_education.ResumeLayout(false);
            this.grpBox_education.PerformLayout();
            this.grpBox_family.ResumeLayout(false);
            this.grpBox_family.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBox_language;
        private System.Windows.Forms.GroupBox grpBox_education;
        private System.Windows.Forms.ComboBox cmbBox_experience;
        private System.Windows.Forms.ComboBox cmbBox_city;
        private System.Windows.Forms.Label LblExperience;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.CheckBox chckBox_NprfPhd;
        private System.Windows.Forms.CheckBox chckBox_NprfMaster;
        private System.Windows.Forms.CheckBox chckBox_PrfAssociate;
        private System.Windows.Forms.CheckBox chckBox_PrfPhD;
        private System.Windows.Forms.CheckBox chckBox_PrfMaster;
        private System.Windows.Forms.ComboBox cmbBox_otherLanguage;
        private System.Windows.Forms.CheckBox chckBox_GEnglish;
        private System.Windows.Forms.CheckBox chckBox_DEnglish;
        private System.Windows.Forms.Label LblOtherLanguage;
        private System.Windows.Forms.GroupBox grpBox_family;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBox0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBox7;
        private System.Windows.Forms.CheckBox chckBox_Married;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBox18;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBoxSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBox_title;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btn_kapat;
    }
}