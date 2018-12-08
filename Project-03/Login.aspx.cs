using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace Project_03
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = DESKTOP-VKU3EK5; integrated security = true; database = ExterminatorDB");
            SqlCommand cmd = null;
            //SqlDataReader rdr = null;

            try
            {
                conn.Open();

                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CustomerLogin";

                cmd.Parameters.Add("@Email", SqlDbType.Text);
                cmd.Parameters.Add("@Password", SqlDbType.Text);

                cmd.Parameters["@Email"].Value = TextBoxEmail.Text;
                cmd.Parameters["@Password"].Value = TextBoxPassword.Text;

                cmd.ExecuteNonQuery();

                int result;
                result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result == 1)
                {
                    Response.Redirect("~/CustomerPage.aspx");
                }
                else
                {
                    LabelMessage.Text = "Invalid Email or Password";
                }
            }
            catch (Exception ex)
            {
                LabelMessage.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}