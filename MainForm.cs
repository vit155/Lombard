using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lombard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        internal enum DBStatus
        { 
            New,
            Loaded,
            Saved
        }

        private void SetStatusMessage(DBStatus st, string path)
        {
            switch (st)
            {
               case DBStatus.New: status_label.Text = "Нова незбережена база"; break;
               case DBStatus.Loaded: status_label.Text = "Загружена база з файла - " + path; break;
               case DBStatus.Saved: status_label.Text = "База збережена в файл - " + path; break;
            }

        }

        private void UpdateUnsavedMessage()
        {
            bool isUnsaved = MainDB.GetInstance().isDBChanged();

            if (isUnsaved)
            {
                has_unsaved_label.Text = "Є незбережені зміни";
            }
            else 
            {
                has_unsaved_label.Text = "Немає незбережених змін";
            }

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.CheckPathExists = true;
            ofd.CheckFileExists = true;
            ofd.DefaultExt = "ldb";
            ofd.Filter = "ldb files (*.ldb)|*.ldb|All files (*.*)|*.*";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MainDB.GetInstance().LoadDBFromFile(ofd.FileName);
                SetStatusMessage(DBStatus.Loaded, ofd.FileName);
                MainDB.GetInstance().acceptDBChanges();

            }

            
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();  
            clientForm.ShowDialog();
            UpdateUnsavedMessage();


        }

        private void ThingButton_Click(object sender, EventArgs e)
        {
            if (MainDB.GetInstance().GetMainDataset().CustomerDataTable.Rows.Count != 0)
            {
                ThingForm clientForm = new ThingForm();
                clientForm.ShowDialog();
                UpdateUnsavedMessage();

            }
            else
            {
                MessageBox.Show("Спочатку треба додати хоч одного клієнта", "Немає клієнтів", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }

            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.CheckPathExists = true;
            sfd.DefaultExt = "ldb";
            sfd.Filter = "ldb files (*.ldb)|*.ldb|All files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MainDB.GetInstance().SaveDBToFile(sfd.FileName);
                SetStatusMessage(DBStatus.Saved, sfd.FileName);
                MainDB.GetInstance().acceptDBChanges();
                UpdateUnsavedMessage();
            }
                  
            
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MainDB.GetInstance().isDBChanged())
            {
                var result = MessageBox.Show("Є незбережені зміни, чи дійсно бажаєте вийти?", "Вихід?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }

            }
        
        }
    }
}
