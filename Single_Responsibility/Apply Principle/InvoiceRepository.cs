using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility.Apply_Principle
{
    internal class InvoiceRepository
    {
            public void Save(Invoice invoice)
            {
                // Code to save the invoice to a database or file
            }
    
            public Invoice GetById(int id)
            {
                // Code to retrieve an invoice by its ID from a database or file
                return null; // Placeholder return value
        }
    }
}
