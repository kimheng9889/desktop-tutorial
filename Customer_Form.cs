using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Customer_Form : Form
    {
        int selectedId = 0;

        enum FormMode
        {
            View,
            New,
            Edit,
            Update,
            Add
        }

        FormMode mode = FormMode.View;

        public Customer_Form()
        {
            InitializeComponent();
        }

        // ================= LOAD =================
        private void Customer_Form_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            SetMode(FormMode.View);
            this.AcceptButton = btnSearch;
            tbSearch.Focus();

        }

        // ================= MODE CONTROLLER =================
        void SetMode(FormMode newMode)
        {
            mode = newMode;

            switch (mode)
            {
                case FormMode.View:
                    TbName.ReadOnly = true;
                    TbCon.ReadOnly = true;

                    btnDelete.Hide();
                    BtnNew.Show();
                    btnUpSave.Hide();
                    btnAdd.Hide();
                    btnUpdate.Hide();
                    btnCancel.Hide();
                    break;
                case FormMode.Add:
                    TbName.ReadOnly = false;
                    TbCon.ReadOnly = false;

                    btnDelete.Hide();
                    BtnNew.Hide();
                    btnUpSave.Hide();
                    btnAdd.Show();
                    btnUpdate.Hide();
                    btnCancel.Show();
                    break;

                case FormMode.New:
                    TbName.ReadOnly = false;
                    TbCon.ReadOnly = false;

                    BtnNew.Hide();
                    btnUpSave.Hide();
                    btnAdd.Show();
                    btnUpdate.Hide();
                    btnCancel.Show();
                    break;


                case FormMode.Edit:
                    TbName.ReadOnly = true;
                    TbCon.ReadOnly = true;

                    BtnNew.Hide();
                    btnAdd.Hide();
                    btnDelete.Show();
                    btnUpdate.Show();
                    btnCancel.Show();
                    btnUpSave.Hide();
                    break;

                case FormMode.Update:
                    TbName.ReadOnly = false;
                    TbCon.ReadOnly = false;

                    BtnNew.Hide();
                    btnAdd.Hide();
                    btnDelete.Hide();
                    btnUpdate.Hide();
                    btnCancel.Show();
                    btnUpSave.Show();
                    break;
            }
        }

        // ================= LOAD DATA =================
        private bool LoadCustomers()
        {
            A6 obj = new A6();

            try
            {
                using (SqlCommand com = new SqlCommand("GetCustomer", obj.con))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    obj.con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
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

        // ================= CLEAR =================
        void Cancel()
        {
            TbName.Clear();
            TbCon.Clear();
            tbID.Text = "Autonumber";
            selectedId = 0;

            SetMode(FormMode.View);
        }

        // ================= GRID CLICK =================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells["CusID"].Value);
                tbID.Text = selectedId.ToString();
                TbName.Text = row.Cells["CusName"].Value.ToString();
                TbCon.Text = row.Cells["CusContact"].Value.ToString();

                SetMode(FormMode.Edit);
            }
        }

        // ================= NEW =================
        private void BtnNew_Click(object sender, EventArgs e)
        {
            selectedId = 0;

            TbName.Clear();
            TbCon.Clear();
            tbID.Text = "Autonumber";

            SetMode(FormMode.Add);
        }

        // ================= ADD =================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            A6 obj = new A6();

            try
            {
                using (SqlCommand com = new SqlCommand("InCustomer", obj.con))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@CN", TbName.Text);
                    com.Parameters.AddWithValue("@CC", TbCon.Text);

                    SqlParameter p = new SqlParameter("@NewCid", SqlDbType.Int);
                    p.Direction = ParameterDirection.Output;
                    com.Parameters.Add(p);

                    obj.con.Open();
                    com.ExecuteNonQuery();

                    MessageBox.Show("Inserted ID: " + p.Value);

                    LoadCustomers();
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

        // ================= UPDATE =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SetMode(FormMode.Update);
        }

        private void btnUpSave_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a row first!");
                return;
            }

            A6 obj = new A6();

            try
            {
                using (SqlCommand com = new SqlCommand("UpCustomer", obj.con))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@Cid", selectedId);
                    com.Parameters.AddWithValue("@CN", TbName.Text);
                    com.Parameters.AddWithValue("@CC", TbCon.Text);

                    obj.con.Open();
                    com.ExecuteNonQuery();

                    MessageBox.Show("Updated!");
                    LoadCustomers();
                }
            }
            catch (SqlException ex)   // 👈 PUT IT HERE
            {
                if (ex.Number == 2627)   // UNIQUE constraint or existing meta data headler
                    /*👉 ex.Number = SQL Server error 
                      👉 2627 = UNIQUE constraint violatio*/


                    MessageBox.Show("Contact already exists!");
                else
                    MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)   // optional general error
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                obj.con.Close();
            }

        }


        // ================= DELETE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a row first!");
                return;
            }

            A6 obj = new A6();

            try
            {
                using (SqlCommand com = new SqlCommand("DelCustomer", obj.con))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@Cid", selectedId);

                    obj.con.Open();
                    com.ExecuteNonQuery();

                    MessageBox.Show("Deleted!");

                    LoadCustomers();
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

        // ================= CANCEL =================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();

        }

        // ================= EXIT =================
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Form m = new Main_Form();
            m.ShowDialog();
            this.Close();
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{

        //}
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
                using (SqlCommand com = new SqlCommand("SearchCustomer", obj.con))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@keyword",tbSearch.Text);

                    obj.con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
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