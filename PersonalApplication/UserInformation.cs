using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOrganizerApplication
{
    public partial class UserInformation : Form
    {
        public UserInformation()
        {
            InitializeComponent();
        }

        public string path = "applicationdatabase.csv";
        public int flag = 0;
        Stack<CareTakerDatas> undoStack = new Stack<CareTakerDatas>();
        Stack<CareTakerDatas> redoStack = new Stack<CareTakerDatas>();
        private void Form2_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            Kullanici user = LoginedUser.getInstance().UserGetSet;
            txtUserName.Text = user.Username;
            TxtUserType.Text = user.Usertypes;
            TxtName.Text = user.Name;
            TxtSurname.Text = user.Surname;
            MTxtPhoneNumber.Text = user.PhoneNumber;
            TxtSalary.Text = user.Salary;
            if(user.Usertypes != "*Admin")
            {
                btnAdmin.Enabled = false;
            }
            if (user.Address.Contains("#"))
            {
                user.Address = user.Address.Replace("#", ",");
            }
            TxtAddress.Text = user.Address;
            TxtEmail.Text = user.Email;
            PicPhoto.Image = Functions.Base64ToImage(user.Photo);
            if (user.Usertypes == "Admin" || user.Usertypes == "*Admin" || user.Usertypes == "admin")
            {
                btnAdmin.Enabled = true;
                btnAdmin.BackColor = Color.Transparent;
            }
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("Do you want to log out?", "Log out?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // If the user clicks 'Yes', perform the action to go back
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Kullanici user = LoginedUser.getInstance().UserGetSet;
                user.RememberMe = false;
                Functions.SaveCsv(LoginForm.userList, LoginForm.path);
                this.Close();
            }
            // If the user clicks 'No', do nothing
        }
        private void btnYedekle_Click(object sender, EventArgs e)
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
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement management = new UserManagement();
            
            management.Enabled = true;
            if (management.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }
        private void BtnPhoneBook_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PhoneBook frm = new PhoneBook();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }
        private void btnNoteBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoteBook frm = new NoteBook();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Kullanici user = LoginedUser.getInstance().UserGetSet;
            List<Kullanici> userList = new List<Kullanici>();
            Functions.LoadCsv(userList, path);
            int counter = 0;
            int count = 0;
            for (int i = 0; i < userList.Count; i++)
            {
                if (txtUserName.Text == user.Username)
                {
                    break;
                }
                else if (userList[i].Username == txtUserName.Text)
                {
                    counter++;
                    break;
                }
            }
            if (counter != 1)
            {
                user.Username = txtUserName.Text;
                if (TxtPassword.Text != "")
                {
                    user.AccoundPassword = TxtPassword.Text;
                }
                user.Name = TxtName.Text;
                user.Surname = TxtSurname.Text;
                if (TxtAddress.Text.Contains(","))
                {
                    TxtAddress.Text = TxtAddress.Text.Replace(",", "#");
                }
                user.Address = TxtAddress.Text;
                if (Functions.isEmailValid(TxtEmail.Text))
                {
                    user.Email = TxtEmail.Text;
                    if (MTxtPhoneNumber.Text.Length == 14)
                    {
                        user.PhoneNumber = MTxtPhoneNumber.Text;
                        TxtPassword.Text = "";
                        if (TxtAddress.Text.Contains("#"))
                            TxtAddress.Text = TxtAddress.Text.Replace("#", ",");
                        MessageBox.Show("Update Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        count++;
                        MessageBox.Show("Phone number order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    count++;
                    MessageBox.Show("Email order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string photo;
                if (flag > 0)
                {
                    photo = Functions.ImageToBase64(PicPhoto.ImageLocation);
                    if (count == 0)
                    {
                        user.Photo = photo;
                    }
                    else
                    {
                        PicPhoto.Image = Functions.Base64ToImage(user.Photo);
                    }
                }
            }
            else
            {
                MessageBox.Show("Username already taken.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnImagePath_Click(object sender, EventArgs e)
        {
            flag++;
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            PicPhoto.ImageLocation = file.FileName;
        }
        private void LogOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)26)
            {
                undoRedoOperations(undoStack, redoStack);
            }
            else if (e.KeyChar == (char)25)
            {
                undoRedoOperations(redoStack, undoStack);
            }
            else
            {
                CareTakerDatas datas = new CareTakerDatas();
                Kullanici tempUser = new Kullanici(txtUserName.Text, TxtPassword.Text, false, "", TxtName.Text, TxtSurname.Text, MTxtPhoneNumber.Text, TxtAddress.Text, TxtEmail.Text, "", "");
                if (flag == 0)
                {
                    tempUser.Photo = LoginedUser.getInstance().UserGetSet.Photo;
                }
                else
                    tempUser.Photo = Functions.ImageToBase64(PicPhoto.ImageLocation);
                datas.Memento = tempUser.Save();
                undoStack.Push(datas);
            }
        }
        private void undoRedoOperations(Stack<CareTakerDatas> mainStack, Stack<CareTakerDatas> backUpStack)
        {
            if (mainStack.Count > 0)
            {
                Kullanici tempUser = new Kullanici();
                CareTakerDatas taker = mainStack.Pop();
                CareTakerDatas oldtaker = new CareTakerDatas();
                tempUser.Undo(taker.Memento);
                txtUserName.Text = tempUser.Username;
                TxtPassword.Text = tempUser.AccoundPassword;
                TxtSurname.Text = tempUser.Surname;
                TxtName.Text = tempUser.Name;
                MTxtPhoneNumber.Text = tempUser.PhoneNumber;
                TxtAddress.Text = tempUser.Address;
                TxtEmail.Text = tempUser.Email;
                PicPhoto.Image = Functions.Base64ToImage(tempUser.Photo);
                oldtaker.Memento = tempUser.Save();
                backUpStack.Push(oldtaker);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalaryCalculator frm = new SalaryCalculator();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }
        private void btnRemainder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reminder frm = new Reminder();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void PicPhoto_Click(object sender, EventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
