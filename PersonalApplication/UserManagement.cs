using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;

namespace MyOrganizerApplication
{
    public partial class UserManagement : Form
    {
        public static UserManagement mana;
        public UserManagement()
        {
            mana = this;
            InitializeComponent();
        }
        string currentPassword;
        private void Management_Load(object sender, EventArgs e)
        {
            currentPassword = TxtPassword.Text;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = LoginForm.userList;
            for (int i = 0; i < LoginForm.userList.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i;
            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to go back to main menu?", "Go Back Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Kullanici user = LoginedUser.getInstance().UserGetSet;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            if (secilen == 0 && user.Usertypes != "*Admin")
            {
                MessageBox.Show("No changes can be made via admin", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TxtRegisterNo.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                TxtUsername.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                TxtPassword.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                TxtUsertypes.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                label1.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
                TxtSalary.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            if ((LoginForm.userList[secilen].Usertypes == "*Admin"))
            {
                MessageBox.Show("*Admin can not delete !!! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LoginForm.userList.RemoveAt(secilen);
                Functions.SaveCsv(LoginForm.userList, LoginForm.path);
                MessageBox.Show("Deleting...");
                List();
                deleteText();
            }
        }
        private void BtnLists_Click(object sender, EventArgs e)
        {
            List();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            progressBar.Visible = true;
            
            //Kayıt olunması için gereken onayın alınması için atılan sayaç
            int accept = 0;
            for (int i = 0; i < LoginForm.userList.Count; i++)
            {
                if (TxtUsername.Text == LoginForm.userList[i].Username &&
                    (TxtPassword.Text) == LoginForm.userList[i].AccoundPassword &&
                    LoginForm.userList[i].Usertypes == TxtUsertypes.Text && LoginForm.userList[i].Salary == TxtSalary.Text)
                {
                    MessageBox.Show("User already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    accept++;
                    break;
                }
                else if (TxtUsername.Text == "" || TxtPassword.Text == "")
                {
                    MessageBox.Show("Please enter username and password!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    accept++;
                    break;
                }
                else if (TxtUsertypes.Text == "*Admin")
                {
                    MessageBox.Show("*Admin already exists! There can be only one in this system.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    accept++;
                    break;
                }
                if (TxtUsertypes.Text != "Admin" && TxtUsertypes.Text != "admin" && TxtUsertypes.Text != "user" && TxtUsertypes.Text != "part-time-user")
                {
                    MessageBox.Show("There is no such user type.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    accept++;
                    break;
                }
            }    
            if (accept == 0)
            {
                progressBar.Value = 50;
                if (LoginForm.userList[0].Usertypes == "*Admin")
                {
                    Kullanici user = LoginForm.userList[int.Parse(TxtRegisterNo.Text)];
                    user.Username = TxtUsername.Text;
                    user.AccoundPassword = (TxtPassword.Text);
                    user.Usertypes = TxtUsertypes.Text;
                    user.Salary = TxtSalary.Text;
                    Functions.SaveCsv(LoginForm.userList, LoginForm.path);
                    MessageBox.Show("Updating...");
                    
                    progressBar.Value = 75;
                    if (currentPassword != user.AccoundPassword)
                    {
                        string email = label1.Text;
                        string new_password = user.AccoundPassword;
                        

                        // Open the default email client with a new email
                        OpenEmailClient(email, "Password Reset", "Your new password is: " + new_password);

                        //progressBar.Visible = false;
                        MessageBox.Show("Email client opened successfully");
                        progressBar.Value = 100;
                    }
                    deleteText();
                }
                else
                {
                    MessageBox.Show("*Admin ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void List()
        {
            Functions.LoadCsv(LoginForm.userList, LoginForm.path);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = LoginForm.userList;
            for (int i = 0; i < LoginForm.userList.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i;
            }
        }
        private void deleteText()
        {
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            TxtUsertypes.Text = "";
            TxtRegisterNo.Text = "";
            TxtSalary.Text = "";
        }


        private void OpenEmailClient(string toEmail, string subject, string body)
        {
            try
            {
                string mailto = string.Format("mailto:{0}?subject={1}&body={2}", toEmail, Uri.EscapeDataString(subject), Uri.EscapeDataString(body));
                System.Diagnostics.Process.Start(mailto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open email client: " + ex.Message);
            }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "TSV Dosyası|*.tsv";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(save.FileName);
                for (int i = 0; i < LoginForm.userList.Count; i++)
                {
                    Kullanici user = LoginForm.userList[i];
                    Kayit.WriteLine(user.Username + "\t" + user.AccoundPassword + "\t" + user.RememberMe);
                }
                Kayit.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
