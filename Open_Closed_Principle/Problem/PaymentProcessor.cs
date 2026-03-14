using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Problem
{
    public class PaymentProcessor
    {
        void Pay(string paymentType)
        {
            if (paymentType == "CreditCard")
            {
                // Process credit card payment
            }
            else if (paymentType == "PayPal")
            {
                // Process PayPal payment
            }
            else if (paymentType == "BankTransfer")
            {
                // Process bank transfer payment
            }
        }
    }
}
