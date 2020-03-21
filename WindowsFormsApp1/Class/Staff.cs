using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Class;
using WindowsFormsApp1;
using WindowsFormsApp1.UI;

namespace staff_ne
{
    public class Staff
    {
      public  string StaffID { get; set; }
       public string StaffName { get; set; }
       public int StaffPhoneNumber { get; set; }
       public string StaffAddress { get; set; }
       public int StaffAge { get; set; }
       public string StaffGender { get; set; }
        public List<Patient> SPlist = new List<Patient>();
       public Staff()
        {
            StaffName = "";
            StaffAge = 0;
            StaffGender = "";
            StaffAddress = "";
            StaffPhoneNumber = 0;
            SPlist = null;
        }
        public Staff(string Id,string name,int phonenumber,string address,int age,string gender)
        {
            StaffID = Id;
            StaffName = name;
            StaffPhoneNumber = phonenumber;
            StaffAddress = address;
            StaffAge = age;
            StaffGender = gender;
            
        }
        public void AddSP(Patient sp)
        {
            SPlist.Add(sp);
        }
        
    }
}
