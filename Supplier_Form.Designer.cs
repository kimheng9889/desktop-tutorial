namespace WinFormsApp1
{
    partial class Supplier_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier_Form));
            label3 = new Label();
            roundedTextBox2 = new RoundedTextBox();
            lbStId = new Label();
            TxtBoxID = new MaskedTextBox();
            TxtBoxName = new MaskedTextBox();
            lbName = new Label();
            lbPos = new Label();
            TxtBoxPos = new MaskedTextBox();
            lbSalary = new Label();
            TxtBoxSalary = new MaskedTextBox();
            btnCancel = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            BtnNew = new Button();
            label1 = new Label();
            ListView = new ListView();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(365, 103);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 19;
            label3.Text = "         ";
            // 
            // roundedTextBox2
            // 
            roundedTextBox2.BackColor = SystemColors.Control;
            roundedTextBox2.Location = new Point(73, 94);
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.PlaceholderText = "Search staff's name";
            roundedTextBox2.Size = new Size(374, 45);
            roundedTextBox2.TabIndex = 34;
            // 
            // lbStId
            // 
            lbStId.AutoSize = true;
            lbStId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbStId.Location = new Point(473, 98);
            lbStId.Name = "lbStId";
            lbStId.Size = new Size(95, 20);
            lbStId.TabIndex = 20;
            lbStId.Text = "supplier's ID";
            // 
            // TxtBoxID
            // 
            TxtBoxID.Location = new Point(472, 124);
            TxtBoxID.Name = "TxtBoxID";
            TxtBoxID.ReadOnly = true;
            TxtBoxID.Size = new Size(255, 27);
            TxtBoxID.TabIndex = 21;
            TxtBoxID.TabStop = false;
            TxtBoxID.Text = "  Autonumber";
            // 
            // TxtBoxName
            // 
            TxtBoxName.Location = new Point(472, 188);
            TxtBoxName.Name = "TxtBoxName";
            TxtBoxName.Size = new Size(255, 27);
            TxtBoxName.TabIndex = 22;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbName.Location = new Point(473, 165);
            lbName.Name = "lbName";
            lbName.Size = new Size(128, 20);
            lbName.TabIndex = 23;
            lbName.Text = "Company's name";
            // 
            // lbPos
            // 
            lbPos.AutoSize = true;
            lbPos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbPos.Location = new Point(472, 230);
            lbPos.Name = "lbPos";
            lbPos.Size = new Size(143, 20);
            lbPos.TabIndex = 26;
            lbPos.Text = "Company's address";
            // 
            // TxtBoxPos
            // 
            TxtBoxPos.Location = new Point(472, 253);
            TxtBoxPos.Name = "TxtBoxPos";
            TxtBoxPos.Size = new Size(255, 27);
            TxtBoxPos.TabIndex = 24;
            // 
            // lbSalary
            // 
            lbSalary.AutoSize = true;
            lbSalary.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbSalary.Location = new Point(473, 289);
            lbSalary.Name = "lbSalary";
            lbSalary.Size = new Size(141, 20);
            lbSalary.TabIndex = 27;
            lbSalary.Text = "Company's contact";
            // 
            // TxtBoxSalary
            // 
            TxtBoxSalary.Location = new Point(472, 312);
            TxtBoxSalary.Name = "TxtBoxSalary";
            TxtBoxSalary.Size = new Size(255, 27);
            TxtBoxSalary.TabIndex = 25;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(626, 366);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 42);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(514, 368);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(73, 370);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(119, 40);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update   ";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BtnNew
            // 
            BtnNew.BackColor = Color.White;
            BtnNew.FlatAppearance.BorderSize = 3;
            BtnNew.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNew.ForeColor = SystemColors.ControlText;
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNew.Location = new Point(198, 368);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(120, 42);
            BtnNew.TabIndex = 31;
            BtnNew.Text = "    Add New  ";
            BtnNew.TextAlign = ContentAlignment.MiddleRight;
            BtnNew.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(287, 41);
            label1.Name = "label1";
            label1.Size = new Size(223, 28);
            label1.TabIndex = 32;
            label1.Text = "Supplier's Information";
            // 
            // ListView
            // 
            ListView.Location = new Point(73, 143);
            ListView.Name = "ListView";
            ListView.Size = new Size(374, 201);
            ListView.TabIndex = 33;
            ListView.UseCompatibleStateImageBehavior = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(roundedTextBox2);
            Controls.Add(lbStId);
            Controls.Add(TxtBoxID);
            Controls.Add(TxtBoxName);
            Controls.Add(lbName);
            Controls.Add(lbPos);
            Controls.Add(TxtBoxPos);
            Controls.Add(lbSalary);
            Controls.Add(TxtBoxSalary);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(BtnNew);
            Controls.Add(label1);
            Controls.Add(ListView);
            Name = "Form7";
            Text = "Supplier-Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private RoundedTextBox roundedTextBox2;
        private Label lbStId;
        private MaskedTextBox TxtBoxID;
        private MaskedTextBox TxtBoxName;
        private Label lbName;
        private Label lbPos;
        private MaskedTextBox TxtBoxPos;
        private Label lbSalary;
        private MaskedTextBox TxtBoxSalary;
        private Button btnCancel;
        private Button btnSave;
        private Button btnUpdate;
        private Button BtnNew;
        private Label label1;
        private ListView ListView;
    }
}