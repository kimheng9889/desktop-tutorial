namespace WinFormsApp1
{
    partial class Import_Form
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
            dateTimePicker1 = new DateTimePicker();
            comboBoxOrderNum = new ComboBox();
            comboBoxStId = new ComboBox();
            lbStName = new Label();
            lbPayCode = new Label();
            TxtBoxTotal = new MaskedTextBox();
            TxtBoxStName = new MaskedTextBox();
            TxtBoxTrxId = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            lbSup = new Label();
            btnClose = new Button();
            btnPay = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            maskedTextBox5 = new MaskedTextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(259, 102);
            dateTimePicker1.MaxDate = new DateTime(2026, 2, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(172, 27);
            dateTimePicker1.TabIndex = 75;
            dateTimePicker1.Value = new DateTime(2026, 2, 1, 0, 0, 0, 0);
            // 
            // comboBoxOrderNum
            // 
            comboBoxOrderNum.DisplayMember = "1,2,3";
            comboBoxOrderNum.FormattingEnabled = true;
            comboBoxOrderNum.Items.AddRange(new object[] { "001", "002", "003", "004", "005", "006", "007" });
            comboBoxOrderNum.Location = new Point(21, 276);
            comboBoxOrderNum.Name = "comboBoxOrderNum";
            comboBoxOrderNum.Size = new Size(173, 28);
            comboBoxOrderNum.TabIndex = 93;
            comboBoxOrderNum.ValueMember = "1,2,3";
            // 
            // comboBoxStId
            // 
            comboBoxStId.DisplayMember = "1,2,3";
            comboBoxStId.FormattingEnabled = true;
            comboBoxStId.Items.AddRange(new object[] { "001", "002", "003", "004", "005", "006", "007" });
            comboBoxStId.Location = new Point(21, 187);
            comboBoxStId.Name = "comboBoxStId";
            comboBoxStId.Size = new Size(172, 28);
            comboBoxStId.TabIndex = 94;
            comboBoxStId.ValueMember = "1,2,3";
            // 
            // lbStName
            // 
            lbStName.AutoSize = true;
            lbStName.BackColor = Color.Transparent;
            lbStName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbStName.ForeColor = Color.White;
            lbStName.Location = new Point(260, 162);
            lbStName.Name = "lbStName";
            lbStName.Size = new Size(99, 20);
            lbStName.TabIndex = 76;
            lbStName.Text = "Staff's Name";
            // 
            // lbPayCode
            // 
            lbPayCode.AutoSize = true;
            lbPayCode.BackColor = Color.Transparent;
            lbPayCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbPayCode.ForeColor = Color.White;
            lbPayCode.Location = new Point(21, 75);
            lbPayCode.Name = "lbPayCode";
            lbPayCode.Size = new Size(120, 20);
            lbPayCode.TabIndex = 77;
            lbPayCode.Text = "Import Number";
            // 
            // TxtBoxTotal
            // 
            TxtBoxTotal.BackColor = Color.Gray;
            TxtBoxTotal.BorderStyle = BorderStyle.FixedSingle;
            TxtBoxTotal.Location = new Point(398, 598);
            TxtBoxTotal.Name = "TxtBoxTotal";
            TxtBoxTotal.ReadOnly = true;
            TxtBoxTotal.Size = new Size(120, 27);
            TxtBoxTotal.TabIndex = 80;
            TxtBoxTotal.TabStop = false;
            // 
            // TxtBoxStName
            // 
            TxtBoxStName.BackColor = Color.Beige;
            TxtBoxStName.BorderStyle = BorderStyle.FixedSingle;
            TxtBoxStName.Location = new Point(259, 188);
            TxtBoxStName.Name = "TxtBoxStName";
            TxtBoxStName.ReadOnly = true;
            TxtBoxStName.Size = new Size(220, 27);
            TxtBoxStName.TabIndex = 81;
            TxtBoxStName.TabStop = false;
            // 
            // TxtBoxTrxId
            // 
            TxtBoxTrxId.BackColor = Color.Beige;
            TxtBoxTrxId.Location = new Point(21, 102);
            TxtBoxTrxId.Name = "TxtBoxTrxId";
            TxtBoxTrxId.ReadOnly = true;
            TxtBoxTrxId.Size = new Size(172, 27);
            TxtBoxTrxId.TabIndex = 78;
            TxtBoxTrxId.TabStop = false;
            TxtBoxTrxId.Text = "  Autonumber";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 350);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 85;
            label4.Text = "Product's Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(337, 600);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 87;
            label5.Text = "Total ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(259, 79);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 83;
            label2.Text = "Import Date";
            // 
            // lbSup
            // 
            lbSup.AutoSize = true;
            lbSup.BackColor = Color.Transparent;
            lbSup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbSup.ForeColor = Color.White;
            lbSup.Location = new Point(22, 160);
            lbSup.Name = "lbSup";
            lbSup.Size = new Size(73, 20);
            lbSup.TabIndex = 82;
            lbSup.Text = "Staff's ID";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.WindowText;
            btnClose.Location = new Point(561, 19);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(119, 41);
            btnClose.TabIndex = 89;
            btnClose.Text = "Close";
            // 
            // btnPay
            // 
            btnPay.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.ForeColor = SystemColors.WindowText;
            btnPay.ImageAlign = ContentAlignment.MiddleLeft;
            btnPay.Location = new Point(550, 588);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(119, 42);
            btnPay.TabIndex = 90;
            btnPay.Text = "Save";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.YellowGreen;
            label1.Location = new Point(21, 16);
            label1.Name = "label1";
            label1.Size = new Size(109, 38);
            label1.TabIndex = 91;
            label1.Text = "Import";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.WindowText;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(550, 373);
            button1.Name = "button1";
            button1.Size = new Size(119, 42);
            button1.TabIndex = 90;
            button1.Text = "Add";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.WindowText;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(550, 421);
            button2.Name = "button2";
            button2.Size = new Size(119, 42);
            button2.TabIndex = 90;
            button2.Text = "Remove";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 406);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(494, 181);
            dataGridView1.TabIndex = 96;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.Gray;
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Location = new Point(27, 373);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.ReadOnly = true;
            maskedTextBox1.Size = new Size(120, 27);
            maskedTextBox1.TabIndex = 80;
            maskedTextBox1.TabStop = false;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BackColor = Color.Gray;
            maskedTextBox2.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox2.Location = new Point(152, 373);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.ReadOnly = true;
            maskedTextBox2.Size = new Size(120, 27);
            maskedTextBox2.TabIndex = 80;
            maskedTextBox2.TabStop = false;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.BackColor = Color.Gray;
            maskedTextBox3.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox3.Location = new Point(276, 373);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.ReadOnly = true;
            maskedTextBox3.Size = new Size(120, 27);
            maskedTextBox3.TabIndex = 80;
            maskedTextBox3.TabStop = false;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.BackColor = Color.Gray;
            maskedTextBox4.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox4.Location = new Point(399, 373);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.ReadOnly = true;
            maskedTextBox4.Size = new Size(120, 27);
            maskedTextBox4.TabIndex = 80;
            maskedTextBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(151, 350);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 85;
            label7.Text = "Product's Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(276, 350);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 85;
            label8.Text = "Quantity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(402, 350);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 85;
            label9.Text = "Unit Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 250);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 83;
            label6.Text = "Supplier's ID";
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.BackColor = Color.Beige;
            maskedTextBox5.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox5.Location = new Point(259, 276);
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.ReadOnly = true;
            maskedTextBox5.Size = new Size(220, 27);
            maskedTextBox5.TabIndex = 81;
            maskedTextBox5.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(260, 250);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 76;
            label3.Text = "Supplier's Name";
            // 
            // Import_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
         
            ClientSize = new Size(690, 652);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBoxOrderNum);
            Controls.Add(comboBoxStId);
            Controls.Add(label3);
            Controls.Add(lbStName);
            Controls.Add(lbPayCode);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(TxtBoxTotal);
            Controls.Add(maskedTextBox5);
            Controls.Add(TxtBoxStName);
            Controls.Add(TxtBoxTrxId);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(lbSup);
            Controls.Add(btnClose);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnPay);
            Controls.Add(label1);
            Name = "Import_Form";
            Text = "Import Detail";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxOrderNum;
        private ComboBox comboBoxStId;
        private Label lbStName;
        private Label lbPayCode;
        private MaskedTextBox TxtBoxTotal;
        private MaskedTextBox TxtBoxStName;
        private MaskedTextBox TxtBoxTrxId;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label lbSup;
        private Button btnClose;
        private Button btnPay;
        private Label label1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label6;
        private MaskedTextBox maskedTextBox5;
        private Label label3;
    }
}