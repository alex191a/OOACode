using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOA_Code.Model
{
    public class Bread_bakeoff
    {
         List<string> basket { get; set; }
        public Bread_bakeoff() { 
        basket = new List<string>();
        }
        public void Basket(string bread)
        {
            basket.Add(bread);
        }
        public bool Status()
        {
            if (basket.Count < 0)
            {
                return true;
            }
            return false;
        }

    }
}
