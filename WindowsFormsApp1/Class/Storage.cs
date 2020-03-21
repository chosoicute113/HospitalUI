using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Information
    {
        public string id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public string expire_date { get; set; }
        public int consumetype { get; set; }
        public Information()
        {
            name = "";
            quantity = 0;
            expire_date = "N/A";
        }
    }
    public class Food: Information
    {
        public Food(string inputid,string inputname, int inputqty,string inputdate,int type)
        {
            id = inputid;
            name = inputname;
            quantity = inputqty;
            expire_date = inputdate;
            consumetype = type;
        }

        
    }
    public class Water: Information
    {
        public Water(string inputid, string inputname, int inputqty, string inputdate,int type)
        {
            id = inputid;
            name = inputname;
            quantity = inputqty;
            expire_date = inputdate;
            consumetype = type;
        }
    }
    public class equipment:Information
    {
        public equipment(string inputid, string inputname, int inputqty, string inputdate)
        {
            id = inputid;
            name = inputname;
            quantity = inputqty;
            expire_date = inputdate;
        }
    }
    public class Medicine:Information
    {
        public Medicine(string inputid, string inputname, int inputqty, string inputdate)
        {
            id = inputid;
            name = inputname;
            quantity = inputqty;
            expire_date = inputdate;
        }

    }

}
