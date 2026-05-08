using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Form m = new Main_Form();
            m.ShowDialog();
            this.Close();
        }

        [Obsolete]
        //private void Form8_Load(object sender, EventArgs e)
        //{
        //    A6 obj = new A6();
        //    SqlCommand com = new SqlCommand("DashBoard", obj.con);
        //    com.CommandType = CommandType.StoredProcedure;
        //    com.Parameters.Add("@ns", SqlDbType.Int).Direction = ParameterDirection.Output;
        //    com.Parameters.Add("@ts", SqlDbType.Money).Direction = ParameterDirection.Output;
        //    com.ExecuteNonQuery();
        //    var ns = int.Parse(com.Parameters["@ns"].Value.ToString());
        //    var ts = double.Parse(com.Parameters["@ts"].Value.ToString());
        //    tbNumSt.Text = ns.ToString();
        //    tbTotalSa.Text = ns.ToString();
        //    com.Dispose();
        //}


        private void Form8_Load(object sender, EventArgs e)
        {
            A6 obj = new A6();

            try
            {
                obj.con.Open();
                using (SqlCommand com = new SqlCommand("Dashboard", obj.con))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.Add("@ns", SqlDbType.Int).Direction = ParameterDirection.Output;
                    com.Parameters.Add("@ts", SqlDbType.Money).Direction = ParameterDirection.Output;
                    com.Parameters.Add("@np", SqlDbType.Int).Direction = ParameterDirection.Output;
                    com.Parameters.Add("@tq", SqlDbType.Int).Direction = ParameterDirection.Output;
                    com.Parameters.Add("@gt", SqlDbType.Decimal).Direction = ParameterDirection.Output;
                    com.Parameters["@gt"].Precision = 18;
                    com.Parameters["@gt"].Scale = 2;
                    com.Parameters.Add("@nsu", SqlDbType.Int).Direction = ParameterDirection.Output;
                    com.Parameters.Add("@nc", SqlDbType.Int).Direction = ParameterDirection.Output;
                    com.ExecuteNonQuery();

                    int ns = com.Parameters["@ns"].Value != DBNull.Value
                                ? Convert.ToInt32(com.Parameters["@ns"].Value)
                                : 0;
                    decimal ts = com.Parameters["@ts"].Value != DBNull.Value
                                ? Convert.ToDecimal(com.Parameters["@ts"].Value)
                                : 0;
                    int np = com.Parameters["@np"].Value != DBNull.Value
                                       ? Convert.ToInt32(com.Parameters["@np"].Value)
                                       : 0;
                    int tq = com.Parameters["@tq"].Value != DBNull.Value
                                        ? Convert.ToInt32(com.Parameters["@tq"].Value)
                                        : 0;
                    decimal gt = com.Parameters["@gt"].Value != DBNull.Value
                                        ? Convert.ToDecimal(com.Parameters["@gt"].Value)
                                        : 0;
                    var nsu = int.Parse(com.Parameters["@nsu"].Value.ToString());
                    var nc = int.Parse(com.Parameters["@nc"].Value.ToString());


                    tbNumSt.Text = ns.ToString();          // Number of Staff
                    tbTotalSa.Text = ts.ToString("N2");    // Total Salary
                    tbNumOfPro.Text = np.ToString();   // Number of Products
                    tbTotalQty.Text = tq.ToString();       // Optional
                    tbGrandTotal.Text = gt.ToString("N2");
                    tbNumOfSup.Text = nsu.ToString();
                    tbNumOfCus.Text = ns.ToString();
                    com.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (obj.con.State == ConnectionState.Open)
                    obj.con.Close();
            }
        }

        private void tbSuo_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
