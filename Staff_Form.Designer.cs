using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class frmStaff
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmStaff));
            lbStId = new Label();
            TxtBoxID = new MaskedTextBox();
            TxtBoxName = new MaskedTextBox();
            lbName = new Label();
            lbPos = new Label();
            lbSalary = new Label();
            TxtBoxPos = new MaskedTextBox();
            TxtBoxSalary = new MaskedTextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            btnCancel = new Button();
            tbSearch = new RoundedTextBox();
            TxtBoxStatus = new Label();
            lbDob = new Label();
            FemaleRadio = new RadioButton();
            MaleRadio = new RadioButton();
            lbGen = new Label();
            dateTimePicker1 = new DateTimePicker();
            DGV = new DataGridView();
            btnSearch = new Button();
            BtnNew = new Button();
            btnSaveUp = new Button();
            lbAddState = new Label();
            checkBoxStop_work = new CheckBox();
            ((ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // lbStId
            // 
            lbStId.AutoSize = true;
            lbStId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbStId.Location = new Point(429, 77);
            lbStId.Name = "lbStId";
            lbStId.Size = new Size(73, 20);
            lbStId.TabIndex = 0;
            lbStId.Text = "Staff's ID";
            // 
            // TxtBoxID
            // 
            TxtBoxID.Location = new Point(428, 103);
            TxtBoxID.Name = "TxtBoxID";
            TxtBoxID.Size = new Size(255, 27);
            TxtBoxID.TabIndex = 1;
            TxtBoxID.TabStop = false;
            // 
            // TxtBoxName
            // 
            TxtBoxName.Location = new Point(428, 167);
            TxtBoxName.Name = "TxtBoxName";
            TxtBoxName.Size = new Size(255, 27);
            TxtBoxName.TabIndex = 1;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbName.Location = new Point(429, 144);
            lbName.Name = "lbName";
            lbName.Size = new Size(77, 20);
            lbName.TabIndex = 3;
            lbName.Text = "Full name";
            // 
            // lbPos
            // 
            lbPos.AutoSize = true;
            lbPos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbPos.Location = new Point(428, 346);
            lbPos.Name = "lbPos";
            lbPos.Size = new Size(66, 20);
            lbPos.TabIndex = 9;
            lbPos.Text = "Position";
            // 
            // lbSalary
            // 
            lbSalary.AutoSize = true;
            lbSalary.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbSalary.Location = new Point(429, 405);
            lbSalary.Name = "lbSalary";
            lbSalary.Size = new Size(52, 20);
            lbSalary.TabIndex = 11;
            lbSalary.Text = "Salary";
            // 
            // TxtBoxPos
            // 
            TxtBoxPos.Location = new Point(428, 369);
            TxtBoxPos.Name = "TxtBoxPos";
            TxtBoxPos.Size = new Size(255, 27);
            TxtBoxPos.TabIndex = 4;
            // 
            // TxtBoxSalary
            // 
            TxtBoxSalary.Location = new Point(428, 428);
            TxtBoxSalary.Name = "TxtBoxSalary";
            TxtBoxSalary.Size = new Size(255, 27);
            TxtBoxSalary.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(548, 527);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(29, 530);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(119, 39);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update   ";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(243, 20);
            label1.Name = "label1";
            label1.Size = new Size(191, 28);
            label1.TabIndex = 16;
            label1.Text = "Staff's Information";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(427, 527);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 42);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.Click += btnCancel_Click;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = SystemColors.Control;
            tbSearch.Location = new Point(29, 73);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search staff's name";
            tbSearch.Size = new Size(374, 45);
            tbSearch.TabIndex = 18;
            // 
            // TxtBoxStatus
            // 
            TxtBoxStatus.AutoSize = true;
            TxtBoxStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TxtBoxStatus.Location = new Point(429, 463);
            TxtBoxStatus.Name = "TxtBoxStatus";
            TxtBoxStatus.Size = new Size(0, 20);
            TxtBoxStatus.TabIndex = 11;
            // 
            // lbDob
            // 
            lbDob.AutoSize = true;
            lbDob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbDob.Location = new Point(428, 283);
            lbDob.Name = "lbDob";
            lbDob.Size = new Size(100, 20);
            lbDob.TabIndex = 7;
            lbDob.Text = "Date of Birth";
            // 
            // FemaleRadio
            // 
            FemaleRadio.Location = new Point(544, 241);
            FemaleRadio.Name = "FemaleRadio";
            FemaleRadio.Size = new Size(104, 24);
            FemaleRadio.TabIndex = 2;
            FemaleRadio.TabStop = true;
            FemaleRadio.Text = "Female";
            // 
            // MaleRadio
            // 
            MaleRadio.Location = new Point(436, 241);
            MaleRadio.Name = "MaleRadio";
            MaleRadio.Size = new Size(104, 24);
            MaleRadio.TabIndex = 2;
            MaleRadio.TabStop = true;
            MaleRadio.Text = "Male";
            // 
            // lbGen
            // 
            lbGen.AutoSize = true;
            lbGen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGen.Location = new Point(429, 206);
            lbGen.Name = "lbGen";
            lbGen.Size = new Size(60, 20);
            lbGen.TabIndex = 4;
            lbGen.Text = "Gender";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.DarkCyan;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(429, 314);
            dateTimePicker1.MaxDate = new DateTime(2026, 4, 24, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(138, 27);
            dateTimePicker1.TabIndex = 19;
            dateTimePicker1.Value = new DateTime(2026, 4, 24, 0, 0, 0, 0);
            // 
            // DGV
            // 
            DGV.BackgroundColor = SystemColors.ButtonFace;
            DGV.BorderStyle = BorderStyle.Fixed3D;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(29, 124);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RowHeadersWidth = 51;
            DGV.Size = new Size(374, 398);
            DGV.TabIndex = 20;
            DGV.CellContentClick += DGV_CellClick;
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
            btnSearch.Location = new Point(306, 79);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(91, 31);
            btnSearch.TabIndex = 39;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // BtnNew
            // 
            BtnNew.BackColor = Color.White;
            BtnNew.FlatAppearance.BorderSize = 3;
            BtnNew.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNew.ForeColor = SystemColors.ControlText;
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNew.Location = new Point(28, 531);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(120, 40);
            BtnNew.TabIndex = 15;
            BtnNew.Text = "    Add New  ";
            BtnNew.TextAlign = ContentAlignment.MiddleRight;
            BtnNew.UseVisualStyleBackColor = false;
            BtnNew.Click += BtnNew_Click;
            // 
            // btnSaveUp
            // 
            btnSaveUp.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSaveUp.ForeColor = Color.DodgerBlue;
            btnSaveUp.Image = (Image)resources.GetObject("btnSaveUp.Image");
            btnSaveUp.ImageAlign = ContentAlignment.MiddleRight;
            btnSaveUp.Location = new Point(548, 527);
            btnSaveUp.Name = "btnSaveUp";
            btnSaveUp.Size = new Size(100, 40);
            btnSaveUp.TabIndex = 40;
            btnSaveUp.Text = "  Save";
            btnSaveUp.TextAlign = ContentAlignment.MiddleLeft;
            btnSaveUp.Click += btnSaveUp_Click;
            // 
            // lbAddState
            // 
            lbAddState.AutoSize = true;
            lbAddState.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAddState.Location = new Point(28, 541);
            lbAddState.Name = "lbAddState";
            lbAddState.Size = new Size(124, 20);
            lbAddState.TabIndex = 4;
            lbAddState.Text = "Adding new staff";
            // 
            // checkBoxStop_work
            // 
            checkBoxStop_work.AutoSize = true;
            checkBoxStop_work.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxStop_work.Location = new Point(431, 473);
            checkBoxStop_work.Name = "checkBoxStop_work";
            checkBoxStop_work.Size = new Size(102, 24);
            checkBoxStop_work.TabIndex = 41;
            checkBoxStop_work.Text = "Stop work";
            checkBoxStop_work.UseVisualStyleBackColor = true;
            // 
            // frmStaff
            // 
            ClientSize = new Size(740, 583);
            Controls.Add(checkBoxStop_work);
            Controls.Add(btnSearch);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbSearch);
            Controls.Add(lbStId);
            Controls.Add(TxtBoxID);
            Controls.Add(TxtBoxName);
            Controls.Add(lbName);
            Controls.Add(lbAddState);
            Controls.Add(lbGen);
            Controls.Add(MaleRadio);
            Controls.Add(FemaleRadio);
            Controls.Add(lbDob);
            Controls.Add(lbPos);
            Controls.Add(TxtBoxPos);
            Controls.Add(TxtBoxStatus);
            Controls.Add(lbSalary);
            Controls.Add(TxtBoxSalary);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(DGV);
            Controls.Add(btnUpdate);
            Controls.Add(BtnNew);
            Controls.Add(btnSaveUp);
            Controls.Add(btnAdd);
            Name = "frmStaff";
            Text = "Staff-Form";
            Load += frmStaff_Load;
            ((ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbStId;
        private MaskedTextBox TxtBoxID;
        private MaskedTextBox TxtBoxName;
        private Label lbName;
        private Label lbPos;
        private Label lbSalary;
        private MaskedTextBox TxtBoxPos;
        private MaskedTextBox TxtBoxSalary;
        private Button btnAdd;
        private Button btnUpdate;
        private Label label1;
        private RoundedTextBox roundedTextBox1;
        private Button btnCancel;
        private RoundedTextBox tbSearch;
        private Label TxtBoxStatus;
        private MaskedTextBox TxtBoxDOB;
        private Label lbDob;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label lbGen;
        private RadioButton FemaleRadio;
        private RadioButton MaleRadio;
        private DateTimePicker dateTimePicker1;
        private DataGridView DGV;
        private Button btnSearch;
        private Button BtnNew;
        private Button btnSaveUp;
        private Label lbAddState;
        private CheckBox checkBoxStop_work;
    }
}
