using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    internal class Product
    {
        protected int pid;
        protected string pname;
        protected double pprice;

        public void SetInformation(int id, string name, double price)
        {
            pid = id;
            pname = name;
            pprice = price;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Product ID: {pid}");
            Console.WriteLine($"Product Name: {pname}");
            Console.WriteLine($"Product Price: ${pprice}");
        }
    }

    class HerbalProduct : Product
    {
        private string herbsUsed;
        private DateTime mfDate;
        private DateTime expDate;

        public void SetHerbalProductDetails(string herbs, DateTime mf, DateTime exp)
        {
            herbsUsed = herbs;
            mfDate = mf;
            expDate = exp;
        }

        public override void ShowDetails()
        {
            base.ShowDetails(); // Call the base class method to display common details
            Console.WriteLine($"Herbs Used: {herbsUsed}");
            Console.WriteLine($"Manufacturing Date: {mfDate.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Expiration Date: {expDate.ToString("yyyy-MM-dd")}");
        }
    }
}
