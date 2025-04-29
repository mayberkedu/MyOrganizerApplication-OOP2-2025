using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOrganizerApplication
{
    public partial class SalaryCalculator : Form
    {
        public SalaryCalculator()
        {
            InitializeComponent();
        }
        public string path = "applicationdatabase.csv";
        Kullanici user = LoginedUser.getInstance().UserGetSet;
        private void button1_Click(object sender, EventArgs e)
        {
            double initialSalary = 4500;
            double experience = 0.00;
            double city = 0.00;
            double higher_education = 0.00;
            double foreign_Language_Knowledge = 0.00;
            double management_Task = 0.00;
            double Family_Status = 0.00;
            try
            {
                //Experience
                if (cmbBox_experience.SelectedItem.ToString() == "2-4 Years") experience = 0.60;
                else if (cmbBox_experience.SelectedItem.ToString() == "5-9 Years") experience = 1.00;
                else if (cmbBox_experience.SelectedItem.ToString() == "10-14 Years") experience = 1.20;
                else if (cmbBox_experience.SelectedItem.ToString() == "15-20 Years") experience = 1.35;
                else if (cmbBox_experience.SelectedItem.ToString() == "20+ Years") experience = 1.50;

                //City
                if (cmbBox_city.SelectedItem.ToString() == "İstanbul") city = 0.15;
                else if (cmbBox_city.SelectedItem.ToString() == "Ankara" || cmbBox_city.SelectedItem.ToString() == "İzmir") city = 0.10;
                else if (cmbBox_city.SelectedItem.ToString() == "Kocaeli" || cmbBox_city.SelectedItem.ToString() == "Sakarya" || cmbBox_city.SelectedItem.ToString() == "Düzce" || cmbBox_city.SelectedItem.ToString() == "Bolu" || cmbBox_city.SelectedItem.ToString() == "Yalova" || cmbBox_city.SelectedItem.ToString() == "Edirne" || cmbBox_city.SelectedItem.ToString() == "Kırklareli" || cmbBox_city.SelectedItem.ToString() == "Tekirdağ") city = 0.05;
                else if (cmbBox_city.SelectedItem.ToString() == "Trabzon" || cmbBox_city.SelectedItem.ToString() == "Ordu" || cmbBox_city.SelectedItem.ToString() == "Giresun" || cmbBox_city.SelectedItem.ToString() == "Rize" || cmbBox_city.SelectedItem.ToString() == "Artvin" || cmbBox_city.SelectedItem.ToString() == "Gümüşhane" || cmbBox_city.SelectedItem.ToString() == "Bursa" || cmbBox_city.SelectedItem.ToString() == "Eskişehir" || cmbBox_city.SelectedItem.ToString() == "Bilecik" || cmbBox_city.SelectedItem.ToString() == "Aydın" || cmbBox_city.SelectedItem.ToString() == "Denizli" || cmbBox_city.SelectedItem.ToString() == "Muğla" || cmbBox_city.SelectedItem.ToString() == "Adana" || cmbBox_city.SelectedItem.ToString() == "Mersin" || cmbBox_city.SelectedItem.ToString() == "Balıkesir" || cmbBox_city.SelectedItem.ToString() == "Çanakkale" || cmbBox_city.SelectedItem.ToString() == "Antalya" || cmbBox_city.SelectedItem.ToString() == "Isparta" || cmbBox_city.SelectedItem.ToString() == "Burdur") city = 0.03;
                //Education
                if (chckBox_PrfAssociate.Checked == true) higher_education = 0.35;
                else if (chckBox_PrfPhD.Checked == true) higher_education = 0.30;
                else if (chckBox_NprfPhd.Checked == true) higher_education = 0.15;
                else if (chckBox_PrfMaster.Checked == true) higher_education = 0.10;
                else if (chckBox_NprfMaster.Checked == true) higher_education = 0.05;

                //Language
                if (chckBox_DEnglish.Checked == true || chckBox_GEnglish.Checked == true) foreign_Language_Knowledge = 0.20;
                foreign_Language_Knowledge += Convert.ToInt32(cmbBox_otherLanguage.SelectedItem) * 0.05;
                //Title
                if (cmbBox_title.SelectedItem.ToString() == "Team Leader / Group Manager / Technical Manager / Software Architect") management_Task = 0.50;
                else if (cmbBox_title.SelectedItem.ToString() == "Project Manager") management_Task = 0.75;
                else if (cmbBox_title.SelectedItem.ToString() == "Director / Projects Manager") management_Task = 0.85;
                else if (cmbBox_title.SelectedItem.ToString() == "CTO / General Manager") management_Task = 1.00;
                else if (cmbBox_title.SelectedItem.ToString() == "IT Manager(max 5 personel)") management_Task = 0.40;
                else if (cmbBox_title.SelectedItem.ToString() == "IT Manager(+5 personel)") management_Task = 0.60;

                //Family
                int counter = 0;
                if (chckBox_Married.Checked == true) Family_Status = 0.20;
                if (Convert.ToInt32(cmbBox18.SelectedItem) >= 2) Family_Status += 0.80;
                else if (Convert.ToInt32(cmbBox7.SelectedItem) >= 2) Family_Status += 0.60;
                else if (Convert.ToInt32(cmbBox0.SelectedItem) >= 2) Family_Status += 0.40;
                else if (Convert.ToInt32(cmbBox18.SelectedItem) == 1) Family_Status += 0.40; counter++;
                if (Convert.ToInt32(cmbBox7.SelectedItem) == 1) Family_Status += 0.30; counter++;
                if (Convert.ToInt32(cmbBox0.SelectedItem) == 1 && counter != 2) Family_Status += 0.20;

                txtBoxSalary.Text = Family_Status.ToString();
                if (user.Usertypes == "Admin" || user.Usertypes == "*Admin" || user.Usertypes == "admin" || user.Usertypes == "user" || user.Usertypes == "User")
                {
                    SalaryBuilder vBuilder = new UserSalaryBuilder();
                    vBuilder.Salary.InitialSalary = initialSalary;
                    vBuilder.Salary.City = city;
                    vBuilder.Salary.Experience = experience;
                    vBuilder.Salary.Family_Status1 = Family_Status;
                    vBuilder.Salary.Foreign_Language_Knowledge = foreign_Language_Knowledge;
                    vBuilder.Salary.Higher_education = higher_education;
                    vBuilder.Salary.Management_Task = management_Task;
                    SalaryDirector director = new SalaryDirector();
                    double salary = director.Calculate(vBuilder);
                    txtBoxSalary.Text = salary.ToString();
                }
                else
                {
                    SalaryBuilder vBuilder = new PartTimeUserSalaryBuilder();
                    vBuilder.Salary.InitialSalary = initialSalary;
                    vBuilder.Salary.City = city;
                    vBuilder.Salary.Experience = experience;
                    vBuilder.Salary.Family_Status1 = Family_Status;
                    vBuilder.Salary.Foreign_Language_Knowledge = foreign_Language_Knowledge;
                    vBuilder.Salary.Higher_education = higher_education;
                    vBuilder.Salary.Management_Task = management_Task;
                    SalaryDirector director = new SalaryDirector();
                    double salary = director.Calculate(vBuilder);
                    txtBoxSalary.Text = salary.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill in all the blanks ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Functions.LoadCsv(LoginForm.userList, LoginForm.path);
            for (int i = 0; i < LoginForm.userList.Count; i++)
            {
                if (LoginForm.userList[i].Username == user.Username)
                    LoginForm.userList[i].Salary = txtBoxSalary.Text;
            }
            LoginedUser.getInstance().UserGetSet.Salary = txtBoxSalary.Text;
            Functions.SaveCsv(LoginForm.userList, path);
            MessageBox.Show("Salary saved");
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to back to main menu?", "Go Back Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // If the user clicks 'Yes', perform the action to go back
            if (result == DialogResult.Yes)
            {
                this.Hide();
                UserInformation logOut = new UserInformation();
                logOut.ShowDialog();
                this.Close();
            }
            // If the user clicks 'No', do nothing
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Eğer kullanıcı "Evet" derse uygulamayı kapat
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SalaryCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
