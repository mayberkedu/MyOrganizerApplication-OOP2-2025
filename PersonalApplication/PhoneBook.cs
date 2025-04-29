using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
namespace MyOrganizerApplication
{
    public partial class PhoneBook : Form
    {
        public static List<Phone> phoneList = new List<Phone>();
        public static List<Phone> userphoneList = new List<Phone>();
        public static string path = "contacts.csv";
        Kullanici user = LoginedUser.getInstance().UserGetSet;
        public PhoneBook()
        {
            InitializeComponent();
        }
        private void FilterAndDisplayCurrentUser(string currentUsername)
        {
            // Geçerli kullanıcıyı filtrele
            var filteredList = phoneList.Where(user => user.User == currentUsername).ToList();

            // DataGridView'e filtrelenmiş listeyi atama
            dataGridView1.DataSource = filteredList;

            // Username sütununu gizleme (isteğe bağlı)
            if (dataGridView1.Columns["User"] != null)
            {
                dataGridView1.Columns["User"].Visible = false;
            }
        }

        public void List()
        {
            //string desiredUsername = user.Username;
            //dataGridView1.DataSource = phoneList;
            //dataGridView1.Columns["User"].Visible = false;
            //if (dataGridView1.Rows.Count > 0)
            //{
            //    var userCellValue = dataGridView1.Rows[0].Cells["User"].Value;
            //}

            FilterAndDisplayCurrentUser(user.Username);
        }
        private void PhoneBook_Load(object sender, EventArgs e)
        {
            Functions.LoadPhoneBook(phoneList, path);
        }
        
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (phoneList.Any())
            {
                for (int i = 0; i < phoneList.Count(); i++)
                {
                    if (txtBox_telno.Text == phoneList[i].Number)
                    {
                        if (phoneList[i].User == user.Username)
                        {
                            MessageBox.Show("User already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            counter++;
                            break;
                        }
                    }
                    else if (txtBox_name.Text == "" || txtBox_surname.Text == "" || txtBox_telno.Text == "" || txtBox_adress.Text == "" || txtBox_description.Text == "" || txtBox_email.Text == "")
                    {
                        MessageBox.Show("Please fill in the blanks!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        counter++;
                        break;
                    }
                }
                if (counter != 1)
                {
                    if (Functions.isEmailValid(txtBox_email.Text))
                    {
                        if (txtBox_telno.Text.Length == 14)
                        {
                            Phone numberAdd = new Phone(user.Username.ToString(), txtBox_name.Text, txtBox_surname.Text, txtBox_telno.Text, txtBox_adress.Text, txtBox_description.Text, txtBox_email.Text);
                            phoneList.Add(numberAdd);
                            Functions.SavePhoneBook(phoneList, path);
                            MessageBox.Show("Registration successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtBox_name.Text = "";
                            txtBox_surname.Text = "";
                            txtBox_telno.Text = "";
                            txtBox_adress.Text = "";
                            txtBox_description.Text = "";
                            txtBox_email.Text = "";
                        }
                        else
                            MessageBox.Show("Phone number order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Email order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (txtBox_name.Text == "" || txtBox_surname.Text == "" || txtBox_telno.Text == "" || txtBox_adress.Text == "" || txtBox_description.Text == "" || txtBox_email.Text == "")
                {
                    MessageBox.Show("Please fill in the blanks!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Functions.isEmailValid(txtBox_email.Text))
                    {
                        if (txtBox_telno.Text.Length == 14)
                        {
                            Phone numberAdd = new Phone(user.Username.ToString(), txtBox_name.Text, txtBox_surname.Text, txtBox_telno.Text, txtBox_adress.Text, txtBox_description.Text, txtBox_email.Text);
                            phoneList.Add(numberAdd);
                            Functions.SavePhoneBook(phoneList, path);
                            MessageBox.Show("Registration Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtBox_name.Text = "";
                            txtBox_surname.Text = "";
                            txtBox_telno.Text = "";
                            txtBox_adress.Text = "";
                            txtBox_description.Text = "";
                            txtBox_email.Text = "";
                            List();
                        }
                        else
                            MessageBox.Show("Phone number order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Email order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtBox_name.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtBox_surname.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtBox_telno.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtBox_adress.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtBox_description.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtBox_email.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                phoneList[secilen].Number = txtBox_telno.Text;
                phoneList[secilen].Name = txtBox_name.Text;
                phoneList[secilen].Surname = txtBox_surname.Text;
                phoneList[secilen].Address = txtBox_adress.Text;
                phoneList[secilen].Description = txtBox_description.Text;
                phoneList[secilen].Mail = txtBox_email.Text;
                Functions.SavePhoneBook(phoneList, path);
                MessageBox.Show("Update Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                phoneList.RemoveAt(secilen);
                Functions.SavePhoneBook(phoneList, path);
                MessageBox.Show("Person deleted!");
                List();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("Do yo want to back to main menu?", "Go Back Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBox_search.Text.ToLower();
            var filteredList = phoneList.Where(p => p.Name.ToLower().Contains(searchText) || p.Surname.ToLower().Contains(searchText)).ToList();
            dataGridView1.DataSource = filteredList;
        }

        private void BtnLists_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List();
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

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Save Contacts";
            saveFileDialog.FileName = "contacts.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        sw.WriteLine("User,Name,Surname,Number,Address,Description,Mail");

                        var currentUserContacts = phoneList.Where(p => p.User == user.Username).ToList();

                        foreach (var phone in currentUserContacts)
                        {
                            sw.WriteLine($"{phone.User},{phone.Name},{phone.Surname},{phone.Number},{phone.Address},{phone.Description},{phone.Mail}");
                        }
                    }
                    MessageBox.Show("Contacts have been saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving contacts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

