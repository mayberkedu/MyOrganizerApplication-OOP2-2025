using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOrganizerApplication
{
    public partial class Reminder : Form
    {
        public static List<Alarm> alarmList = new List<Alarm>();
        public static List<Alarm> userAlarmList = new List<Alarm>();
        public static string path = "reminder.csv";
        Kullanici user = LoginedUser.getInstance().UserGetSet;
        public Reminder()
        {
            InitializeComponent();
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
        string type;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if ((rdoMeeting.Checked == false && rdoTask.Checked == false) || dateTimePicker1.Checked == false || mtxtTime.Text == "" || txtSummary.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Please fill in the blanks!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rdoMeeting.Checked == true) type = "Meeting";
                if (rdoTask.Checked == true) type = "Task";
                Alarm reminderadd = new Alarm(user.Username.ToString(), type, dateTimePicker1.Text, mtxtTime.Text, txtSummary.Text, txtDescription.Text);
                alarmList.Add(reminderadd);
                Functions.SaveReminder(alarmList, path);
                MessageBox.Show("Registration successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int secilen = dgvRemainderList.SelectedCells[0].RowIndex;
            for (int i = 0; i < alarmList.Count; i++)
            {
                if (alarmList[i].Description == userAlarmList[secilen].Description && alarmList[i].User == userAlarmList[secilen].User && alarmList[i].Summary == userAlarmList[secilen].Summary && alarmList[i].Time == userAlarmList[secilen].Time && alarmList[i].Day==userAlarmList[secilen].Day && alarmList[i].Type == userAlarmList[secilen].Type)
                {
                    alarmList.RemoveAt(i);
                    Functions.SaveReminder(alarmList, path);
                    MessageBox.Show("Remainder Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int secilen = dgvRemainderList.SelectedCells[0].RowIndex;
            for (int i = 0; i < alarmList.Count; i++)
            {
                if (alarmList[i].Description == userAlarmList[secilen].Description && alarmList[i].User == userAlarmList[secilen].User && alarmList[i].Summary == userAlarmList[secilen].Summary && alarmList[i].Time == userAlarmList[secilen].Time && alarmList[i].Day == userAlarmList[secilen].Day && alarmList[i].Type == userAlarmList[secilen].Type)
                {
                    if (rdoMeeting.Checked == true)
                    {
                        alarmList[i].Type = "Meeting";
                    }
                    if (rdoTask.Checked == true)
                    {
                        alarmList[i].Type = "Task";
                    }
                    alarmList[i].Day = dateTimePicker1.Text;
                    alarmList[i].Time = mtxtTime.Text;
                    alarmList[i].Summary = txtSummary.Text;
                    alarmList[i].Description = txtDescription.Text;
                    Functions.SaveReminder(alarmList, path);
                    MessageBox.Show("Update successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            dgvRemainderList.DataSource = null;
            userAlarmList.Clear();
            for (int i = 0; i < alarmList.Count(); i++)
            {
                if (alarmList[i].User == user.Username)
                {
                    userAlarmList.Add(alarmList[i]);
                }
            }
            dgvRemainderList.DataSource = userAlarmList;
            dgvRemainderList.Columns[0].Visible = false;
        }
        private void Reminder_Load(object sender, EventArgs e)
        {
            Functions.LoadReminder(alarmList, path);
        }
        private void dgvRemainderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvRemainderList.SelectedCells[0].RowIndex;
            if (dgvRemainderList.Rows[secilen].Cells[1].Value.ToString() == "Meeting")
            {
                rdoMeeting.Checked = true;
            }
            if (dgvRemainderList.Rows[secilen].Cells[1].Value.ToString() == "Task")
            {
                rdoTask.Checked = true;
            }
            dateTimePicker1.Text = dgvRemainderList.Rows[secilen].Cells[2].Value.ToString();
            mtxtTime.Text = dgvRemainderList.Rows[secilen].Cells[3].Value.ToString();
            txtSummary.Text = dgvRemainderList.Rows[secilen].Cells[4].Value.ToString();
            txtDescription.Text = dgvRemainderList.Rows[secilen].Cells[5].Value.ToString();
        }
        private void Day_TimeShow_Tick(object sender, EventArgs e)
        {
            lblShowTime.Text = DateTime.Now.ToLongDateString() + Environment.NewLine + DateTime.Now.ToLongTimeString();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

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
            saveFileDialog.Title = "Save Reminders";
            saveFileDialog.FileName = "reminders.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        sw.WriteLine("User,Type,Day,Time,Summary,Description");

                        var currentUserReminders = alarmList.Where(alarm => alarm.User == user.Username).ToList();

                        foreach (var alarm in currentUserReminders)
                        {
                            sw.WriteLine($"{alarm.User},{alarm.Type},{alarm.Day},{alarm.Time},{alarm.Summary},{alarm.Description}");
                        }
                    }
                    MessageBox.Show("Reminders have been successfully saved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving reminders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblSummary_Click(object sender, EventArgs e)
        {

        }
    }
}
