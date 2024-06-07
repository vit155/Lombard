using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lombard
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();

            _textbox_array.Add(tax_id_textBox);
            _textbox_array.Add(first_name_textBox);
            _textbox_array.Add(second_name_textBox);
            _textbox_array.Add(city_textBox);
            _textbox_array.Add(address_textBox);
            _textbox_array.Add(passport_textBox);
            _textbox_array.Add(contact_data_textBox);

        }

        private int _index = 0;
        private List<TextBox> _textbox_array = new List<TextBox>();

        private void buttonSaveClients_Click(object sender, EventArgs e)
        {

            MainDB.GetInstance().SaveDBToFile("");

        }

        private void clientEntityBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource = MainDB.GetInstance().GetMainDataset().CustomerDataTable;
           

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Інд. код повинен бути уникальним");
        }

        private void add_button_Click(object sender, EventArgs e)
        {

            LombardDataSet ds = MainDB.GetInstance().GetMainDataset();

            foreach (TextBox tb in _textbox_array)
            {
                tb.Text.Trim();
                
                if (tb.Text.Length == 0)
                {
                    MessageBox.Show("Усі поля повинні бути заповнені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                   
            }

            if (ds.CustomerDataTable.Rows.Find(tax_id_textBox.Text) != null)
            {
                MessageBox.Show("Помилка - вже існує кліент с таким інд. кодом","Помилка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ds.CustomerDataTable.Rows.Add(tax_id_textBox.Text, first_name_textBox.Text, second_name_textBox.Text, city_textBox.Text, address_textBox.Text, passport_textBox.Text, contact_data_textBox.Text);
                
                MainDB.GetInstance().setHasChangesDBState();

            }
            
           

        }

        private void clean_button_Click(object sender, EventArgs e)
        {
               
            foreach (TextBox tb in _textbox_array)
            {
                tb.Text = string.Empty;
            }

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[_index];

            for (int i = 0; i < _textbox_array.Count; i++)
            {
                row.Cells[i].Value = _textbox_array[i].Text;

            }

            MainDB.GetInstance().setHasChangesDBState();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
                return;

            _index = e.RowIndex;


            DataGridViewRow row = dataGridView1.Rows[_index];

           for (int i = 0; i < _textbox_array.Count; i++)
           {
                _textbox_array[i].Text = row.Cells[i].Value.ToString();
         
           }

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;

            if (MessageBox.Show("Ви впевнені ?", "Видалення майна", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try 
                {
                    _index = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(_index); // can be constraint exception
                    MainDB.GetInstance().setHasChangesDBState();

                }
                catch (InvalidConstraintException)
                {
                    MessageBox.Show("Видалить с початку усі записи про майно клієнта", "Видалення майна", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                }
                
            }
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
