using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;

namespace MyHospital
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DropDownList1.Focus();
            if (!IsPostBack)
            {
                if (Session["Role"] != null)
                {
                    if ((Session["Role"].ToString()).Equals("Admin"))
                    {
                        Response.Redirect("Adminhome.aspx");

                    }
                    else if ((Session["Role"].ToString()).Equals("Operator"))
                    {
                        Response.Redirect("Operatorhome.aspx");

                    }

                }
                else
                {
                    Session.Abandon();
                }
            }
            
                
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                
                string username = DropDownList1.SelectedValue;
                string password = txtPassword.Text;
                AdminManager adm = new AdminManager();
               string paswrd = adm.virifyLoginBLL(username);
               
                if (password==paswrd && username == "Admin")
                {
                    Session.Add("Role", username);
                    Response.Redirect("Adminhome.aspx");
                }
                else if (password==paswrd && username == "Operator")
                {
                    Session.Add("Role", username);
                    Response.Redirect("Operatorhome.aspx");
                }
                else
                {
                    Errormassage.Visible = true;
                    Errormassage.Text = " Invalid Password";
                }

            }
            catch(Exception ex)
            {

            }
        
        }
    }
}