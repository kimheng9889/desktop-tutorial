namespace WinFormsApp1
{
    partial class Payment_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_Form));
            lbPayCode = new Label();
            TxtBoxTrxId = new MaskedTextBox();
            btnClose = new Button();
            btnPay = new Button();
            label1 = new Label();
            lbSup = new Label();
            label2 = new Label();
            comboBoxStId = new ComboBox();
            TxtBoxStName = new MaskedTextBox();
            lbStName = new Label();
            dateTimePicker1 = new DateTimePicker();
            lbOrCode = new Label();
            comboBoxOrderNum = new ComboBox();
            label3 = new Label();
            comboBoxCurrency = new ComboBox();
            label4 = new Label();
            TxtBoxTotal = new MaskedTextBox();
            TxtBoxRemain = new MaskedTextBox();
            numericUpDownDeposit = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDeposit).BeginInit();
            SuspendLayout();
            // 
            // lbPayCode
            // 
            lbPayCode.AutoSize = true;
            lbPayCode.BackColor = Color.Transparent;
            lbPayCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbPayCode.ForeColor = Color.White;
            lbPayCode.Location = new Point(31, 79);
            lbPayCode.Name = "lbPayCode";
            lbPayCode.Size = new Size(55, 20);
            lbPayCode.TabIndex = 57;
            lbPayCode.Text = "Trx. ID";
            // 
            // TxtBoxTrxId
            // 
            TxtBoxTrxId.BackColor = Color.Beige;
            TxtBoxTrxId.Location = new Point(31, 106);
            TxtBoxTrxId.Name = "TxtBoxTrxId";
            TxtBoxTrxId.ReadOnly = true;
            TxtBoxTrxId.Size = new Size(172, 27);
            TxtBoxTrxId.TabIndex = 58;
            TxtBoxTrxId.TabStop = false;
            TxtBoxTrxId.Text = "  Autonumber";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(394, 23);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(95, 41);
            btnClose.TabIndex = 67;
            btnClose.Text = "Close";
            // 
            // btnPay
            // 
            btnPay.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.ImageAlign = ContentAlignment.MiddleLeft;
            btnPay.Location = new Point(361, 522);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(119, 42);
            btnPay.TabIndex = 69;
            btnPay.Text = "Pay Now";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.YellowGreen;
            label1.Location = new Point(31, 20);
            label1.Name = "label1";
            label1.Size = new Size(132, 38);
            label1.TabIndex = 71;
            label1.Text = "Payment";
            // 
            // lbSup
            // 
            lbSup.AutoSize = true;
            lbSup.BackColor = Color.Transparent;
            lbSup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbSup.ForeColor = Color.White;
            lbSup.Location = new Point(271, 79);
            lbSup.Name = "lbSup";
            lbSup.Size = new Size(73, 20);
            lbSup.TabIndex = 63;
            lbSup.Text = "Staff's ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 169);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 63;
            label2.Text = "Pay Date";
            // 
            // comboBoxStId
            // 
            comboBoxStId.DisplayMember = "1,2,3";
            comboBoxStId.FormattingEnabled = true;
            comboBoxStId.Items.AddRange(new object[] { "001", "002", "003", "004", "005", "006", "007" });
            comboBoxStId.Location = new Point(270, 106);
            comboBoxStId.Name = "comboBoxStId";
            comboBoxStId.Size = new Size(219, 28);
            comboBoxStId.TabIndex = 72;
            comboBoxStId.ValueMember = "1,2,3";
            comboBoxStId.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // TxtBoxStName
            // 
            TxtBoxStName.BackColor = Color.Beige;
            TxtBoxStName.BorderStyle = BorderStyle.FixedSingle;
            TxtBoxStName.Location = new Point(269, 192);
            TxtBoxStName.Name = "TxtBoxStName";
            TxtBoxStName.ReadOnly = true;
            TxtBoxStName.Size = new Size(220, 27);
            TxtBoxStName.TabIndex = 58;
            TxtBoxStName.TabStop = false;
            // 
            // lbStName
            // 
            lbStName.AutoSize = true;
            lbStName.BackColor = Color.Transparent;
            lbStName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbStName.ForeColor = Color.White;
            lbStName.Location = new Point(270, 166);
            lbStName.Name = "lbStName";
            lbStName.Size = new Size(99, 20);
            lbStName.TabIndex = 57;
            lbStName.Text = "Staff's Name";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(31, 192);
            dateTimePicker1.MaxDate = new DateTime(2026, 2, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(172, 27);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Value = new DateTime(2026, 2, 1, 0, 0, 0, 0);
            // 
            // lbOrCode
            // 
            lbOrCode.AutoSize = true;
            lbOrCode.BackColor = Color.Transparent;
            lbOrCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbOrCode.ForeColor = Color.White;
            lbOrCode.Location = new Point(266, 254);
            lbOrCode.Name = "lbOrCode";
            lbOrCode.Size = new Size(71, 20);
            lbOrCode.TabIndex = 63;
            lbOrCode.Text = "Currency";
            // 
            // comboBoxOrderNum
            // 
            comboBoxOrderNum.DisplayMember = "1,2,3";
            comboBoxOrderNum.FormattingEnabled = true;
            comboBoxOrderNum.Items.AddRange(new object[] { "001", "002", "003", "004", "005", "006", "007" });
            comboBoxOrderNum.Location = new Point(34, 280);
            comboBoxOrderNum.Name = "comboBoxOrderNum";
            comboBoxOrderNum.Size = new Size(173, 28);
            comboBoxOrderNum.TabIndex = 72;
            comboBoxOrderNum.ValueMember = "1,2,3";
            comboBoxOrderNum.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(370, 254);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 63;
            label3.Text = "Deposit ";
            // 
            // comboBoxCurrency
            // 
            comboBoxCurrency.DisplayMember = "1,2,3";
            comboBoxCurrency.Font = new Font("Khmer OS Siemreap", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCurrency.FormattingEnabled = true;
            comboBoxCurrency.Items.AddRange(new object[] { "Dollar​​ $ ", "KHR ៛" });
            comboBoxCurrency.Location = new Point(269, 280);
            comboBoxCurrency.Name = "comboBoxCurrency";
            comboBoxCurrency.Size = new Size(100, 32);
            comboBoxCurrency.TabIndex = 72;
            comboBoxCurrency.ValueMember = "1,2,3";
            comboBoxCurrency.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 254);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 63;
            label4.Text = "Order's Number";
            // 
            // TxtBoxTotal
            // 
            TxtBoxTotal.BackColor = Color.Beige;
            TxtBoxTotal.BorderStyle = BorderStyle.FixedSingle;
            TxtBoxTotal.Location = new Point(360, 413);
            TxtBoxTotal.Name = "TxtBoxTotal";
            TxtBoxTotal.ReadOnly = true;
            TxtBoxTotal.Size = new Size(120, 27);
            TxtBoxTotal.TabIndex = 58;
            TxtBoxTotal.TabStop = false;
            // 
            // TxtBoxRemain
            // 
            TxtBoxRemain.BackColor = Color.Beige;
            TxtBoxRemain.BorderStyle = BorderStyle.FixedSingle;
            TxtBoxRemain.Location = new Point(360, 472);
            TxtBoxRemain.Name = "TxtBoxRemain";
            TxtBoxRemain.ReadOnly = true;
            TxtBoxRemain.Size = new Size(120, 27);
            TxtBoxRemain.TabIndex = 58;
            TxtBoxRemain.TabStop = false;
            // 
            // numericUpDownDeposit
            // 
            numericUpDownDeposit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownDeposit.Location = new Point(375, 282);
            numericUpDownDeposit.Name = "numericUpDownDeposit";
            numericUpDownDeposit.Size = new Size(114, 30);
            numericUpDownDeposit.TabIndex = 74;
            numericUpDownDeposit.TextAlign = HorizontalAlignment.Center;
            numericUpDownDeposit.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(360, 385);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 63;
            label5.Text = "Total ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(360, 443);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 63;
            label6.Text = "Remain";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(522, 603);
            Controls.Add(numericUpDownDeposit);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBoxOrderNum);
            Controls.Add(comboBoxCurrency);
            Controls.Add(comboBoxStId);
            Controls.Add(lbStName);
            Controls.Add(lbPayCode);
            Controls.Add(TxtBoxRemain);
            Controls.Add(TxtBoxTotal);
            Controls.Add(TxtBoxStName);
            Controls.Add(TxtBoxTrxId);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lbOrCode);
            Controls.Add(label2);
            Controls.Add(lbSup);
            Controls.Add(btnClose);
            Controls.Add(btnPay);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Payment-Information System";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownDeposit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RoundedTextBox roundedTextBox2;
        private Label lbPayCode;
        private MaskedTextBox TxtBoxTrxId;
        private Button btnClose;
        private Button btnPay;
        private Label label1;
        private Label lbSup;
        private Label label2;
        private ComboBox comboBoxStId;
        private ListView ListView;
        private MaskedTextBox TxtBoxStName;
        private Label lbStName;
        private DateTimePicker dateTimePicker1;
        private Label lbOrCode;
        private ComboBox comboBoxOrderNum;
        private Label label3;
        private ComboBox comboBoxCurrency;
        private Label label4;
        private MaskedTextBox TxtBoxTotal;
        private MaskedTextBox TxtBoxRemain;
        private NumericUpDown numericUpDownDeposit;
        private Label label5;
        private Label label6;
    }
}