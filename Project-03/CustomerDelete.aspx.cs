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
    public partial class CustomerDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ButtonDelete.Enabled = false;
                UpdateGridView();
            }

            DropDownListDelete.AutoPostBack = true;
        }

        public void UpdateGridView()
        {
            SqlConnection conn = new SqlConnection(@"data source = DESKTOP-VKU3EK5; integrated security = true; database = ExterminatorDB");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            string sqlsel = "SELECT Request.RequestID, Customer.CustomerID, Customer.Firstname, Customer.Lastname, Pest.PestID, Pest.Name, Request.Date " +
                            "FROM Request " +
                            "INNER JOIN Customer ON Request.CustomerID = Customer.CustomerID " +
                            "INNER JOIN Pest ON Request.PestID = Pest.PestID";
            //string sqlsel = "SELECT * FROM Request";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlsel, conn);

                rdr = cmd.ExecuteReader();
                GridViewRequest.DataSource = rdr;
                GridViewRequest.DataBind();

                rdr.Close();
                rdr = cmd.ExecuteReader();

                DropDownListDelete.DataSource = rdr;
                DropDownListDelete.DataTextField = "RequestID";
                DropDownListDelete.DataValueField = "RequestID";
                DropDownListDelete.DataBind();
                DropDownListDelete.Items.Insert(0, "Select a Request");
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

        protected void DropDownListDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListDelete.SelectedIndex != 0)
            {
                LabelMessage.Text = "You chose RequestID: " + DropDownListDelete.SelectedValue;
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
            SqlCommand cmd = null;
            string sqlsel = "DELETE FROM Request WHERE RequestID = @RequestID";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlsel, conn);

                cmd.Parameters.Add("@RequestID", SqlDbType.Int);

                cmd.Parameters["@RequestID"].Value = Convert.ToInt32(DropDownListDelete.SelectedValue);

                cmd.ExecuteNonQuery();

                LabelMessage.Text = "Request " + DropDownListDelete.SelectedValue + " deleted";
                UpdateGridView();
                ButtonDelete.Enabled = false;
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