using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace MyCampus
{
    public partial class Register_doct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox3.Text = adm.get_Doctid().ToString();
            TextBox3.Enabled = false;
            messagediv.Visible = false;
            Button2.Enabled = true;


        }
        AdminManager adm = new AdminManager();

        protected void Button2_Click(object sender, EventArgs e)
        {
            string name = "";
            name = TextBox4.Text;
            int age = 0;
            age = Convert.ToInt32(TextBox5.Text);
            string gender = "";
            gender = DropDownList1.SelectedValue;
            string cont_number = "";
            cont_number = TextBox7.Text;
            string department = DropDownList2.SelectedValue;
            if (adm.add_doct_details(name, age, gender, cont_number, department))
            {
                messagediv.Visible = true;
                Lblmessge.Text = "Doctor details registered successfully!";
                Button2.Enabled = false;

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Adminhome.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register_doct.aspx");
        }
    }

}