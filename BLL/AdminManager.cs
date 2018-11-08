using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class AdminManager
    {
        AdminDAL admndal = new AdminDAL();
        public string virifyLoginBLL(string userid)
        {
           
            return admndal.verifyLogin(userid);
           
        }


        public Boolean Registr_pat( string patname, int age, string gender, string adress, long contno, string date, int room)
        {

            return admndal.Registr_pat(patname,  age,  gender,  adress, contno,  date,  room);
        }

        public Boolean Registr_OutPat(string patname, int age, string gender, string docname, long contno, string date, string deprtment)
        {
            return admndal.Registr_OutPat(patname, age, gender, docname, contno, date,deprtment);
        
        }
        public DataSet SearchINPatient(int patid)
        {
            return admndal.SearchINPatient(patid);
        }
        
        public DataSet SearchOutPatient(int patid)
        {
            return admndal.SearchOutPatient(patid);
        }
        public DataSet DisplayAllInPat()
        {
            return admndal.DisplayAllInPat();
        }
        public DataSet DisplayAllInPat_del()
        {
            return admndal.DisplayAllInPat_del();
        }
        public Boolean deleteInPat(int patid)
        {
            return admndal.deleteInPat(patid);
        }
        public DataSet DisplayAlloutPat_del()
        {
            return admndal.DisplayAlloutPat_del();
        }
        public Boolean deleteoutPat(int patid)
        {
            return admndal.deleteoutPat(patid);
        }
        public DataSet DisplayAllOutPat()
        {
            return admndal.DisplayAllOutPat();
        }
        public Boolean Update_pat(int patid, string adress, long contno, int room)
        {
            return admndal.Update_pat(patid, adress, contno, room);
        }
       public Boolean add_doct_details(string name,int age, string gender,string cont_number, string department)
       {
           return admndal.add_doct_details(name, age, gender, cont_number, department);
       }

        public int get_billid()
        {
            return admndal.get_billid();

        }
        public int get_patid()
        {
            return admndal.get_patid();
        }
        public int get_Doctid()
        {
            return admndal.get_Doctid();
        }
        public DataSet getpatdetails(int patid)
        {
            return admndal.getpatdetails(patid);

        }
        public DataSet getoutpatdetails(int patid)
        {
            return admndal.getoutpatdetails(patid);

        }
        public Boolean save_billdetsils(string bill_date, int patid, string name, int age, string gender, string reg_date, string desch_date, string room_charge,string doct_fees,string patholgy,string miscelaouns,string total)
        {
            return admndal.save_billdetsils(bill_date, patid, name, age, gender, reg_date, desch_date, room_charge, doct_fees, patholgy, miscelaouns, total);
        }
        public Boolean addOutPat_bills(string bill_date, int patid, string name, string doctname, string const_fee, string total)
        {
            return admndal.addOutPat_bills(bill_date, patid, name, doctname, const_fee, total);

        }
        public Boolean Add_Patreports(int patid,string test_name, string description)
        {
            return admndal.Add_Patreports(patid,test_name,description);
        }
        public DataSet get_doct_name(string department)
        {
            return admndal.get_doct_name(department);
        }



    }
}
