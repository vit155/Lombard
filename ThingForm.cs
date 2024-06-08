using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lombard
{
    public partial class ThingForm : Form
    {
        public ThingForm()
        {
            InitializeComponent();

            _mandatory_controls_array.Add(asset_name_textBox);
            _mandatory_controls_array.Add(status_comboBox);
            _mandatory_controls_array.Add(estimated_cost_textBox);
            _mandatory_controls_array.Add(acceptance_dateTimePicker);



            _update_controls_array.Add(asset_name_textBox);
            _update_controls_array.Add(status_comboBox);
            _update_controls_array.Add(estimated_cost_textBox);
            _update_controls_array.Add(acceptance_dateTimePicker);
            _update_controls_array.Add(issued_sum_textBox);
            _update_controls_array.Add(buyout_date_dateTimePicker);
            _update_controls_array.Add(buyout_sum_textBox);
            _update_controls_array.Add(force_sale_date_dateTimePicker);
            _update_controls_array.Add(force_sale_sum_textBox);
            _update_controls_array.Add(description_textBox);


        }


        private List<Control> _mandatory_controls_array = new List<Control>(); //required fields
        private List<Control> _update_controls_array = new List<Control>();  //fields for update

        private int _index = 0;
        private bool show_only_outdated = false;  // flag to show only outdated  things
        private bool show_for_tax_id_only = false;


        private void ThingForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MainDB.GetInstance().GetMainDataset().ThingDataTable;

            LombardDataSet.CustomerDataTableDataTable customers = MainDB.GetInstance().GetMainDataset().CustomerDataTable;

            client_comboBox.Items.Add("Всі");
            
            for (int i = 0; i < customers.Count; i++)
            {
                client_comboBox.Items.Add(customers.Rows[i].Field<string>(0)+ " <" + customers.Rows[i].Field<string>(1)+ " " + customers.Rows[i].Field<string>(2) + ">");

            }

            client_comboBox.SelectedIndex = 0;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void client_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (client_comboBox.Text.Contains('<'))
                show_for_tax_id_only = true;
            else
                show_for_tax_id_only = false;

            update_filters();

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            LombardDataSet ds = MainDB.GetInstance().GetMainDataset();

            foreach (Control ctr in _mandatory_controls_array)
            {
                ctr.Text.Trim();

                if (ctr.Text.Length == 0)
                {
                    MessageBox.Show("Усі  обов'язкові поля повинні бути заповнені (жирний шрифт)", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

            }

            ds.ThingDataTable.Rows.Add(null, get_cleanTaxID(client_comboBox.Text), asset_name_textBox.Text, status_comboBox.Text, estimated_cost_textBox.Text, acceptance_dateTimePicker.Text, issued_sum_textBox.Text, buyout_date_dateTimePicker.Text, buyout_sum_textBox.Text, force_sale_date_dateTimePicker.Text, force_sale_sum_textBox.Text, description_textBox.Text);
            MainDB.GetInstance().GetMainDataset().AcceptChanges();
            MainDB.GetInstance().setHasChangesDBState(); // db has been changed
        }

        private string get_cleanTaxID(string s)
        {
            return s.Remove(s.IndexOf("<")-1);
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;
            
            DataGridViewRow row = dataGridView1.Rows[_index];


            for (int i = 0; i < _update_controls_array.Count; i++)
            {
                row.Cells[i + 2].Value = _update_controls_array[i].Text;

            }

            MainDB.GetInstance().GetMainDataset().AcceptChanges();
            MainDB.GetInstance().setHasChangesDBState(); // db has been changed


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            _index = e.RowIndex;



            DataGridViewRow row = dataGridView1.Rows[_index];
            

            ID_textBox.Text = row.Cells[0].Value.ToString();

            client_comboBox.SelectedIndex = client_comboBox.FindString(row.Cells[1].Value.ToString());

            String searchValue = ID_textBox.Text;
           
            foreach (DataGridViewRow row1 in dataGridView1.Rows)
            {
                if (row1.Cells[0].Value.ToString().Equals(searchValue))
                {
                    _index = row1.Index;
                    break;
                }
            }

            row = dataGridView1.Rows[_index];

            
            for (int i = 0; i < _update_controls_array.Count; i++)
            {
                if (row.Cells[i+2].Value != null)
                    _update_controls_array[i].Text = row.Cells[i+2].Value.ToString();

            }
            
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;

            if (MessageBox.Show("Ви впевнені ?","Видалення майна",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes) 
            {
                _index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(_index);
                MainDB.GetInstance().GetMainDataset().AcceptChanges();
                MainDB.GetInstance().setHasChangesDBState(); // db has been changed
            }

        }

        private void only_outdated_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            show_only_outdated = only_outdated_checkBox.Checked;
            update_filters();

        }

        private void update_filters()
        {

            LombardDataSet.ThingDataTableDataTable things = MainDB.GetInstance().GetMainDataset().ThingDataTable;

            if (show_for_tax_id_only)
            {
                if (show_only_outdated)
                    things.DefaultView.RowFilter = string.Format("owner_tax_id = '{0}' and force_sale_date < '{1}'", get_cleanTaxID(client_comboBox.Text), DateTime.Today);
                else
                    things.DefaultView.RowFilter = string.Format("owner_tax_id = '{0}'", get_cleanTaxID(client_comboBox.Text));
            }
            else
            {
                if (show_only_outdated)
                    things.DefaultView.RowFilter = string.Format("force_sale_date < '{0}'", DateTime.Today);
                else
                    things.DefaultView.RowFilter = "";

            }
               

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buyout_sum_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void force_sale_date_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void force_sale_sum_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void description_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
