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
    public partial class InRegistration_Oper : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime dt = System.DateTime.Today;
            PId.Text = adm.get_patid().ToString();
            PId.Enabled = false;
            RegDate.Text = dt.Date.ToShortDateString();
            RegDate.Enabled = false;
            messagediv.Visible = false;

            try
            {
                int patid = 0;
                patid = Convert.ToInt32(Request.QueryString["patid"]);
                if (patid > 0)
                {
                    if (!IsPostBack)
                    {



                        // DataSet ds = new DataSet();

                        DataSet ds = adm.SearchINPatient(patid);
                        PId.Text = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        PId.Enabled = false;
                        PName.Text = Convert.ToString(ds.Tables[0].Rows[0][1]);
                        Ptage.Text = Convert.ToString(ds.Tables[0].Rows[0][2]);
                        PGender.SelectedValue = Convert.ToString(ds.Tables[0].Rows[0][3]);
                        Padress.Text = Convert.ToString(ds.Tables[0].Rows[0][4]);


                        PContact.Text = Convert.ToString(ds.Tables[0].Rows[0][5]);


                        RegDate.Text = Convert.ToString(ds.Tables[0].Rows[0][6]);

                        DropDownList1.SelectedValue = Convert.ToString(ds.Tables[0].Rows[0][7]);
                        PatRegistr.Text = "Save";
                        Button2.Text = "Back";
                        //Request.QueryString["patid"] = 0;
                        PName.Enabled = false;
                        Ptage.Enabled = false;
                        PGender.Enabled = false;

                    }

                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Placement Consultant added successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                String msg = "Unable to update data" + ex.Message;
                //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                string strScript = "<script>" + "alert('" + msg + "');";
                strScript += "</script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Startup", strScript);
            }

        }

        AdminManager adm = new AdminManager();
        protected void PatRegistr_Click(object sender, EventArgs e)
        {
            try
            {
                if (PatRegistr.Text == "Save")
                {
                    int patid = Convert.ToInt32(Request.QueryString["patid"]);
                    string adress = Padress.Text;
                    long contactno = Convert.ToInt64(PContact.Text);
                    int roomno = Convert.ToInt32(DropDownList1.SelectedValue);
                    if (adm.Update_pat(patid, adress, contactno, roomno))
                    {

                        messagediv.Visible = true;

                        Lblmessge.Text = "Patient details Updated successfully";
                        PId.Text = null;
                        PName.Text = null;
                        Ptage.Text = null;
                        PGender.SelectedValue = "--Select--";
                        Padress.Text = null;
                        PContact.Text = null;
                        DropDownList1.SelectedValue = roomno.ToString();
                        PatRegistr.Enabled = false;
                        //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                        //Response.Redirect("SearchInPatient.aspx");


                    }
                    else
                    {
                        messagediv.Visible = true;

                        Lblmessge.Text = "Patient Id already exists in the system";
                    }

                }
                else
                {

                    int patid = Convert.ToInt32(PId.Text);
                    string Pname = PName.Text;
                    int age = Convert.ToInt32(Ptage.Text);
                    string gender = PGender.SelectedValue;
                    string adress = Padress.Text;
                    long contactno = Convert.ToInt64(PContact.Text);
                    string Regdate = RegDate.Text;
                    int roomno = Convert.ToInt32(DropDownList1.SelectedValue);
                    if (adm.Registr_pat(Pname, age, gender, adress, contactno, Regdate, roomno))
                    {

                        messagediv.Visible = true;

                        Lblmessge.Text = "Patient details registered successfully";
                        PId.Text = (patid + 1).ToString();
                        PName.Text = null;
                        Ptage.Text = null;
                        PGender.SelectedValue = "--Select--";
                        Padress.Text = null;
                        PContact.Text = null;
                        DropDownList1.SelectedValue = roomno.ToString();

                    }
                    else
                    {
                        messagediv.Visible = true;

                        Lblmessge.Text = "Patient Id already exists in the system";
                    }

                }
            }
            catch (Exception ex)
            {
                messagediv.Visible = true;

                Lblmessge.Text = "Patient Id already exists in the system";
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Button2.Text == "Back")
            {
                Response.Redirect("SearchInPat_Oper.aspx");
            }
            else
            {
                Response.Redirect("Operatorhome.aspx");
            }
        }
        



    }
}