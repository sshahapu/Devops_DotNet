using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class AdminDAL
    {
        SqlConnection dbcon;
        ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["T216ConnectionString"];
        string var;
        public string verifyLogin(string userId)
        {
           
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);
            
            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandText = "SP_Verify_Login";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@user_name";
            p1.Direction = ParameterDirection.Input;
            p1.Value = userId;
            cmd.Parameters.Add(p1);

            SqlDataReader sda = cmd.ExecuteReader();
            string paswrd=null;
            while (sda.Read())
            {
                 paswrd= sda[0].ToString();
            }

            dbcon.Close();
            return paswrd;
            
        }
        public Boolean Registr_pat(string patname,int age, string gender,string adress, long contno, string date, int room)
        {

            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandText = "Insert_pat_details";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@Pname";
            p2.Direction = ParameterDirection.Input;
            p2.Value = patname;
            cmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@age";
            p3.Direction = ParameterDirection.Input;
            p3.Value = age;
            p3.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@gender";
            p4.Direction = ParameterDirection.Input;
            p4.Value = gender;
            cmd.Parameters.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@adress";
            p5.Direction = ParameterDirection.Input;
            p5.Value = adress;
            cmd.Parameters.Add(p5);

            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@contactno";
            p6.Direction = ParameterDirection.Input;
            p6.Value = contno;
            p6.SqlDbType = SqlDbType.BigInt;
            cmd.Parameters.Add(p6);

            SqlParameter p7 = new SqlParameter();
            p7.ParameterName = "@Regdate";
            p7.Direction = ParameterDirection.Input;
            p7.Value = date;
            cmd.Parameters.Add(p7);

            SqlParameter p8 = new SqlParameter();
            p8.ParameterName = "@roomno";
            p8.Direction = ParameterDirection.Input;
            p8.Value = room;
            p8.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p8);
            
            

            int flag=cmd.ExecuteNonQuery();
            dbcon.Close();
            if (flag > 0)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }
        public Boolean Update_pat(int patid,string adress, long contno, int room)
        {
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);
            //SqlCommand cmd = new SqlCommand("update Patient_details set adress='" + adress + "',contactno='" + contno + "',roomno='" + room + "'where patid='" + patid + "'", dbcon);
           


            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandText = "SP_UpdateINPat";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@patid";
            p1.Direction = ParameterDirection.Input;
            p1.Value = patid;
            p1.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@patadress";
            p2.Direction = ParameterDirection.Input;
            p2.Value = adress;
            cmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@Patcont";
            p3.Direction = ParameterDirection.Input;
            p3.Value = contno;
            p3.SqlDbType = SqlDbType.BigInt;
            cmd.Parameters.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@room";
            p4.Direction = ParameterDirection.Input;
            p4.Value = room;
            p4.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p4);

            int flag = cmd.ExecuteNonQuery();
            dbcon.Close();
            if (flag != (-1))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public Boolean Registr_OutPat(string patname, int age, string gender, string docname, long contno, string date, string deprtment)
        {

            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandText = "Insert_outpat_details";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@Pname";
            p2.Direction = ParameterDirection.Input;
            p2.Value = patname;
            cmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@age";
            p3.Direction = ParameterDirection.Input;
            p3.Value = age;
            p3.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@gender";
            p4.Direction = ParameterDirection.Input;
            p4.Value = gender;
            cmd.Parameters.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@deprtmnt";
            p5.Direction = ParameterDirection.Input;
            p5.Value = deprtment;
            cmd.Parameters.Add(p5);

            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@contactno";
            p6.Direction = ParameterDirection.Input;
            p6.Value = contno;
            p6.SqlDbType = SqlDbType.BigInt;
            cmd.Parameters.Add(p6);

            SqlParameter p7 = new SqlParameter();
            p7.ParameterName = "@Regdate";
            p7.Direction = ParameterDirection.Input;
            p7.Value = date;
            cmd.Parameters.Add(p7);

            SqlParameter p8 = new SqlParameter();
            p8.ParameterName = "@docname";
            p8.Direction = ParameterDirection.Input;
            p8.Value = docname;
            
            cmd.Parameters.Add(p8);



            int flag = cmd.ExecuteNonQuery();
            dbcon.Close();
            if (flag > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataSet SearchINPatient(int patid)
        {
            DataSet PCdataset = new DataSet();
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_SearchINPatient";
            SqlParameter p = new SqlParameter(); 
            p.ParameterName = "@patid";
            p.Direction = ParameterDirection.Input;
            p.Value = patid;
            cmd.Parameters.Add(p);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(PCdataset);

            return PCdataset;

        }
        
        public DataSet SearchOutPatient(int patid)
        {
            DataSet PCdataset = new DataSet();
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_SearchOutPatient";
            SqlParameter p = new SqlParameter();
            p.ParameterName = "@patid";
            p.Direction = ParameterDirection.Input;
            p.Value = patid;
            cmd.Parameters.Add(p);


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(PCdataset);

            return PCdataset;

        }
        public Boolean deleteInPat(int patid)
        {
            DataSet PCdataset = new DataSet();
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_deleteinpat";
            SqlParameter p = new SqlParameter();
            p.ParameterName = "@patid";
            p.Direction = ParameterDirection.Input;
            p.Value = patid;
            cmd.Parameters.Add(p);


            int flag = cmd.ExecuteNonQuery();
            dbcon.Close();
            if (flag > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean deleteoutPat(int patid)
        {
            DataSet PCdataset = new DataSet();
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_deleteoutpat";
            SqlParameter p = new SqlParameter();
            p.ParameterName = "@patid";
            p.Direction = ParameterDirection.Input;
            p.Value = patid;
            cmd.Parameters.Add(p);


            int flag = cmd.ExecuteNonQuery();
            dbcon.Close();
            if (flag > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataSet DisplayAllInPat()
        {
            DataSet PCdataset = new DataSet();
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_DisplayallInpat";
            
            

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(PCdataset);

            return PCdataset;

        }
        public DataSet DisplayAllInPat_del()
        {
            DataSet PCdataset = new DataSet();
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_DisplayallInpat_del";



            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(PCdataset);

            return PCdataset;

        }
        public DataSet DisplayAlloutPat_del()
        {
            DataSet PCdataset = new DataSet();
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Displayalloutpat_del";



            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(PCdataset);

            return PCdataset;

        }
        public DataSet DisplayAllOutPat()
        {
            DataSet PCdataset = new DataSet();
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_DisplayallOutpat";



            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(PCdataset);

            return PCdataset;

        }
        public int get_billid()
        {
            DataSet PCdataset = new DataSet();
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_get_billid";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(PCdataset);
            int id=Convert.ToInt32(PCdataset.Tables[0].Rows[0][0]);
            return id;

        }
        public int get_patid()
        {
            DataSet PCdataset = new DataSet();
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_get_Patid";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(PCdataset);
            int id = Convert.ToInt32(PCdataset.Tables[0].Rows[0][0]);
            return id;
        }
        public int get_Doctid()
        {
            DataSet PCdataset = new DataSet();
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_get_Doctid";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(PCdataset);
            int id = Convert.ToInt32(PCdataset.Tables[0].Rows[0][0]);
            return id;
        }

        public DataSet getpatdetails(int patid)
        {
            DataSet PCdataset = new DataSet();
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_getpatdetails";
            SqlParameter p = new SqlParameter();
            p.ParameterName = "@patid";
            p.Direction = ParameterDirection.Input;
            p.Value = patid;
            cmd.Parameters.Add(p);


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(PCdataset);

            return PCdataset;

        }
        public DataSet getoutpatdetails(int patid)
        {
            DataSet PCdataset = new DataSet();
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_getoutpatdetails";
            SqlParameter p = new SqlParameter();
            p.ParameterName = "@patid";
            p.Direction = ParameterDirection.Input;
            p.Value = patid;
            cmd.Parameters.Add(p);


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(PCdataset);

            return PCdataset;
        }


        public Boolean save_billdetsils(string bill_date, int patid, string name, int age, string gender, string admn_date, string desch_date, string room_charge,string doct_fees,string patholgy,string miscelaouns,string total)
        {
          

            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandText = "sp_insert_billdetails";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@patid";
            p1.Direction = ParameterDirection.Input;
            p1.Value = patid;
            p1.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@pname";
            p2.Direction = ParameterDirection.Input;
            p2.Value = name;
            cmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@age";
            p3.Direction = ParameterDirection.Input;
            p3.Value = age;
            p3.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@gender";
            p4.Direction = ParameterDirection.Input;
            p4.Value = gender;
            cmd.Parameters.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@dischrd_date";
            p5.Direction = ParameterDirection.Input;
            p5.Value = desch_date;
            //p5.SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.Add(p5);

            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@admin_date";
            p6.Direction = ParameterDirection.Input;
            p6.Value = admn_date;
            
            cmd.Parameters.Add(p6);

            SqlParameter p7 = new SqlParameter();
            p7.ParameterName = "@room_charge";
            p7.Direction = ParameterDirection.Input;
            p7.Value = room_charge;
            cmd.Parameters.Add(p7);

            SqlParameter p8 = new SqlParameter();
            p8.ParameterName = "@doct_fees";
            p8.Direction = ParameterDirection.Input;
            p8.Value = doct_fees;
            cmd.Parameters.Add(p8);

            SqlParameter p9 = new SqlParameter();
            p9.ParameterName = "@pathology";
            p9.Direction = ParameterDirection.Input;
            p9.Value = patholgy;
            cmd.Parameters.Add(p9);

            SqlParameter p10 = new SqlParameter();
            p10.ParameterName = "@miscenoius";
            p10.Direction = ParameterDirection.Input;
            p10.Value = miscelaouns;
            cmd.Parameters.Add(p10);

            SqlParameter p11 = new SqlParameter();
            p11.ParameterName = "@total";
            p11.Direction = ParameterDirection.Input;
            p11.Value = total;

            cmd.Parameters.Add(p11);

            SqlParameter p12 = new SqlParameter();
            p12.ParameterName = "@bill_date";
            p12.Direction = ParameterDirection.Input;
            p12.Value = bill_date;
            cmd.Parameters.Add(p12);

            int flag = cmd.ExecuteNonQuery();
            dbcon.Close();
            if (flag > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean addOutPat_bills(string bill_date, int patid, string name, string doctname, string const_fee, string total)
        {
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandText = "sp_outPat_billdetails";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@patid";
            p1.Direction = ParameterDirection.Input;
            p1.Value = patid;
            p1.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@pname";
            p2.Direction = ParameterDirection.Input;
            p2.Value = name;
            cmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@doctrname";
            p3.Direction = ParameterDirection.Input;
            p3.Value = doctname;
            
            cmd.Parameters.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@const_fee";
            p4.Direction = ParameterDirection.Input;
            p4.Value = const_fee;
            cmd.Parameters.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@total";
            p5.Direction = ParameterDirection.Input;
            p5.Value = total;
            cmd.Parameters.Add(p5);

            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@billdate";
            p6.Direction = ParameterDirection.Input;
            p6.Value = bill_date;
            cmd.Parameters.Add(p6);

            int flag = cmd.ExecuteNonQuery();
            dbcon.Close();
            if (flag > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public Boolean Add_Patreports(int patid, string test_name, string description)
        {
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandText = "sp_patient_reports";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@patid";
            p1.Direction = ParameterDirection.Input;
            p1.Value = patid;
            p1.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@testname";
            p2.Direction = ParameterDirection.Input;
            p2.Value = test_name;
            cmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@description";
            p3.Direction = ParameterDirection.Input;
            p3.Value = description;

            cmd.Parameters.Add(p3);
            int flag = cmd.ExecuteNonQuery();
            dbcon.Close();
            if (flag > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public Boolean add_doct_details(string name, int age, string gender, string cont_number, string department)
        {
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandText = "sp_insert_doct_details";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@doc_name";
            p3.Direction = ParameterDirection.Input;
            p3.Value = name;
            cmd.Parameters.Add(p3);

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@doc_age";
            p1.Direction = ParameterDirection.Input;
            p1.Value = age;
            p1.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@ph_number";
            p2.Direction = ParameterDirection.Input;
            p2.Value = cont_number;
            cmd.Parameters.Add(p2);
            

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@department";
            p4.Direction = ParameterDirection.Input;
            p4.Value = department;
            cmd.Parameters.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@gender";
            p5.Direction = ParameterDirection.Input;
            p5.Value = gender;
            cmd.Parameters.Add(p5);

            

            int flag = cmd.ExecuteNonQuery();
            dbcon.Close();
            if (flag > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public DataSet get_doct_name(string department)
        {
            DataSet PCdataset = new DataSet();
            var = settings.ConnectionString;
            dbcon = new SqlConnection(var);

            dbcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_get_doct_name";
            SqlParameter p = new SqlParameter();
            p.ParameterName = "@department";
            p.Direction = ParameterDirection.Input;
            p.Value = department;
            cmd.Parameters.Add(p);


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(PCdataset);

            return PCdataset;

        }
        


    }
}
