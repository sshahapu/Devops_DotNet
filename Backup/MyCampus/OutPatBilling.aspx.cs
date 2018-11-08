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
using Microsoft.Office.Interop.Word;
using System.ComponentModel.Design;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;



namespace MyCampus
{
    public partial class OutPatBilling : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                messagediv.Visible = false;
                TextBox1.Text = adm.get_billid().ToString();
                DateTime dt = System.DateTime.Today;

                TextBox2.Text = dt.Date.ToShortDateString();
                TextBox2.Enabled = false;
                TextBox1.Enabled = false;
                
                TextBox12.Text = "0";
                
                TextBox13.Text = "0";
                Button3.Enabled = false;
            }
        }
        AdminManager adm = new AdminManager();

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                TextBox13.Text = TextBox12.Text;
            }
            catch (Exception ex)
            {
                messagediv.Visible = true;
                Lblmessge.Text = "Something went wrong please check the values entered";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Adminhome.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox12.Text = "0";
            TextBox10.Text = "";
            TextBox13.Text = "0";
            TextBox1.Text = adm.get_billid().ToString();
            messagediv.Visible = false;
            TextBox3.Enabled = true;
            Button3.Enabled = false;
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {

                string bill_date = "";
                bill_date = TextBox2.Text;
                int patid = 0;
                patid = Convert.ToInt32(TextBox3.Text);
                string name = "";
                name = TextBox4.Text;
                string doctname = "";
                doctname = TextBox10.Text;
                string const_fee = "";
                const_fee = TextBox12.Text;
                string total = "";
                total = TextBox13.Text;
                if (adm.addOutPat_bills(bill_date,patid,name,doctname,const_fee,total))
                {
                    messagediv.Visible = true;
                    Lblmessge.Text = "Out Patient Id ("+patid+") bill details saved successfully!";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox12.Text = "0";
                    TextBox10.Text = "";
                    TextBox13.Text = "0";
                    TextBox1.Text = adm.get_billid().ToString();
                    TextBox3.Enabled = true;
                    
                }

            }
            catch (Exception ex)
            {
                messagediv.Visible = true;
                Lblmessge.Text = "Something went wrong please check the values entered";
            }


        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int patid = Convert.ToInt32(TextBox3.Text);
            DataSet ds = new DataSet();
            ds = adm.getoutpatdetails(patid);
            if (ds.Tables[0].Rows.Count > 0)
            {
                TextBox4.Text = ds.Tables[0].Rows[0][0].ToString();
                TextBox10.Text = ds.Tables[0].Rows[0][1].ToString();
                TextBox3.Enabled = false;
                Button3.Enabled = true;
                messagediv.Visible = false;
                Button6.Enabled = true;
            }
            else
            {
                messagediv.Visible = true;
                Lblmessge.Text = "Out Patient Id ("+patid+") records not found";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                //Create an instance for word app
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                //Set animation status for word application
                //winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.
                winword.Visible =false;

                //Create a missing variable for missing value
                object missing = System.Reflection.Missing.Value;

                //Create a new document
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                //Add header into the document
                foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                {
                    //Get the header range and add the header details.
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                    headerRange.Font.Size = 10;
                    headerRange.Text = "";
                }

                //Add the footers into the document
                foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                {
                    //Get the footer range and add the footer details.
                    Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                    footerRange.Font.Size = 10;
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    footerRange.Text = "======================================================";
                }

                //adding text to document
                document.Content.SetRange(0, 0);
               
                document.Content.Text = "" + Environment.NewLine;

                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Heading 2";
                para1.Range.set_Style(ref styleHeading1);
                para1.Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight;
                para1.Range.Font.Size = 30;
                para1.Range.Text = "MyHospital";
                para1.Range.InsertParagraphAfter();

                Microsoft.Office.Interop.Word.Paragraph para13 = document.Content.Paragraphs.Add(ref missing);
                //object styleHeading10 = "Heading 2";
                //para1.Range.set_Style(ref styleHeading10);
                para13.Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                para13.Range.Font.Size = 10;
                para13.Range.Text = "Near State bank of India,Mangloore. Tel:(+91)0806213232 ";

                para1.Range.InsertParagraphAfter();

                //Add paragraph with Heading 1 style
                Microsoft.Office.Interop.Word.Paragraph para3 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading3 = "Heading 2";
                para3.Range.set_Style(ref styleHeading3);
                para3.Range.Text = "============================================================";
                para3.Range.InsertParagraphAfter();

                //Add paragraph with Heading 2 style
                Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading2 = "Heading 2";
                para2.Range.set_Style(ref styleHeading2);
                para2.Range.Text = "Patient Details";
                para2.Range.InsertParagraphAfter();

                Microsoft.Office.Interop.Word.Paragraph para4 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading4 = "Heading 3";
                para4.Range.set_Style(ref styleHeading4);
                para4.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                para4.Range.Text = "Bill ID : "+TextBox1.Text+"                                                                          Bill Date : "+TextBox2.Text+"";
                para4.Range.InsertParagraphAfter();

                Microsoft.Office.Interop.Word.Paragraph para5 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading5 = "Heading 2";
                para5.Range.set_Style(ref styleHeading5);
                para5.Range.Font.Size=10;
                para5.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                para5.Range.Text = "Patient ID : " + TextBox3.Text + "                                                                                     Patient Name : " + TextBox4.Text + "";
                para5.Range.InsertParagraphAfter();

                Microsoft.Office.Interop.Word.Paragraph para9 = document.Content.Paragraphs.Add(ref missing);
                //object styleHeading5 = "Heading 2";
                para9.Range.set_Style(ref styleHeading5);
                para9.Range.Font.Size = 10;
                para9.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                para9.Range.Text = "doctor Name : " + TextBox10.Text + "";
                para9.Range.InsertParagraphAfter();

                Microsoft.Office.Interop.Word.Paragraph para6 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading6 = "Heading 2";
                para6.Range.set_Style(ref styleHeading6);
                para6.Range.Text = "----------------------------------------------------------------------------------------------------------";
                para6.Range.InsertParagraphAfter();

                Microsoft.Office.Interop.Word.Paragraph para7 = document.Content.Paragraphs.Add(ref missing);
                //object styleHeading10 = "Heading 2";
                para7.Range.set_Style(ref styleHeading2);
                para7.Range.Text = "Charge Details";
                para7.Range.InsertParagraphAfter();

                Microsoft.Office.Interop.Word.Paragraph para8 = document.Content.Paragraphs.Add(ref missing);
                //object styleHeading4 = "Heading 3";
                para8.Range.set_Style(ref styleHeading4);
                para8.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                para8.Range.Text = "Consultation amount                      : " + TextBox12.Text + "";
                para8.Range.InsertParagraphAfter();

                Microsoft.Office.Interop.Word.Paragraph para12 = document.Content.Paragraphs.Add(ref missing);
                //object styleHeading5 = "Heading 2";
                para12.Range.set_Style(ref styleHeading5);
                para12.Range.Font.Size = 10;
                para12.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorRed;
                para12.Range.Text = "Total                                                            : " + TextBox13.Text + "";
                para12.Range.InsertParagraphAfter();

                Microsoft.Office.Interop.Word.Paragraph para14 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading13 = "Heading 2";
                para14.Range.set_Style(ref styleHeading13);
                para14.Range.Text = "============================================================";
                para14.Range.InsertParagraphAfter();

                
                //Save the document
                object filename = @"D:\Patient_"+TextBox3.Text+"_OUT_Bill.docx";
                document.SaveAs(ref filename);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                messagediv.Visible = true;
                Lblmessge.Text = "In Patient Id (" + TextBox3.Text + ") bill generated and saved successfully";
                        
                //MessageBox.Show("Document created successfully !");
                //document.Open = @"D:\temp1.docx";

            }
            catch (Exception ex)
            {
                messagediv.Visible = true;
                Lblmessge.Text = " " + ex.Message + "";
                 
            }


        
        }
    }
}