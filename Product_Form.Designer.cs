namespace WinFormsApp1
{
    partial class Product_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Form));
            label3 = new Label();
            roundedTextBox2 = new RoundedTextBox();
            lbPcode = new Label();
            TxtBoxID = new MaskedTextBox();
            TxtBoxQty = new MaskedTextBox();
            lbQty = new Label();
            TxtBoxPname = new MaskedTextBox();
            lbName = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            BtnNew = new Button();
            label1 = new Label();
            ListView = new ListView();
            lbUps = new Label();
            TxtBoxStock = new MaskedTextBox();
            lbSup = new Label();
            TxtBoxUnitPrice = new MaskedTextBox();
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
            label3.Location = new Point(317, 93);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 42;
            label3.Text = "         ";
            // 
            // roundedTextBox2
            // 
            roundedTextBox2.BackColor = SystemColors.Control;
            roundedTextBox2.Location = new Point(25, 84);
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.PlaceholderText = "Search staff's name";
            roundedTextBox2.Size = new Size(374, 45);
            roundedTextBox2.TabIndex = 55;
            // 
            // lbPcode
            // 
            lbPcode.AutoSize = true;
            lbPcode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbPcode.Location = new Point(431, 89);
            lbPcode.Name = "lbPcode";
            lbPcode.Size = new Size(113, 20);
            lbPcode.TabIndex = 43;
            lbPcode.Text = "Product's Code";
            // 
            // TxtBoxID
            // 
            TxtBoxID.Location = new Point(430, 115);
            TxtBoxID.Name = "TxtBoxID";
            TxtBoxID.ReadOnly = true;
            TxtBoxID.Size = new Size(255, 27);
            TxtBoxID.TabIndex = 44;
            TxtBoxID.TabStop = false;
            TxtBoxID.Text = "  Autonumber";
            // 
            // TxtBoxQty
            // 
            TxtBoxQty.Location = new Point(431, 256);
            TxtBoxQty.Name = "TxtBoxQty";
            TxtBoxQty.Size = new Size(255, 27);
            TxtBoxQty.TabIndex = 45;
            // 
            // lbQty
            // 
            lbQty.AutoSize = true;
            lbQty.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbQty.Location = new Point(432, 233);
            lbQty.Name = "lbQty";
            lbQty.Size = new Size(128, 20);
            lbQty.TabIndex = 47;
            lbQty.Text = "Quantity in stock";
            // 
            // TxtBoxPname
            // 
            TxtBoxPname.Location = new Point(431, 184);
            TxtBoxPname.Name = "TxtBoxPname";
            TxtBoxPname.Size = new Size(255, 27);
            TxtBoxPname.TabIndex = 46;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbName.Location = new Point(432, 161);
            lbName.Name = "lbName";
            lbName.Size = new Size(117, 20);
            lbName.TabIndex = 48;
            lbName.Text = "Product's name";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.DodgerBlue;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(537, 454);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 42);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "     Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.DodgerBlue;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(431, 456);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 50;
            btnSave.Text = "  Save";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(25, 502);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(119, 39);
            btnUpdate.TabIndex = 51;
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
            BtnNew.Location = new Point(150, 502);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(120, 39);
            BtnNew.TabIndex = 52;
            BtnNew.Text = "    Add New  ";
            BtnNew.TextAlign = ContentAlignment.MiddleRight;
            BtnNew.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(239, 28);
            label1.Name = "label1";
            label1.Size = new Size(219, 28);
            label1.TabIndex = 53;
            label1.Text = "Product's Information";
            // 
            // ListView
            // 
            ListView.Location = new Point(25, 133);
            ListView.Name = "ListView";
            ListView.Size = new Size(374, 363);
            ListView.TabIndex = 54;
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.SelectedIndexChanged += ListView_SelectedIndexChanged;
            // 
            // lbUps
            // 
            lbUps.AutoSize = true;
            lbUps.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbUps.Location = new Point(432, 312);
            lbUps.Name = "lbUps";
            lbUps.Size = new Size(135, 20);
            lbUps.TabIndex = 47;
            lbUps.Text = "Unit price in stock";
            // 
            // TxtBoxStock
            // 
            TxtBoxStock.Location = new Point(431, 335);
            TxtBoxStock.Name = "TxtBoxStock";
            TxtBoxStock.Size = new Size(255, 27);
            TxtBoxStock.TabIndex = 45;
            TxtBoxStock.Tag = "gafdsgfdsg";
            // 
            // lbSup
            // 
            lbSup.AutoSize = true;
            lbSup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbSup.Location = new Point(432, 387);
            lbSup.Name = "lbSup";
            lbSup.Size = new Size(107, 20);
            lbSup.TabIndex = 47;
            lbSup.Text = "Sale unit price";
            // 
            // TxtBoxUnitPrice
            // 
            TxtBoxUnitPrice.Location = new Point(431, 410);
            TxtBoxUnitPrice.Name = "TxtBoxUnitPrice";
            TxtBoxUnitPrice.Size = new Size(255, 27);
            TxtBoxUnitPrice.TabIndex = 45;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 562);
            Controls.Add(label3);
            Controls.Add(roundedTextBox2);
            Controls.Add(lbPcode);
            Controls.Add(TxtBoxID);
            Controls.Add(TxtBoxUnitPrice);
            Controls.Add(lbSup);
            Controls.Add(TxtBoxStock);
            Controls.Add(lbUps);
            Controls.Add(TxtBoxQty);
            Controls.Add(lbQty);
            Controls.Add(TxtBoxPname);
            Controls.Add(lbName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(BtnNew);
            Controls.Add(label1);
            Controls.Add(ListView);
            Name = "Form3";
            Text = "Product-Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private RoundedTextBox roundedTextBox2;
        private Label lbPcode;
        private MaskedTextBox TxtBoxID;
        private MaskedTextBox TxtBoxQty;
        private Label lbQty;
        private MaskedTextBox TxtBoxPname;
        private Label lbName;
        private Button btnCancel;
        private Button btnSave;
        private Button btnUpdate;
        private Button BtnNew;
        private Label label1;
        private ListView ListView;
        private Label lbUps;
        private MaskedTextBox TxtBoxStock;
        private Label lbSup;
        private MaskedTextBox TxtBoxUnitPrice;
    }
}