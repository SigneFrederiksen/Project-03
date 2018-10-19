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
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DropdownListZipSelector();
        }

        /*public void DropdownListZipSelector()
        {
            SqlConnection conn = new SqlConnection(@"data source = DESKTOP-VKU3EK5; integrated security = true; database = ExterminatorDB");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            string sqlsel = "SELECT * FROM Zipcode";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlsel, conn);

                rdr = cmd.ExecuteReader();

                DropDownListZip.DataSource = rdr;

                DropDownListZip.DataTextField = "Zip";
                DropDownListZip.DataValueField = "ZipcodeID";
                DropDownListZip.DataBind();
                DropDownListZip.Items.Insert(0, "Select a Zipcode");
            }
            catch (Exception ex)
            {
                LabelMessage.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }*/


        protected void ButtonSignup_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = DESKTOP-VKU3EK5; integrated security = true; database = ExterminatorDB");
            SqlCommand cmd = null;
            string sqlsel = "INSERT INTO Customer VALUES (@ZipcodeID, @Firstname, @Lastname, @Street, @Email, @Password)";
            
            //string sqlsel = "INSERT INTO [Customer] (@ZipcodeID, @Firstname, @Lastname, @Street, @Email, @Password)" +
            //"SELECT ZipcodeID FROM Zipcode WHERE ZipcodeID = @ZipcodeID";          

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlsel, conn);

                //cmd.Parameters.Add("@ZipcodeID", SqlDbType.Int);
                cmd.Parameters.Add("@ZipcodeID", SqlDbType.Int);
                cmd.Parameters.Add("@Firstname", SqlDbType.Text);
                cmd.Parameters.Add("@Lastname", SqlDbType.Text);
                cmd.Parameters.Add("@Street", SqlDbType.Text);
                cmd.Parameters.Add("@Email", SqlDbType.Text);
                cmd.Parameters.Add("@Password", SqlDbType.Text);

                //cmd.Parameters["@ZipcodeID"].Value = Convert.ToInt32(DropDownListZip.SelectedValue);
                cmd.Parameters["@ZipcodeID"].Value = Convert.ToInt32(TextBoxZip.Text);
                cmd.Parameters["@Firstname"].Value = TextBoxFirstname.Text;
                cmd.Parameters["@Lastname"].Value = TextBoxLastname.Text;
                cmd.Parameters["@Street"].Value = TextBoxStreet.Text;
                cmd.Parameters["@Email"].Value = TextBoxEmail.Text;
                cmd.Parameters["@Password"].Value = TextBoxPassword.Text;

                cmd.ExecuteNonQuery();

                LabelMessage.Text = "Succes! - Thank you for signing up.";
                //DropdownListZipSelector();
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