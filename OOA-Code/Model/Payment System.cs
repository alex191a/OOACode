using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOA_Code.Model
{
    public class Payment_System
    {
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public string Billinginformation { get; private set; }
        public void PaymentInfo(string name, string adress, string billingInformation)
        {
            Name = name;
            Adress = adress;
            Billinginformation = billingInformation;
        }
        public bool Status()
        {
            if (!string.IsNullOrEmpty(Name)&&!string.IsNullOrEmpty(Adress)&&!string.IsNullOrEmpty(Billinginformation))
            {
                return true;
            }
            return false;
        }

    }
}
