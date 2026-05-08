namespace WinFormsApp1
{
    partial class RoundedTextBox
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox innerTextBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            innerTextBox = new TextBox();
            SuspendLayout();
            // 
            // innerTextBox
            // 
            innerTextBox.BorderStyle = BorderStyle.None;
            innerTextBox.Location = new Point(12, 10);
            innerTextBox.Name = "innerTextBox";
            innerTextBox.Size = new Size(176, 20);
            innerTextBox.TabIndex = 0;
            innerTextBox.TextChanged += innerTextBox_TextChanged;
            // 
            // RoundedTextBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            Controls.Add(innerTextBox);
            Name = "RoundedTextBox";
            Padding = new Padding(12, 10, 12, 10);
            Size = new Size(200, 36);
            Load += RoundedTextBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}