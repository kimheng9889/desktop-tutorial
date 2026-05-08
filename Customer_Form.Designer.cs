namespace WinFormsApp1
{
    partial class Customer_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Form));
            tbSearch = new RoundedTextBox();
            lbCusId = new Label();
            tbID = new MaskedTextBox();
            TbName = new MaskedTextBox();
            lbName = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            BtnNew = new Button();
            label1 = new Label();
            label2 = new Label();
            TbCon = new MaskedTextBox();
            btnSearch = new Button();
            btnExit = new Button();
            dataGridView1 = new DataGridView();
            btnUpSave = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tbSearch
            // 
            tbSearch.BackColor = SystemColors.Control;
            tbSearch.Location = new Point(26, 85);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search staff's name";
            tbSearch.Size = new Size(374, 45);
            tbSearch.TabIndex = 41;
            // 
            // lbCusId
            // 
            lbCusId.AutoSize = true;
            lbCusId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbCusId.Location = new Point(426, 90);
            lbCusId.Name = "lbCusId";
            lbCusId.Size = new Size(107, 20);
            lbCusId.TabIndex = 20;
            lbCusId.Text = "Customer's ID";
            // 
            // tbID
            // 
            tbID.Location = new Point(425, 116);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(255, 27);
            tbID.TabIndex = 21;
            tbID.TabStop = false;
            tbID.Text = "  Autonumber";
            // 
            // TbName
            // 
            TbName.Location = new Point(425, 180);
            TbName.Name = "TbName";
            TbName.Size = new Size(255, 27);
            TbName.TabIndex = 22;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbName.Location = new Point(426, 157);
            lbName.Name = "lbName";
            lbName.Size = new Size(125, 20);
            lbName.TabIndex = 25;
            lbName.Text = "Enter your name";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.DodgerBlue;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(427, 273);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 33);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "Cancel     ";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.DodgerBlue;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(539, 273);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 33);
            btnAdd.TabIndex = 36;
            btnAdd.Text = "  Add";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(26, 504);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(119, 39);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Update   ";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // BtnNew
            // 
            BtnNew.BackColor = Color.White;
            BtnNew.FlatAppearance.BorderSize = 3;
            BtnNew.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNew.ForeColor = SystemColors.ControlText;
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNew.Location = new Point(26, 504);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(120, 39);
            BtnNew.TabIndex = 38;
            BtnNew.Text = "    Add New  ";
            BtnNew.TextAlign = ContentAlignment.MiddleRight;
            BtnNew.UseVisualStyleBackColor = false;
            BtnNew.Click += BtnNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(240, 26);
            label1.Name = "label1";
            label1.Size = new Size(235, 28);
            label1.TabIndex = 39;
            label1.Text = "Customer's Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(427, 217);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 25;
            label2.Text = "Contact";
            // 
            // TbCon
            // 
            TbCon.Location = new Point(426, 240);
            TbCon.Name = "TbCon";
            TbCon.Size = new Size(255, 27);
            TbCon.TabIndex = 22;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.WindowText;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(300, 92);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(91, 31);
            btnSearch.TabIndex = 38;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 3;
            btnExit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ControlText;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(611, 504);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(70, 39);
            btnExit.TabIndex = 38;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 10;
            dataGridView1.Size = new Size(374, 361);
            dataGridView1.TabIndex = 42;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // btnUpSave
            // 
            btnUpSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpSave.ForeColor = Color.DodgerBlue;
            btnUpSave.Image = (Image)resources.GetObject("btnUpSave.Image");
            btnUpSave.ImageAlign = ContentAlignment.MiddleRight;
            btnUpSave.Location = new Point(539, 273);
            btnUpSave.Name = "btnUpSave";
            btnUpSave.Size = new Size(106, 33);
            btnUpSave.TabIndex = 36;
            btnUpSave.Text = "  Save";
            btnUpSave.TextAlign = ContentAlignment.MiddleLeft;
            btnUpSave.Click += btnUpSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.DodgerBlue;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(539, 273);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 33);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // Customer_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 563);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(tbSearch);
            Controls.Add(lbCusId);
            Controls.Add(tbID);
            Controls.Add(TbCon);
            Controls.Add(label2);
            Controls.Add(TbName);
            Controls.Add(lbName);
            Controls.Add(btnExit);
            Controls.Add(BtnNew);
            Controls.Add(label1);
            Controls.Add(btnUpSave);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Customer_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer-Form";
            Load += Customer_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private RoundedTextBox tbSearch;
        private Label lbCusId;
        private MaskedTextBox tbID;
        private MaskedTextBox TbName;
        private Label lbName;
        private Button btnCancel;
        private Button btnAdd;
        private Button btnUpdate;
        private Button BtnNew;

        private Label label1;
        private ListView ListView;
        private Label label2;
        private MaskedTextBox TbCon;
        private Button btnSearch;
        private Button btnExit;
        private DataGridView dataGridView1;
        private Button btnUpSave;
        private Button btnDelete;
    }
}