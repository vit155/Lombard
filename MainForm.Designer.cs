namespace Lombard
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DBStatusLabel = new System.Windows.Forms.Label();
            this.ClientButton = new System.Windows.Forms.Button();
            this.ThingButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.status_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.has_unsaved_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadButton.Location = new System.Drawing.Point(20, 124);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(138, 59);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "&Завантажити базу з файла";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(184, 44);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(146, 59);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "З&берегти базу в файл";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DBStatusLabel
            // 
            this.DBStatusLabel.AutoSize = true;
            this.DBStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DBStatusLabel.Location = new System.Drawing.Point(16, 10);
            this.DBStatusLabel.Name = "DBStatusLabel";
            this.DBStatusLabel.Size = new System.Drawing.Size(122, 20);
            this.DBStatusLabel.TabIndex = 2;
            this.DBStatusLabel.Text = "Статус бази: ";
            // 
            // ClientButton
            // 
            this.ClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientButton.Location = new System.Drawing.Point(8, 30);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(144, 58);
            this.ClientButton.TabIndex = 3;
            this.ClientButton.Text = "Модуль \"&Клієнти\"";
            this.ClientButton.UseVisualStyleBackColor = true;
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // ThingButton
            // 
            this.ThingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThingButton.Location = new System.Drawing.Point(193, 31);
            this.ThingButton.Name = "ThingButton";
            this.ThingButton.Size = new System.Drawing.Size(137, 57);
            this.ThingButton.TabIndex = 4;
            this.ThingButton.Text = "Модуль \"&Майно\"";
            this.ThingButton.UseVisualStyleBackColor = true;
            this.ThingButton.Click += new System.EventHandler(this.ThingButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(446, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 283);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(190, 9);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(191, 20);
            this.status_label.TabIndex = 6;
            this.status_label.Text = "Нова незбережена база";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операції з базой";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClientButton);
            this.groupBox2.Controls.Add(this.ThingButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 119);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Програмні модулі";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Незбережені зміни:";
            // 
            // has_unsaved_label
            // 
            this.has_unsaved_label.AutoSize = true;
            this.has_unsaved_label.Location = new System.Drawing.Point(190, 39);
            this.has_unsaved_label.Name = "has_unsaved_label";
            this.has_unsaved_label.Size = new System.Drawing.Size(205, 20);
            this.has_unsaved_label.TabIndex = 10;
            this.has_unsaved_label.Text = "Немає незбережених змін";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(801, 402);
            this.Controls.Add(this.has_unsaved_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DBStatusLabel);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.Text = "Ломбард";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label DBStatusLabel;
        private System.Windows.Forms.Button ClientButton;
        private System.Windows.Forms.Button ThingButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label has_unsaved_label;
    }
}

