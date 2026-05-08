using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class frmStaff : Form
    {
        A6 obj;
        SqlCommand com;
        int selectedId = 0;
        enum FormMode
        {
            View,
            New,
            Edit,
            Update,
            Add,
            SaveUp,
            UpdateClick
        }

        FormMode mode = FormMode.View;

        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {

            LoadStaff();
            obj = new A6();
            //obj.A6 Con();
            this.AcceptButton = btnSearch;
            tbSearch.Focus();
            SetMode(FormMode.View);
            DateTimeData();


        }
        //-----------------------------------------------------------------------------------------------------------------------------
        //MODE EUM MEHTOD:
        void SetMode(FormMode newMode)
        {
            mode = newMode;

            switch (mode)
            {
                case FormMode.View:

                    TxtBoxID.ReadOnly = true;
                    TxtBoxName.ReadOnly = true;
                    TxtBoxPos.ReadOnly = true;
                    TxtBoxSalary.ReadOnly = true;
                    dateTimePicker1.Enabled = false;
                    MaleRadio.Enabled = false;
                    FemaleRadio.Enabled = false;
                    //DGV.Enabled = false;
                    btnCancel.Hide();
                    btnAdd.Hide();
                    BtnNew.Show();
                    btnUpdate.Hide();
                    btnSaveUp.Hide();
                    lbAddState.Hide();
                    checkBoxStop_work.Enabled = false;
                    break;

                case FormMode.Add:

                    TxtBoxID.ReadOnly = true;
                    TxtBoxName.ReadOnly = false;
                    TxtBoxPos.ReadOnly = false;
                    TxtBoxSalary.ReadOnly = false;
                    dateTimePicker1.Enabled = true;
                    MaleRadio.Enabled = true;
                    FemaleRadio.Enabled = true;
                    //DGV.Enabled = false;
                    btnCancel.Show();
                    btnAdd.Show();
                    btnUpdate.Hide();
                    BtnNew.Hide();
                    btnSaveUp.Hide();
                    lbAddState.Show();
                    break;

                //no set yet
                case FormMode.SaveUp:
                    TxtBoxID.ReadOnly = true;
                    TxtBoxName.ReadOnly = false;
                    TxtBoxPos.ReadOnly = false;
                    TxtBoxSalary.ReadOnly = false;
                    dateTimePicker1.Enabled = true;
                    MaleRadio.Enabled = true;
                    FemaleRadio.Enabled = true;
                    btnCancel.Show();
                    btnAdd.Hide();
                    btnSaveUp.Show();
                    btnUpdate.Hide();
                    BtnNew.Hide();


                    break;

                case FormMode.UpdateClick:

                    TxtBoxID.ReadOnly = true;
                    TxtBoxName.ReadOnly = false;
                    TxtBoxPos.ReadOnly = false;
                    TxtBoxSalary.ReadOnly = false;
                    dateTimePicker1.Enabled = true;
                    MaleRadio.Enabled = true;
                    FemaleRadio.Enabled = true;
                    //DGV.Enabled = false;
                    btnCancel.Show();
                    btnAdd.Hide();
                    btnSaveUp.Show();
                    btnUpdate.Hide();
                    BtnNew.Hide();
                    checkBoxStop_work.Enabled = true;






                    break;
            }
        }



        //-----------------------------------------------------------------------------------------------------------------------------
        //Mothod:
        private bool LoadStaff()
        {
            A6 obj = new A6();

            try
            {
                using (SqlCommand com = new SqlCommand("GetStaff", obj.con))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    obj.con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DGV.DataSource = dt;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                obj.con.Close();
            }
        }
        void ClearData()
        {
            TxtBoxID.Clear();
            TxtBoxName.Clear();

            TxtBoxPos.Clear();
            TxtBoxSalary.Clear();
            tbSearch.Text = " ";
            MaleRadio.Checked = false;
            FemaleRadio.Checked = false;
            dateTimePicker1.Value = DateTime.Today;

        }


        void DateTimeData()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1);
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        //event Headler
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells["stID"].Value);
                TxtBoxID.Text = selectedId.ToString();
                TxtBoxName.Text = row.Cells["FullName"].Value.ToString();
                string readGen = row.Cells["Gen"].Value.ToString();

                if (readGen == "M")
                    MaleRadio.Checked = true;
                else if (readGen == "F")
                    FemaleRadio.Checked = true;
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["Dob"].Value);
                TxtBoxPos.Text = row.Cells["Position"].Value.ToString();
                TxtBoxSalary.Text = row.Cells["Salary"].Value.ToString();

                if (row.Cells["Stopwork"].Value == DBNull.Value ||
                     string.IsNullOrWhiteSpace(row.Cells["Stopwork"].Value.ToString()))
                {
                    checkBoxStop_work.Checked = false;
                }
                else
                {
                    checkBoxStop_work.Checked = true;
                }

                BtnNew.Hide();
                btnUpdate.Show();
                lbAddState.Hide();
                btnCancel.Show();

                TxtBoxID.ReadOnly = true;
                TxtBoxName.ReadOnly = true;
                TxtBoxPos.ReadOnly = true;
                TxtBoxSalary.ReadOnly = true;
                dateTimePicker1.Enabled = false;
                MaleRadio.Enabled = false;
                FemaleRadio.Enabled = false;
                checkBoxStop_work.Enabled = false;

            }
        }


        //-----------------------------------------------------------------------------------------------------------------------------


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!byte.TryParse(TxtBoxID.Text, out byte staffID))
                {
                    MessageBox.Show("Please enter a valid numeric ID.");
                    return;
                }


                com = new SqlCommand("InStaff", obj.con);
                com.CommandType = CommandType.StoredProcedure;

                string gen = MaleRadio.Checked ? "M" : "F";
                com.Parameters.AddWithValue("@sid", staffID);
                com.Parameters.AddWithValue("@fn", TxtBoxName.Text);
                com.Parameters.AddWithValue("@g", gen);
                com.Parameters.AddWithValue("@dob", Convert.ToDateTime(dateTimePicker1.Text));
                com.Parameters.AddWithValue("@po", TxtBoxPos.Text);
                com.Parameters.AddWithValue("@sa", Convert.ToDecimal(TxtBoxSalary.Text));

                // var modify @Scode = autoNum




                com.ExecuteNonQuery();
                MessageBox.Show("Staff inserted successfully!");
                ClearData();
                SetMode(FormMode.View);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSaveUp_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a row first!");
                return;
            }

            A6 obj = new A6();

            try
            {
                using (SqlCommand com = new SqlCommand("UpdateStaff", obj.con))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    string gen = MaleRadio.Checked ? "M" : "F";

                    com.Parameters.AddWithValue("@ID", Convert.ToInt32(TxtBoxID.Text));
                    com.Parameters.AddWithValue("@Name", TxtBoxName.Text);
                    com.Parameters.AddWithValue("@G", gen);
                    com.Parameters.AddWithValue("@Dob", dateTimePicker1.Value.Date);
                    com.Parameters.AddWithValue("@Pos", TxtBoxPos.Text);
                    com.Parameters.AddWithValue("@Sa", Convert.ToDecimal(TxtBoxSalary.Text));
                    //com.Parameters.AddWithValue("@StopWork", checkBoxStop_work.Checked);
                    com.Parameters.Add("@StopWork", SqlDbType.Bit).Value = checkBoxStop_work.Checked;

                    obj.con.Open();
                    com.ExecuteNonQuery();

                    MessageBox.Show("Updated!");
                    LoadStaff();
                    SetMode(FormMode.View);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                obj.con.Close();
            }

        }


        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearData();
            SetMode(FormMode.Add);
            lbAddState.Show();
            lbAddState.Text = "Insert staff information";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
            LoadStaff();
            SetMode(FormMode.View);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SetMode(FormMode.UpdateClick);
            lbAddState.Show();
            lbAddState.Text = "Update staff information";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void TbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null); // trigger search

                e.SuppressKeyPress = true; // prevent beep sound
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            A6 obj = new A6();

            try
            {
                using (SqlCommand com = new SqlCommand("SearchStaff", obj.con))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@keyword", tbSearch.Text);

                    obj.con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DGV.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                obj.con.Close();
            }

        }

    
    }
}