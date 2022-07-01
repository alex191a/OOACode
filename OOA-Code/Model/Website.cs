using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOA_Code.Model
{
    public class Website
    {
        public Bread_bakeoff basket  { get; set; }
        public Payment_System payment { get; set; }
        public Website()
        {
            basket = new Bread_bakeoff();
            payment = new Payment_System();
        }
        public void AddToBasket(string bread)
        {
            basket.Basket(bread);
        }
        public bool VerificationResponse()
        {
            if (basket.Status() && payment.Status())
            {
                return true;
            }
            return false;
        }
}   
    }
    
