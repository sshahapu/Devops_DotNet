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
    public partial class GenerateReports_Oper : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                messagediv.Visible = false;
                Button7.Enabled = false;

            }
        }

        AdminManager adm = new AdminManager();
        protected void Button5_Click(object sender, EventArgs e)
        {
            int patid = Convert.ToInt32(TextBox3.Text);
            DataSet ds = new DataSet();
            ds = adm.getpatdetails(patid);
            if (ds.Tables[0].Rows.Count > 0)
            {
                TextBox4.Text = ds.Tables[0].Rows[0][0].ToString();
                TextBox5.Text = ds.Tables[0].Rows[0][1].ToString();
                DropDownList1.SelectedValue = ds.Tables[0].Rows[0][2].ToString();
                Button7.Enabled = true;
            }
            else
            {
                TextBox4.Text = "";
                TextBox8.Text = "";
                TextBox5.Text = "";
                Button7.Enabled = false;
                messagediv.Visible = true;
                Lblmessge.Text = "Patient details not found";

            }


        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("Operatorhome.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {

                int patid = 0;
                patid = Convert.ToInt32(TextBox3.Text);
                if (TextBox3.Text == "")
                {
                    messagediv.Visible = true;
                    Lblmessge.Text = "Patient Id cannot be Null!";

                }
                else
                {
                    string test_name = "";
                    test_name = TextBox5.Text;
                    string description = "";
                    description = TextBox8.Text;
                    if (adm.Add_Patreports(patid, test_name, description))
                    {
                        messagediv.Visible = true;
                        Lblmessge.Text = "Patient details saved successully";
                        DropDownList2.SelectedValue = "--Select--";
                        TextBox8.Text = "";

                    }
                    else
                    {
                        messagediv.Visible = true;
                        Lblmessge.Text = "Please try again something went wrong";
                    }
                }
            }
            catch (Exception ex)
            {
                messagediv.Visible = true;
                Lblmessge.Text = "Please try again something went wrong";
            }



        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            messagediv.Visible = false;
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox8.Text = "";
            TextBox5.Text = "";
            Button7.Enabled = false;
        }

    }
}