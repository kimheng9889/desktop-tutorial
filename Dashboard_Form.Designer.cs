namespace WinFormsApp1
{
    partial class Dashboard_Form
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
            label1 = new Label();
            tbNumSt = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            tbTotalSa = new TextBox();
            btnClose = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            tbGrandTotal = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tbTotalQty = new TextBox();
            tbNumOfPro = new TextBox();
            groupBox3 = new GroupBox();
            label7 = new Label();
            tbNumOfSup = new TextBox();
            tbSuo = new GroupBox();
            label4 = new Label();
            tbNumOfCus = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tbSuo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(105, 17);
            label1.TabIndex = 0;
            label1.Text = "Number of Staff";
            // 
            // tbNumSt
            // 
            tbNumSt.Location = new Point(6, 46);
            tbNumSt.Name = "tbNumSt";
            tbNumSt.ReadOnly = true;
            tbNumSt.Size = new Size(171, 30);
            tbNumSt.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.BackColor = Color.DarkOrange;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbTotalSa);
            groupBox1.Controls.Add(tbNumSt);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(10, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(188, 147);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "STAFF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 77);
            label2.Name = "label2";
            label2.Size = new Size(78, 17);
            label2.TabIndex = 0;
            label2.Text = "Total Salary";
            // 
            // tbTotalSa
            // 
            tbTotalSa.Location = new Point(6, 97);
            tbTotalSa.Name = "tbTotalSa";
            tbTotalSa.ReadOnly = true;
            tbTotalSa.Size = new Size(171, 30);
            tbTotalSa.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(90, 315);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 32);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.BackColor = Color.DarkOrange;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tbGrandTotal);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbTotalQty);
            groupBox2.Controls.Add(tbNumOfPro);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ControlText;
            groupBox2.Location = new Point(204, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(190, 353);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "PRODUCT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 130);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 2;
            label3.Text = "Grand Total";
            // 
            // tbGrandTotal
            // 
            tbGrandTotal.Location = new Point(6, 150);
            tbGrandTotal.Name = "tbGrandTotal";
            tbGrandTotal.ReadOnly = true;
            tbGrandTotal.Size = new Size(171, 30);
            tbGrandTotal.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 77);
            label5.Name = "label5";
            label5.Size = new Size(94, 17);
            label5.TabIndex = 0;
            label5.Text = "Total Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 26);
            label6.Name = "label6";
            label6.Size = new Size(126, 17);
            label6.TabIndex = 0;
            label6.Text = "Number of Product";
            // 
            // tbTotalQty
            // 
            tbTotalQty.Location = new Point(6, 97);
            tbTotalQty.Name = "tbTotalQty";
            tbTotalQty.ReadOnly = true;
            tbTotalQty.Size = new Size(171, 30);
            tbTotalQty.TabIndex = 1;
            // 
            // tbNumOfPro
            // 
            tbNumOfPro.Location = new Point(6, 46);
            tbNumOfPro.Name = "tbNumOfPro";
            tbNumOfPro.ReadOnly = true;
            tbNumOfPro.Size = new Size(171, 30);
            tbNumOfPro.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox3.BackColor = Color.DarkOrange;
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(tbNumOfSup);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.ControlText;
            groupBox3.Location = new Point(10, 162);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(188, 100);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "SUPPLIER";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 26);
            label7.Name = "label7";
            label7.Size = new Size(127, 17);
            label7.TabIndex = 0;
            label7.Text = "Number of Supplier";
            // 
            // tbNumOfSup
            // 
            tbNumOfSup.Location = new Point(6, 46);
            tbNumOfSup.Name = "tbNumOfSup";
            tbNumOfSup.ReadOnly = true;
            tbNumOfSup.Size = new Size(171, 30);
            tbNumOfSup.TabIndex = 1;
            // 
            // tbSuo
            // 
            tbSuo.Anchor = AnchorStyles.None;
            tbSuo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbSuo.BackColor = Color.DarkOrange;
            tbSuo.Controls.Add(label4);
            tbSuo.Controls.Add(tbNumOfCus);
            tbSuo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSuo.ForeColor = SystemColors.ControlText;
            tbSuo.Location = new Point(10, 268);
            tbSuo.Name = "tbSuo";
            tbSuo.Size = new Size(188, 94);
            tbSuo.TabIndex = 3;
            tbSuo.TabStop = false;
            tbSuo.Text = "CUSTOMER";
            tbSuo.Enter += tbSuo_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 26);
            label4.Name = "label4";
            label4.Size = new Size(137, 17);
            label4.TabIndex = 0;
            label4.Text = "Number of Customer";
            // 
            // tbNumOfCus
            // 
            tbNumOfCus.Location = new Point(6, 46);
            tbNumOfCus.Name = "tbNumOfCus";
            tbNumOfCus.ReadOnly = true;
            tbNumOfCus.Size = new Size(165, 30);
            tbNumOfCus.TabIndex = 1;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(406, 371);
            Controls.Add(tbSuo);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Form8_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tbSuo.ResumeLayout(false);
            tbSuo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox tbNumSt;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox tbTotalSa;
        private Button btnClose;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private TextBox tbTotalQty;
        private TextBox tbNumOfPro;
        private Label label3;
        private TextBox tbGrandTotal;
        private GroupBox groupBox3;
        private Label label7;
        private TextBox tbNumOfSup;
        private GroupBox tbSuo;
        private Label label4;
        private TextBox tbNumOfCus;
    }
}