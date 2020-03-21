using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Patient
    {
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public int PatientPhone { get; set; }
        public int PatientAge { get; set; }
        public string PatientRoom { get; set; }
        public string PatientAddress { get; set; }
        public string PatientGender { get; set; }
        public bool isBeingTreat { get; set; }

        public Patient()
        {
            PatientName = "";
            PatientPhone = 0;
            PatientAge = 0;
            PatientRoom = "";
            PatientAddress = "";
            PatientGender = "";
            isBeingTreat = false;
        }
        public Patient(string id,string name, int phone,int age, string room, string address, string gender)
        {
            PatientID = id;
            PatientName = name;
            PatientPhone = phone;
            PatientAge = age;
            PatientRoom = room;
            PatientAddress = address;
            PatientGender = gender;
            
        }

    }
}
