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
    public partial class ExterminatorCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
            /*TextBoxName.Text = GridViewPest.SelectedRow.Cells[2].Text;
            TextBoxPrice.Text = GridViewPest.SelectedRow.Cells[3].Text;
            LabelMessage.Text = "You chose shipper " + GridViewShippers.SelectedRow.Cells[1].Text;
            ButtonUpdate.Enabled = true;*/
        }


        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = DESKTOP-VKU3EK5; integrated security = true; database = ExterminatorDB");
            SqlDataAdapter da = null;
            DataSet ds = null;
            DataTable dt = null;
            SqlCommand cmd = null;
            string sqlsel = "SELECT * FROM Pest";
            string sqlins = "INSERT INTO Pest VALUES (@Name, @Price, @Picture)";

            try
            {
                // conn.Open();  SqlDataAdapter opens connection by itself

                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sqlsel, conn);

                ds = new DataSet();
                da.Fill(ds, "PestList");

                dt = ds.Tables["PestList"];

                DataRow newrow = dt.NewRow();
                newrow["Name"] = TextBoxName.Text;
                newrow["Price"] = TextBoxPrice.Text;
                newrow["Picture"] = TextBoxPicture.Text;
                dt.Rows.Add(newrow);

                cmd = new SqlCommand(sqlins, conn);
                cmd.Parameters.Add("@Name", SqlDbType.Text, 50, "Name");
                cmd.Parameters.Add("@Price", SqlDbType.Int, 50, "Price");
                cmd.Parameters.Add("@Picture", SqlDbType.Text, 50, "Picture");

                da.InsertCommand = cmd;
                da.Update(ds, "PestList");

                LabelMessage.Text = "New Pest added";

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