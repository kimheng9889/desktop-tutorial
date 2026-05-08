using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Add options to ComboBox
            OptionBox.Items.Add("Form Staff");
            OptionBox.Items.Add("Form Customer");
            OptionBox.Items.Add("Form Product");
            OptionBox.Items.Add("Form Dashboard");

            // Optional: set default selection
            OptionBox.SelectedIndex = 0;
            this.AcceptButton = btnEnter;
        }

        private void OptionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void OptionBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter.PerformClick();
            }
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Check if user selected something
            if (OptionBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an option first.");
                return;
            }

            string option = OptionBox.SelectedItem.ToString();

            switch (option)
            {
                case "Form Staff":
                    frmStaff fs = new frmStaff();
                    fs.Show();
                    this.Hide();
                    break;

                case "Form Customer":
                    Customer_Form fc = new Customer_Form();
                    fc.Show();
                    this.Hide();
                    break;

                case "Form Product":
                    Product_Form fp = new Product_Form();
                    fp.Show();
                    this.Hide();
                    break;

                case "Form Dashboard":
                    Dashboard_Form fd = new Dashboard_Form();
                    fd.Show();
                    this.Hide();
                    break;

                default:
                    MessageBox.Show("Form not found.");
                    break;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}