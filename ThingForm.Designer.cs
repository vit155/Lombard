namespace Lombard
{
    partial class ThingForm
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
            this.thingidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownertaxidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptancedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedsumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyoutdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyoutsumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forcesaledateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forcesalesumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thingDataTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lombardDataSet = new Lombard.LombardDataSet();
            this.client_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.asset_name_textBox = new System.Windows.Forms.TextBox();
            this.status_comboBox = new System.Windows.Forms.ComboBox();
            this.estimated_cost_textBox = new System.Windows.Forms.TextBox();
            this.acceptance_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.issued_sum_textBox = new System.Windows.Forms.TextBox();
            this.buyout_date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buyout_sum_textBox = new System.Windows.Forms.TextBox();
            this.force_sale_date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.force_sale_sum_textBox = new System.Windows.Forms.TextBox();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.only_outdated_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thingDataTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lombardDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thingidDataGridViewTextBoxColumn,
            this.ownertaxidDataGridViewTextBoxColumn,
            this.assetnameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.estimatedcostDataGridViewTextBoxColumn,
            this.acceptancedateDataGridViewTextBoxColumn,
            this.issuedsumDataGridViewTextBoxColumn,
            this.buyoutdateDataGridViewTextBoxColumn,
            this.buyoutsumDataGridViewTextBoxColumn,
            this.forcesaledateDataGridViewTextBoxColumn,
            this.forcesalesumDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thingDataTableBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // thingidDataGridViewTextBoxColumn
            // 
            this.thingidDataGridViewTextBoxColumn.DataPropertyName = "thing_id";
            this.thingidDataGridViewTextBoxColumn.HeaderText = "ID майна";
            this.thingidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.thingidDataGridViewTextBoxColumn.Name = "thingidDataGridViewTextBoxColumn";
            this.thingidDataGridViewTextBoxColumn.ReadOnly = true;
            this.thingidDataGridViewTextBoxColumn.Width = 150;
            // 
            // ownertaxidDataGridViewTextBoxColumn
            // 
            this.ownertaxidDataGridViewTextBoxColumn.DataPropertyName = "owner_tax_id";
            this.ownertaxidDataGridViewTextBoxColumn.HeaderText = "ІНД властника";
            this.ownertaxidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ownertaxidDataGridViewTextBoxColumn.Name = "ownertaxidDataGridViewTextBoxColumn";
            this.ownertaxidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownertaxidDataGridViewTextBoxColumn.Width = 150;
            // 
            // assetnameDataGridViewTextBoxColumn
            // 
            this.assetnameDataGridViewTextBoxColumn.DataPropertyName = "asset_name";
            this.assetnameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.assetnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.assetnameDataGridViewTextBoxColumn.Name = "assetnameDataGridViewTextBoxColumn";
            this.assetnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.assetnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // estimatedcostDataGridViewTextBoxColumn
            // 
            this.estimatedcostDataGridViewTextBoxColumn.DataPropertyName = "estimated_cost";
            this.estimatedcostDataGridViewTextBoxColumn.HeaderText = "Оцінка";
            this.estimatedcostDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estimatedcostDataGridViewTextBoxColumn.Name = "estimatedcostDataGridViewTextBoxColumn";
            this.estimatedcostDataGridViewTextBoxColumn.ReadOnly = true;
            this.estimatedcostDataGridViewTextBoxColumn.Width = 150;
            // 
            // acceptancedateDataGridViewTextBoxColumn
            // 
            this.acceptancedateDataGridViewTextBoxColumn.DataPropertyName = "acceptance_date";
            this.acceptancedateDataGridViewTextBoxColumn.HeaderText = "Дата прийомки";
            this.acceptancedateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.acceptancedateDataGridViewTextBoxColumn.Name = "acceptancedateDataGridViewTextBoxColumn";
            this.acceptancedateDataGridViewTextBoxColumn.ReadOnly = true;
            this.acceptancedateDataGridViewTextBoxColumn.Width = 150;
            // 
            // issuedsumDataGridViewTextBoxColumn
            // 
            this.issuedsumDataGridViewTextBoxColumn.DataPropertyName = "issued_sum";
            this.issuedsumDataGridViewTextBoxColumn.HeaderText = "Надана сума";
            this.issuedsumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.issuedsumDataGridViewTextBoxColumn.Name = "issuedsumDataGridViewTextBoxColumn";
            this.issuedsumDataGridViewTextBoxColumn.ReadOnly = true;
            this.issuedsumDataGridViewTextBoxColumn.Width = 150;
            // 
            // buyoutdateDataGridViewTextBoxColumn
            // 
            this.buyoutdateDataGridViewTextBoxColumn.DataPropertyName = "buyout_date";
            this.buyoutdateDataGridViewTextBoxColumn.HeaderText = "Дата викупу";
            this.buyoutdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.buyoutdateDataGridViewTextBoxColumn.Name = "buyoutdateDataGridViewTextBoxColumn";
            this.buyoutdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.buyoutdateDataGridViewTextBoxColumn.Width = 150;
            // 
            // buyoutsumDataGridViewTextBoxColumn
            // 
            this.buyoutsumDataGridViewTextBoxColumn.DataPropertyName = "buyout_sum";
            this.buyoutsumDataGridViewTextBoxColumn.HeaderText = "Сума викупу";
            this.buyoutsumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.buyoutsumDataGridViewTextBoxColumn.Name = "buyoutsumDataGridViewTextBoxColumn";
            this.buyoutsumDataGridViewTextBoxColumn.ReadOnly = true;
            this.buyoutsumDataGridViewTextBoxColumn.Width = 150;
            // 
            // forcesaledateDataGridViewTextBoxColumn
            // 
            this.forcesaledateDataGridViewTextBoxColumn.DataPropertyName = "force_sale_date";
            this.forcesaledateDataGridViewTextBoxColumn.HeaderText = "Кінцева дата зберігання";
            this.forcesaledateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.forcesaledateDataGridViewTextBoxColumn.Name = "forcesaledateDataGridViewTextBoxColumn";
            this.forcesaledateDataGridViewTextBoxColumn.ReadOnly = true;
            this.forcesaledateDataGridViewTextBoxColumn.Width = 150;
            // 
            // forcesalesumDataGridViewTextBoxColumn
            // 
            this.forcesalesumDataGridViewTextBoxColumn.DataPropertyName = "force_sale_sum";
            this.forcesalesumDataGridViewTextBoxColumn.HeaderText = "Сума продажи після зберігання";
            this.forcesalesumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.forcesalesumDataGridViewTextBoxColumn.Name = "forcesalesumDataGridViewTextBoxColumn";
            this.forcesalesumDataGridViewTextBoxColumn.ReadOnly = true;
            this.forcesalesumDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Опис майна";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // thingDataTableBindingSource2
            // 
            this.thingDataTableBindingSource2.DataMember = "ThingDataTable";
            this.thingDataTableBindingSource2.DataSource = this.lombardDataSet;
            // 
            // lombardDataSet
            // 
            this.lombardDataSet.DataSetName = "LombardDataSet";
            this.lombardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // client_comboBox
            // 
            this.client_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.client_comboBox.FormattingEnabled = true;
            this.client_comboBox.Location = new System.Drawing.Point(222, 7);
            this.client_comboBox.Name = "client_comboBox";
            this.client_comboBox.Size = new System.Drawing.Size(343, 28);
            this.client_comboBox.TabIndex = 1;
            this.client_comboBox.SelectedIndexChanged += new System.EventHandler(this.client_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кліент (ІПН <Ім\'я>)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID майна";
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(94, 10);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.ReadOnly = true;
            this.ID_textBox.Size = new System.Drawing.Size(218, 26);
            this.ID_textBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Назва";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Статус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(333, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Оціночна вартість";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(333, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Дата прийому";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Видана сумма";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Дата викупа";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(699, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Сумма викупа";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(699, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Кінцева дата зберігання";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(699, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Сумма примусового продажу";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(699, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Опис майна";
            // 
            // asset_name_textBox
            // 
            this.asset_name_textBox.Location = new System.Drawing.Point(94, 63);
            this.asset_name_textBox.Name = "asset_name_textBox";
            this.asset_name_textBox.Size = new System.Drawing.Size(218, 26);
            this.asset_name_textBox.TabIndex = 15;
            // 
            // status_comboBox
            // 
            this.status_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_comboBox.FormattingEnabled = true;
            this.status_comboBox.Items.AddRange(new object[] {
            "Прийняте у залог",
            "Викуплено властником",
            "Викуплено невластником"});
            this.status_comboBox.Location = new System.Drawing.Point(94, 111);
            this.status_comboBox.Name = "status_comboBox";
            this.status_comboBox.Size = new System.Drawing.Size(218, 28);
            this.status_comboBox.TabIndex = 16;
            // 
            // estimated_cost_textBox
            // 
            this.estimated_cost_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.estimated_cost_textBox.Location = new System.Drawing.Point(491, 12);
            this.estimated_cost_textBox.Name = "estimated_cost_textBox";
            this.estimated_cost_textBox.Size = new System.Drawing.Size(177, 26);
            this.estimated_cost_textBox.TabIndex = 17;
            // 
            // acceptance_dateTimePicker
            // 
            this.acceptance_dateTimePicker.Location = new System.Drawing.Point(491, 54);
            this.acceptance_dateTimePicker.Name = "acceptance_dateTimePicker";
            this.acceptance_dateTimePicker.Size = new System.Drawing.Size(177, 26);
            this.acceptance_dateTimePicker.TabIndex = 18;
            // 
            // issued_sum_textBox
            // 
            this.issued_sum_textBox.Location = new System.Drawing.Point(491, 102);
            this.issued_sum_textBox.Name = "issued_sum_textBox";
            this.issued_sum_textBox.Size = new System.Drawing.Size(177, 26);
            this.issued_sum_textBox.TabIndex = 19;
            // 
            // buyout_date_dateTimePicker
            // 
            this.buyout_date_dateTimePicker.Location = new System.Drawing.Point(491, 146);
            this.buyout_date_dateTimePicker.Name = "buyout_date_dateTimePicker";
            this.buyout_date_dateTimePicker.Size = new System.Drawing.Size(177, 26);
            this.buyout_date_dateTimePicker.TabIndex = 20;
            // 
            // buyout_sum_textBox
            // 
            this.buyout_sum_textBox.Location = new System.Drawing.Point(939, 62);
            this.buyout_sum_textBox.Name = "buyout_sum_textBox";
            this.buyout_sum_textBox.Size = new System.Drawing.Size(200, 26);
            this.buyout_sum_textBox.TabIndex = 21;
            this.buyout_sum_textBox.TextChanged += new System.EventHandler(this.buyout_sum_textBox_TextChanged);
            // 
            // force_sale_date_dateTimePicker
            // 
            this.force_sale_date_dateTimePicker.Location = new System.Drawing.Point(939, 101);
            this.force_sale_date_dateTimePicker.Name = "force_sale_date_dateTimePicker";
            this.force_sale_date_dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.force_sale_date_dateTimePicker.TabIndex = 22;
            this.force_sale_date_dateTimePicker.ValueChanged += new System.EventHandler(this.force_sale_date_dateTimePicker_ValueChanged);
            // 
            // force_sale_sum_textBox
            // 
            this.force_sale_sum_textBox.Location = new System.Drawing.Point(939, 153);
            this.force_sale_sum_textBox.Name = "force_sale_sum_textBox";
            this.force_sale_sum_textBox.Size = new System.Drawing.Size(200, 26);
            this.force_sale_sum_textBox.TabIndex = 23;
            this.force_sale_sum_textBox.TextChanged += new System.EventHandler(this.force_sale_sum_textBox_TextChanged);
            // 
            // description_textBox
            // 
            this.description_textBox.Location = new System.Drawing.Point(939, 193);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(200, 90);
            this.description_textBox.TabIndex = 24;
            this.description_textBox.TextChanged += new System.EventHandler(this.description_textBox_TextChanged);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.OliveDrab;
            this.add_button.Location = new System.Drawing.Point(151, 531);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(145, 46);
            this.add_button.TabIndex = 25;
            this.add_button.Text = "Додати майно";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.Yellow;
            this.update_button.Location = new System.Drawing.Point(455, 531);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(149, 46);
            this.update_button.TabIndex = 26;
            this.update_button.Text = "Оновити дані";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Red;
            this.delete_button.Location = new System.Drawing.Point(738, 531);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(178, 46);
            this.delete_button.TabIndex = 27;
            this.delete_button.Text = "Видалити майно";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // only_outdated_checkBox
            // 
            this.only_outdated_checkBox.AutoSize = true;
            this.only_outdated_checkBox.Location = new System.Drawing.Point(703, 7);
            this.only_outdated_checkBox.Name = "only_outdated_checkBox";
            this.only_outdated_checkBox.Size = new System.Drawing.Size(320, 24);
            this.only_outdated_checkBox.TabIndex = 28;
            this.only_outdated_checkBox.Text = "Тількі з просроченим терміном викупу";
            this.only_outdated_checkBox.UseVisualStyleBackColor = true;
            this.only_outdated_checkBox.CheckedChanged += new System.EventHandler(this.only_outdated_checkBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.estimated_cost_textBox);
            this.groupBox1.Controls.Add(this.acceptance_dateTimePicker);
            this.groupBox1.Controls.Add(this.issued_sum_textBox);
            this.groupBox1.Controls.Add(this.buyout_date_dateTimePicker);
            this.groupBox1.Controls.Add(this.status_comboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ID_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.asset_name_textBox);
            this.groupBox1.Location = new System.Drawing.Point(18, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1164, 243);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // customerDataTableBindingSource
            // 
            this.customerDataTableBindingSource.DataMember = "CustomerDataTable";
            this.customerDataTableBindingSource.DataSource = this.lombardDataSet;
            // 
            // ThingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 589);
            this.Controls.Add(this.only_outdated_checkBox);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.description_textBox);
            this.Controls.Add(this.force_sale_sum_textBox);
            this.Controls.Add(this.force_sale_date_dateTimePicker);
            this.Controls.Add(this.buyout_sum_textBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.client_comboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThingForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Модуль праці з майном";
            this.Load += new System.EventHandler(this.ThingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thingDataTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lombardDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private LombardDataSet lombardDataSet;
        private System.Windows.Forms.ComboBox client_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource thingDataTableBindingSource2;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox asset_name_textBox;
        private System.Windows.Forms.ComboBox status_comboBox;
        private System.Windows.Forms.TextBox estimated_cost_textBox;
        private System.Windows.Forms.DateTimePicker acceptance_dateTimePicker;
        private System.Windows.Forms.TextBox issued_sum_textBox;
        private System.Windows.Forms.DateTimePicker buyout_date_dateTimePicker;
        private System.Windows.Forms.TextBox buyout_sum_textBox;
        private System.Windows.Forms.DateTimePicker force_sale_date_dateTimePicker;
        private System.Windows.Forms.TextBox force_sale_sum_textBox;
        private System.Windows.Forms.TextBox description_textBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.CheckBox only_outdated_checkBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource customerDataTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn thingidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownertaxidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceptancedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedsumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyoutdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyoutsumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forcesaledateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forcesalesumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}