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
    public partial class ExterminatorPage : System.Web.UI.Page
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
            /*TextBoxCompany.Text = GridViewShippers.SelectedRow.Cells[2].Text;
            TextBoxPhone.Text = GridViewShippers.SelectedRow.Cells[3].Text;
            LabelMessages.Text = "You chose shipper " + GridViewShippers.SelectedRow.Cells[1].Text;
            ButtonUpdate.Enabled = true;*/
        }
    }
}