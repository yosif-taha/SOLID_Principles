using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility.Problem
{
    public class Invoice
    {
        public void CalculateTotal()
        {
            // Code to calculate the total amount of the invoice
        }

        public void SaveToDatabase()
        {
            // Code to save the invoice to the database
        }

        public void SendEmail()
        {
            // Code to send the invoice via email to the customer
        }
    }
}
