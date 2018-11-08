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

namespace MyHospital
{
    public partial class SearchInPatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvbind();
            }

            Grdview.Visible = true;
            Label3.Visible = false; 
            
            SqlDataAdapter da = new SqlDataAdapter();

            DataSet ds = new DataSet();
            ds = adm.DisplayAllInPat();
            

            
            //ds = pcObjforbll.DisplayGvbind();

            if (ds.Tables[0].Rows.Count > 0)
            {

                Grdview.DataSource = ds;

                Grdview.DataBind();

            }
            else
            {
                //MessageBox.Show("No records found", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //String msg = "No records found";

                //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);


            }
        }
        AdminManager adm = new AdminManager();
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
               
            int patid=Convert.ToInt32( PID.Text);
            
            DataSet ds= adm.SearchINPatient(patid);
                if (Grdview.Visible == true)
                {
                    GridView2.Visible = true;
                    Grdview.Visible = false;
                }
                

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Label3.Visible = false;
                    GridView2.DataSource = ds;

                    GridView2.DataBind();
                    GridView2.Visible = true;

                }
                else
                {
                    Label3.Visible = true;
                    Label3.Text = "No Records found";
                    GridView2.Visible = false;

                }
            }
            catch (Exception ex)
            {
                
            }

        }

        protected void grdApprove_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Grdview.PageIndex = e.NewPageIndex;
            gvbind();
        }
        protected void gvbind()
        {

            SqlDataAdapter da = new SqlDataAdapter();

            DataSet ds = new DataSet();
            ds = adm.DisplayAllInPat();
            

            

            
            //ds = pcObjforbll.DisplayGvbind();

            if (ds.Tables[0].Rows.Count > 0)
            {

                Grdview.DataSource = ds;

                Grdview.DataBind();

            }
            else
            {
                MessageBox.Show("No records found", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //String msg = "No records found";

                //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);


            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchInPatient.aspx"); 
        }

        
    
    }
    }
