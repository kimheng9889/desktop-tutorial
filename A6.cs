using System.Data.SqlClient;

class A6
{
    public SqlConnection con;

    public A6()
    {
        con = new SqlConnection(
            "Data Source=.;Initial Catalog=A6Y32026;Integrated Security=True;TrustServerCertificate=True"
        );
    }
}