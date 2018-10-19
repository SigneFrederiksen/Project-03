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
    public partial class ExterminatorDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UpdateGridview();
                ButtonDelete.Enabled = false;
            }

            DropDownListPest.AutoPostBack = true;
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

                DropDownListPest.DataSource = dt;
                DropDownListPest.DataTextField = "Name";
                DropDownListPest.DataValueField = "PestID";
                DropDownListPest.DataBind();
                DropDownListPest.Items.Insert(0, "Select a Pest");
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



        protected void DropDownListPest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListPest.SelectedIndex != 0)
            {
                LabelMessage.Text = "You chose PestID: " + DropDownListPest.SelectedValue;
                ButtonDelete.Enabled = true;
            }
            else
            {
                LabelMessage.Text = "You chose none";
                ButtonDelete.Enabled = false;
            }
        }


        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = DESKTOP-VKU3EK5; integrated security = true; database = ExterminatorDB");
            SqlDataAdapter da = null;
            SqlCommandBuilder cb = null;
            DataSet ds = null;
            DataTable dt = null;
            string sqlsel = "SELECT * FROM Pest";


            try
            {
                // conn.Open();  SqlDataAdapter opens connection by itself

                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sqlsel, conn);

                cb = new SqlCommandBuilder(da);

                ds = new DataSet();
                da.Fill(ds, "PestList");

                dt = ds.Tables["PestList"];

                foreach (DataRow myrow in dt.Select("PestID =" + Convert.ToInt32(DropDownListPest.SelectedValue)))
                {
                    myrow.Delete();
                }

                da.Update(ds, "PestList");

                LabelMessage.Text = "PestID: " + DropDownListPest.SelectedValue + " deleted";
                ButtonDelete.Enabled = false;

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

        protected void GridViewPest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}