using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADONETProjekt
{
    public partial class BazaDisconnected : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AdoNetConnectionString"].ToString());
            SqlCommand command = new SqlCommand("SELECT * FROM Student", connection);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(command);
            //otvara konekciju, sprema podatke u tablicu Emp i zatvara konekciju
            //nad tablicom Student možemo obavljati sve operacije koje želimo
            da.Fill(ds, "Student");

            //povezujemo grid i tablicu
            gvStudents.DataSource = ds.Tables["Student"];
            gvStudents.DataBind();
        }
    }
}