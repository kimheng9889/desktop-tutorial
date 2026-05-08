namespace WinFormsApp1
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            OptionBox = new ComboBox();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            sqlCommandBuilder1 = new System.Data.SqlClient.SqlCommandBuilder();
            btnEnter = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // OptionBox
            // 
            OptionBox.AccessibleRole = AccessibleRole.Dialog;
            OptionBox.Anchor = AnchorStyles.None;
            OptionBox.BackColor = SystemColors.Window;
            OptionBox.Cursor = Cursors.Hand;
            OptionBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OptionBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            OptionBox.ForeColor = Color.CornflowerBlue;
            OptionBox.Location = new Point(100, 115);
            OptionBox.Name = "OptionBox";
            OptionBox.Size = new Size(174, 28);
            OptionBox.TabIndex = 1;
            OptionBox.Tag = "";
            OptionBox.SelectedIndexChanged += OptionBox_SelectedIndexChanged;
            OptionBox.KeyDown += OptionBox_KeyDown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(100, 88);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 3;
            label2.Text = "Users Option";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "a";
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // btnEnter
            // 
            btnEnter.Anchor = AnchorStyles.None;
            btnEnter.FlatAppearance.BorderSize = 3;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = Color.Transparent;
            btnEnter.Location = new Point(290, 194);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(80, 36);
            btnEnter.TabIndex = 4;
            btnEnter.Text = "enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(70, 44);
            label1.Name = "label1";
            label1.Size = new Size(250, 23);
            label1.TabIndex = 3;
            label1.Text = "     Shop Management System";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, -26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 86);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(382, 239);
            Controls.Add(btnEnter);
            Controls.Add(OptionBox);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlLightLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox OptionBox;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private System.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnEnter;
        private Label label1;
        private GroupBox groupBox1;
    }
}