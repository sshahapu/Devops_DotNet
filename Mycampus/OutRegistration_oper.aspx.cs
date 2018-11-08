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
    public partial class OutRegistration_oper : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DateTime dt = System.DateTime.Today;
                PId.Text = adm.get_patid().ToString();
                PId.Enabled = false;
                regdate.Text = dt.Date.ToShortDateString();
                regdate.Enabled = false;
                messagediv.Visible = false;
                SqlConnection dbcon;
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["T216ConnectionString"];
                string var;
                var = settings.ConnectionString;
                dbcon = new SqlConnection(var);

                dbcon.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT [Department] FROM [Doctor_details]", dbcon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                dbcon.Close();


                if (ds.Tables[0].Rows.Count > 0)
                {

                    DropDownList1.DataSource = ds;

                    DropDownList1.DataBind();

                }

                DropDownList1.Items.Insert(0, new ListItem("--Select--"));
            }

        }
        AdminManager adm = new AdminManager();
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                int patid = Convert.ToInt32(PId.Text);
                string Pname = PName.Text;
                int age = Convert.ToInt32(Ptage.Text);
                string gender = PGender.SelectedValue;
                string docname = DropDownList2.SelectedValue;
                long contactno = Convert.ToInt64(PContact.Text);
                string Regdate = regdate.Text;
                string deprtmnt = DropDownList1.SelectedValue;
                if (adm.Registr_OutPat(Pname, age, gender, docname, contactno, Regdate, deprtmnt))
                {

                    messagediv.Visible = true;

                    Lblmessge.Text = "Patient details registered successfully";
                    PId.Text = (patid + 1).ToString();
                    PName.Text = null;
                    Ptage.Text = null;
                    PGender.SelectedValue = "--Select--";
                    DropDownList2.SelectedValue = docname;
                    PContact.Text = null;
                    //DropDownList1.SelectedValue = "--Select--";

                }
                else
                {
                    messagediv.Visible = true;

                    Lblmessge.Text = "Patient details already exists in the system";
                }

            }
            catch (Exception ex)
            {
                messagediv.Visible = true;

                Lblmessge.Text = "something went wrong patient details cannot be added";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Adminhome.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //DropDownList2.DataSourceID = SqlDataSource2;
            //SqlDataSource2.DeleteParameters
            string department = "";
            department = DropDownList1.SelectedValue;
            DataSet ds = new DataSet();
            ds = adm.get_doct_name(department);
            if (ds.Tables[0].Rows.Count > 0)
            {

                DropDownList2.DataSource = ds;
                DropDownList2.DataBind();

            }


        }

    }
}