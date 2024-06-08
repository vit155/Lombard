namespace Lombard
{
    partial class ClientForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.taxidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactdataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lombardDataSet = new Lombard.LombardDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tax_id_textBox = new System.Windows.Forms.TextBox();
            this.first_name_textBox = new System.Windows.Forms.TextBox();
            this.second_name_textBox = new System.Windows.Forms.TextBox();
            this.city_textBox = new System.Windows.Forms.TextBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.passport_textBox = new System.Windows.Forms.TextBox();
            this.contact_data_textBox = new System.Windows.Forms.TextBox();
            this.lombardDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.clean_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lombardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lombardDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taxidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.contactdataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerDataTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1134, 253);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // taxidDataGridViewTextBoxColumn
            // 
            this.taxidDataGridViewTextBoxColumn.DataPropertyName = "tax_id";
            this.taxidDataGridViewTextBoxColumn.HeaderText = "Інд код";
            this.taxidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.taxidDataGridViewTextBoxColumn.Name = "taxidDataGridViewTextBoxColumn";
            this.taxidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Місто";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.passportDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            this.passportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactdataDataGridViewTextBoxColumn
            // 
            this.contactdataDataGridViewTextBoxColumn.DataPropertyName = "contact_data";
            this.contactdataDataGridViewTextBoxColumn.HeaderText = "Контактні дані";
            this.contactdataDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contactdataDataGridViewTextBoxColumn.Name = "contactdataDataGridViewTextBoxColumn";
            this.contactdataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataTableBindingSource
            // 
            this.customerDataTableBindingSource.DataMember = "CustomerDataTable";
            this.customerDataTableBindingSource.DataSource = this.lombardDataSet;
            // 
            // lombardDataSet
            // 
            this.lombardDataSet.DataSetName = "LombardDataSet";
            this.lombardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Инд код";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Прізвище";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Місто";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Адреса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Паспорт";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(737, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Контактна інф.";
            // 
            // tax_id_textBox
            // 
            this.tax_id_textBox.Location = new System.Drawing.Point(120, 5);
            this.tax_id_textBox.Name = "tax_id_textBox";
            this.tax_id_textBox.Size = new System.Drawing.Size(173, 26);
            this.tax_id_textBox.TabIndex = 10;
            // 
            // first_name_textBox
            // 
            this.first_name_textBox.Location = new System.Drawing.Point(120, 43);
            this.first_name_textBox.Name = "first_name_textBox";
            this.first_name_textBox.Size = new System.Drawing.Size(173, 26);
            this.first_name_textBox.TabIndex = 11;
            // 
            // second_name_textBox
            // 
            this.second_name_textBox.Location = new System.Drawing.Point(120, 88);
            this.second_name_textBox.Name = "second_name_textBox";
            this.second_name_textBox.Size = new System.Drawing.Size(173, 26);
            this.second_name_textBox.TabIndex = 12;
            // 
            // city_textBox
            // 
            this.city_textBox.Location = new System.Drawing.Point(479, 6);
            this.city_textBox.Name = "city_textBox";
            this.city_textBox.Size = new System.Drawing.Size(214, 26);
            this.city_textBox.TabIndex = 13;
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(479, 43);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(214, 26);
            this.address_textBox.TabIndex = 14;
            // 
            // passport_textBox
            // 
            this.passport_textBox.Location = new System.Drawing.Point(479, 82);
            this.passport_textBox.Name = "passport_textBox";
            this.passport_textBox.Size = new System.Drawing.Size(214, 26);
            this.passport_textBox.TabIndex = 15;
            // 
            // contact_data_textBox
            // 
            this.contact_data_textBox.Location = new System.Drawing.Point(868, 6);
            this.contact_data_textBox.Name = "contact_data_textBox";
            this.contact_data_textBox.Size = new System.Drawing.Size(268, 26);
            this.contact_data_textBox.TabIndex = 16;
            // 
            // lombardDataSetBindingSource
            // 
            this.lombardDataSetBindingSource.DataSource = this.lombardDataSet;
            this.lombardDataSetBindingSource.Position = 0;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.Green;
            this.add_button.Location = new System.Drawing.Point(100, 436);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(193, 49);
            this.add_button.TabIndex = 17;
            this.add_button.Text = "Додати клієнта";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.Yellow;
            this.update_button.Location = new System.Drawing.Point(462, 436);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(221, 49);
            this.update_button.TabIndex = 18;
            this.update_button.Text = "Оновити дані клієнта";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Crimson;
            this.delete_button.Location = new System.Drawing.Point(849, 436);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(208, 49);
            this.delete_button.TabIndex = 19;
            this.delete_button.Text = "Видалити клієнта";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // clean_button
            // 
            this.clean_button.Location = new System.Drawing.Point(868, 73);
            this.clean_button.Name = "clean_button";
            this.clean_button.Size = new System.Drawing.Size(268, 31);
            this.clean_button.TabIndex = 20;
            this.clean_button.Text = "Очистити";
            this.clean_button.UseVisualStyleBackColor = true;
            this.clean_button.Click += new System.EventHandler(this.clean_button_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 566);
            this.Controls.Add(this.clean_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.contact_data_textBox);
            this.Controls.Add(this.passport_textBox);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.city_textBox);
            this.Controls.Add(this.second_name_textBox);
            this.Controls.Add(this.first_name_textBox);
            this.Controls.Add(this.tax_id_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientForm";
            this.Text = "Клієнти";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lombardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lombardDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource customerDataTableBindingSource;
        private LombardDataSet lombardDataSet;
        private System.Windows.Forms.BindingSource lombardDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tax_id_textBox;
        private System.Windows.Forms.TextBox first_name_textBox;
        private System.Windows.Forms.TextBox second_name_textBox;
        private System.Windows.Forms.TextBox city_textBox;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox passport_textBox;
        private System.Windows.Forms.TextBox contact_data_textBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button clean_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactdataDataGridViewTextBoxColumn;
    }
}