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
    public partial class ExterminatorUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                ButtonUpdate.Enabled = false;
            }

            UpdateGridview();
        }


        public void UpdateGridview()
        {
            SqlConnection conn = new SqlConnection(@"data source = DESKTOP-VKU3EK5; integrated security = true; database = ExterminatorDB");
            SqlDataAdapter da = null;
            DataSet ds = null;
            DataTable dt = null;
            string sqlsel = "SELECT * FROM Pest";

            try
            {
                // conn.Open();  SqlDataAdapter opens connection by itself

                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sqlsel, conn);

                ds = new DataSet();
                da.Fill(ds, "PestList");

                dt = ds.Tables["PestList"];

                GridViewPest.DataSource = dt;
                GridViewPest.DataBind();

            }
            catch (Exception ex)
            {
                LabelMessage.Text = ex.Message;
            }
            finally
            {
                conn.Close();  // SqlDataAdapter closes connection by itself; but can fail in case of errors
            }
        }


        protected void GridViewPest_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxName.Text = GridViewPest.SelectedRow.Cells[2].Text;
            TextBoxPrice.Text = GridViewPest.SelectedRow.Cells[3].Text;
            TextBoxPicture.Text = GridViewPest.SelectedRow.Cells[4].Text;
            LabelMessage.Text = "You chose PestID: " + GridViewPest.SelectedRow.Cells[1].Text;
            ButtonUpdate.Enabled = true;
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = DESKTOP-VKU3EK5; integrated security = true; database = ExterminatorDB");
            SqlDataAdapter da = null;
            DataSet ds = null;
            DataTable dt = null;
            SqlCommand cmd = null;
            string sqlsel = "SELECT * FROM Pest";
            string sqlupd = "UPDATE Pest set Name = @Name, Price = @Price, Picture = @Picture where PestID = @PestID";

            try
            {
                // conn.Open();  SqlDataAdapter opens connection by itself

                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sqlsel, conn);

                ds = new DataSet();
                da.Fill(ds, "PestList");

                dt = ds.Tables["PestList"];

                int tableindex = GridViewPest.SelectedIndex;
                dt.Rows[tableindex]["Name"] = TextBoxName.Text;
                dt.Rows[tableindex]["Price"] = TextBoxPrice.Text;
                dt.Rows[tableindex]["Picture"] = TextBoxPicture.Text;


                cmd = new SqlCommand(sqlupd, conn);
                cmd.Parameters.Add("@Name", SqlDbType.Text, 50, "Name");
                cmd.Parameters.Add("@Price", SqlDbType.Int, 50, "Price");
                cmd.Parameters.Add("@Picture", SqlDbType.Text, 50, "Picture");
                SqlParameter parm = cmd.Parameters.Add("@PestID", SqlDbType.Int, 4, "PestID");
                parm.SourceVersion = DataRowVersion.Original; // Good habit if someone changes the primary key

                da.UpdateCommand = cmd;
                da.Update(ds, "PestList");

                LabelMessage.Text = "Update of PestID: " + GridViewPest.SelectedRow.Cells[1].Text;

            }
            catch (Exception ex)
            {
                LabelMessage.Text = ex.Message;
            }
            finally
            {
                conn.Close();  // SqlDataAdapter closes connection by itself; but can fail in case of errors
            }

            UpdateGridview();
        }
    }
}