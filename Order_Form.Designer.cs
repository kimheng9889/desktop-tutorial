namespace WinFormsApp1
{
    partial class Order_Form
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
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            comboBoxOrderNum = new ComboBox();
            comboBoxStId = new ComboBox();
            label3 = new Label();
            lbStName = new Label();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            TxtBoxTotal = new MaskedTextBox();
            maskedTextBox5 = new MaskedTextBox();
            TxtBoxStName = new MaskedTextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            lbSup = new Label();
            btnClose = new Button();
            button2 = new Button();
            button1 = new Button();
            btnPay = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 408);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(494, 181);
            dataGridView1.TabIndex = 124;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(30, 103);
            dateTimePicker1.MaxDate = new DateTime(2026, 2, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(172, 27);
            dateTimePicker1.TabIndex = 97;
            dateTimePicker1.Value = new DateTime(2026, 2, 1, 0, 0, 0, 0);
            // 
            // comboBoxOrderNum
            // 
            comboBoxOrderNum.DisplayMember = "1,2,3";
            comboBoxOrderNum.FormattingEnabled = true;
            comboBoxOrderNum.Items.AddRange(new object[] { "001", "002", "003", "004", "005", "006", "007" });
            comboBoxOrderNum.Location = new Point(30, 278);
            comboBoxOrderNum.Name = "comboBoxOrderNum";
            comboBoxOrderNum.Size = new Size(173, 28);
            comboBoxOrderNum.TabIndex = 122;
            comboBoxOrderNum.ValueMember = "1,2,3";
            // 
            // comboBoxStId
            // 
            comboBoxStId.DisplayMember = "1,2,3";
            comboBoxStId.FormattingEnabled = true;
            comboBoxStId.Items.AddRange(new object[] { "001", "002", "003", "004", "005", "006", "007" });
            comboBoxStId.Location = new Point(30, 189);
            comboBoxStId.Name = "comboBoxStId";
            comboBoxStId.Size = new Size(172, 28);
            comboBoxStId.TabIndex = 123;
            comboBoxStId.ValueMember = "1,2,3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(269, 252);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 98;
            label3.Text = "Customer's Name";
            // 
            // lbStName
            // 
            lbStName.AutoSize = true;
            lbStName.BackColor = Color.Transparent;
            lbStName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbStName.ForeColor = Color.White;
            lbStName.Location = new Point(269, 164);
            lbStName.Name = "lbStName";
            lbStName.Size = new Size(99, 20);
            lbStName.TabIndex = 99;
            lbStName.Text = "Staff's Name";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.BackColor = Color.Gray;
            maskedTextBox4.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox4.Location = new Point(408, 375);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.ReadOnly = true;
            maskedTextBox4.Size = new Size(120, 27);
            maskedTextBox4.TabIndex = 103;
            maskedTextBox4.TabStop = false;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.BackColor = Color.Gray;
            maskedTextBox3.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox3.Location = new Point(285, 375);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.ReadOnly = true;
            maskedTextBox3.Size = new Size(120, 27);
            maskedTextBox3.TabIndex = 104;
            maskedTextBox3.TabStop = false;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BackColor = Color.Gray;
            maskedTextBox2.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox2.Location = new Point(161, 375);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.ReadOnly = true;
            maskedTextBox2.Size = new Size(120, 27);
            maskedTextBox2.TabIndex = 105;
            maskedTextBox2.TabStop = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.Gray;
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Location = new Point(36, 375);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.ReadOnly = true;
            maskedTextBox1.Size = new Size(120, 27);
            maskedTextBox1.TabIndex = 106;
            maskedTextBox1.TabStop = false;
            // 
            // TxtBoxTotal
            // 
            TxtBoxTotal.BackColor = Color.Gray;
            TxtBoxTotal.BorderStyle = BorderStyle.FixedSingle;
            TxtBoxTotal.Location = new Point(407, 600);
            TxtBoxTotal.Name = "TxtBoxTotal";
            TxtBoxTotal.ReadOnly = true;
            TxtBoxTotal.Size = new Size(120, 27);
            TxtBoxTotal.TabIndex = 102;
            TxtBoxTotal.TabStop = false;
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.BackColor = Color.Beige;
            maskedTextBox5.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox5.Location = new Point(268, 278);
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.ReadOnly = true;
            maskedTextBox5.Size = new Size(220, 27);
            maskedTextBox5.TabIndex = 107;
            maskedTextBox5.TabStop = false;
            // 
            // TxtBoxStName
            // 
            TxtBoxStName.BackColor = Color.Beige;
            TxtBoxStName.BorderStyle = BorderStyle.FixedSingle;
            TxtBoxStName.Location = new Point(268, 190);
            TxtBoxStName.Name = "TxtBoxStName";
            TxtBoxStName.ReadOnly = true;
            TxtBoxStName.Size = new Size(220, 27);
            TxtBoxStName.TabIndex = 108;
            TxtBoxStName.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(411, 352);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 112;
            label9.Text = "Unit Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(285, 352);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 113;
            label8.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(160, 352);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 114;
            label7.Text = "Product's Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(36, 352);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 115;
            label4.Text = "Product's Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(346, 602);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 116;
            label5.Text = "Total ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 252);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 110;
            label6.Text = "Customer's ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 80);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 111;
            label2.Text = "Import Date";
            // 
            // lbSup
            // 
            lbSup.AutoSize = true;
            lbSup.BackColor = Color.Transparent;
            lbSup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbSup.ForeColor = Color.White;
            lbSup.Location = new Point(31, 162);
            lbSup.Name = "lbSup";
            lbSup.Size = new Size(73, 20);
            lbSup.TabIndex = 109;
            lbSup.Text = "Staff's ID";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.WindowText;
            btnClose.Location = new Point(570, 21);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(119, 41);
            btnClose.TabIndex = 117;
            btnClose.Text = "Close";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.WindowText;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(559, 423);
            button2.Name = "button2";
            button2.Size = new Size(119, 42);
            button2.TabIndex = 118;
            button2.Text = "Remove";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.WindowText;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(559, 375);
            button1.Name = "button1";
            button1.Size = new Size(119, 42);
            button1.TabIndex = 120;
            button1.Text = "Add";
            // 
            // btnPay
            // 
            btnPay.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.ForeColor = SystemColors.WindowText;
            btnPay.ImageAlign = ContentAlignment.MiddleLeft;
            btnPay.Location = new Point(559, 590);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(119, 42);
            btnPay.TabIndex = 119;
            btnPay.Text = "Save";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.YellowGreen;
            label1.Location = new Point(33, 20);
            label1.Name = "label1";
            label1.Size = new Size(203, 38);
            label1.TabIndex = 121;
            label1.Text = "Order Product";
            // 
            // Order_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
           
            ClientSize = new Size(711, 660);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBoxOrderNum);
            Controls.Add(comboBoxStId);
            Controls.Add(label3);
            Controls.Add(lbStName);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(TxtBoxTotal);
            Controls.Add(maskedTextBox5);
            Controls.Add(TxtBoxStName);
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
            ForeColor = SystemColors.ControlText;
            Name = "Order_Form";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxOrderNum;
        private ComboBox comboBoxStId;
        private Label label3;
        private Label lbStName;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox TxtBoxTotal;
        private MaskedTextBox maskedTextBox5;
        private MaskedTextBox TxtBoxStName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label lbSup;
        private Button btnClose;
        private Button button2;
        private Button button1;
        private Button btnPay;
        private Label label1;
    }
}