using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOrganizerApplication
{
    public partial class NoteBook : Form
    {
        public static string path = "notebookdata.csv";
        Kullanici user = LoginedUser.getInstance().UserGetSet;
        List<Notes> listNotebook = new List<Notes>();
        public NoteBook()
        {
            InitializeComponent();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (txtNote.Text == "")
            {
                MessageBox.Show("You cannot save empty note. Please enter your note.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                counter++;
            }
            if (counter != 1)
            {
                Notes note = new Notes(user.Username, txtNote.Text);
                listNotebook.Add(note);
                Functions.SaveNotebook(listNotebook, path);
                MessageBox.Show("Note added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNote.Text = "";
            }
        }
        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            if (txtNote.TextLength > 0)
            {
                txtNote.Text = char.ToUpper(txtNote.Text[0]).ToString() + txtNote.Text.Substring(1);
                txtNote.SelectionStart = txtNote.TextLength;
            }
        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            dgv_list.DataSource = null;
            List();
        }
        public void List()
        {
            //listNotebook = Functions.LoadNotebook(path);
            //dgv_list.DataSource = listNotebook;

            FilterAndDisplayCurrentUser(user.Username);
        }

        private void FilterAndDisplayCurrentUser(string currentUsername)
        {
            // Geçerli kullanıcıyı filtrele
            var filteredList = listNotebook.Where(user => user.Username == currentUsername).ToList();

            // DataGridView'e filtrelenmiş listeyi atama
            dgv_list.DataSource = filteredList;

            // Username sütununu gizleme (isteğe bağlı)
            if (dgv_list.Columns["Username"] != null)
            {
                dgv_list.Columns["Username"].Visible = false;
            }
        }
        private void dgv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgv_list.SelectedCells[0].RowIndex;
            txtNote.Text = dgv_list.Rows[secilen].Cells[1].Value.ToString();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int secilen = dgv_list.SelectedCells[0].RowIndex;
                Notes note = new Notes(user.Username, txtNote.Text);
                listNotebook.RemoveAt(secilen);
                Functions.SaveNotebook(listNotebook, path);
                MessageBox.Show("Note deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List();
                txtNote.Text = "";
            }
            catch (Exception)
            {
            }
        }
        private void NoteBook_Load(object sender, EventArgs e)
        {
            //List();
            ////listNotebook = Functions.LoadNotebook(path);
            ///
            Functions.LoadNotebook(listNotebook, path);

        }
        
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int secilen = dgv_list.SelectedCells[0].RowIndex;
                listNotebook[secilen].Note = txtNote.Text;
                Functions.SaveNotebook(listNotebook, path);
                MessageBox.Show("Note updated successful ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to back to main menu?", "Go Back?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

            // kullanıcı evet derse uygulamayı kapat
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Save Notes";
            saveFileDialog.FileName = "notes.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        sw.WriteLine("Username,Note");

                        var currentUserNotes = listNotebook.Where(note => note.Username == user.Username).ToList();

                        foreach (var note in currentUserNotes)
                        {
                            sw.WriteLine($"{note.Username},{note.Note}");
                        }
                    }
                    MessageBox.Show("Notes saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving notes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_kapat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
