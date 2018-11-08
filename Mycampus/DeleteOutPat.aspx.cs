using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace MyCampus
{
    public partial class DeleteOutPat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvbind();
                messagediv.Visible = false;
            }

            SqlDataAdapter da = new SqlDataAdapter();

            DataSet ds = new DataSet();
            ds = adm.DisplayAlloutPat_del();



            //ds = pcObjforbll.DisplayGvbind();

            if (ds.Tables[0].Rows.Count > 0)
            {

                GridView2.DataSource = ds;

                GridView2.DataBind();

            }
            else
            {
                messagediv.Visible = true;
                Lblmessge.Text = "No records found!";


            }
        }
        AdminManager adm = new AdminManager();
        protected void grdApprove_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            gvbind();
        }
        protected void gvbind()
        {
            messagediv.Visible = false;
            SqlDataAdapter da = new SqlDataAdapter();

            DataSet ds = new DataSet();
            ds = adm.DisplayAlloutPat_del();

            //ds = pcObjforbll.DisplayGvbind();

            if (ds.Tables[0].Rows.Count > 0)
            {

                GridView2.DataSource = ds;

                GridView2.DataBind();

            }
            else
            {
                messagediv.Visible = true;
                Lblmessge.Text = "no records deleted.";


            }

        }
        protected void deleteRow(object sender, GridViewDeleteEventArgs e)       //function to delete selected row
        {
            try
            {
                GridViewRow row = (GridViewRow)GridView2.Rows[e.RowIndex];

                int patid = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());

                if (adm.deleteoutPat(patid))
                {
                    messagediv.Visible = true;
                    Lblmessge.Text = "In Patient Id (" + patid + ") deleted successfully!";
                    gvbind();
                }
                else
                {
                    gvbind();
                }
            }
            catch (Exception ex)
            {
                messagediv.Visible = true;
                Lblmessge.Text = "Something went wrong please try again";

            }

        }

        protected void data_bound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    LinkButton l = (LinkButton)e.Row.FindControl("LinkButton1");
                    l.Attributes.Add("onclick", "javascript:return " +
                    "confirm('Are you sure you want to delete Patient records " +
                    DataBinder.Eval(e.Row.DataItem, "patid") + "')");
                }
            }
            catch (Exception ex)
            {
                messagediv.Visible = true;
                Lblmessge.Text = "Something went wrong please try again";

            }
        }

        
        
    }
}