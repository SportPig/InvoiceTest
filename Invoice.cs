using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceTest
{
    class Invoice
    {
        string partNumber;
        string partDescription;
        int quantity;
        double price;

        public string PartNumber
        {
            get { return partNumber; }
            set { partNumber = value; }
        }

        public string PartDescription
        {
            get { return partDescription; }
            set { partDescription = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0) value = 0;
                price = value;
            }
        }

        public Invoice(string partNumber, string partDescription, int quantity, double price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            Price = price;
        }

        public double getInvoiceAmount()
        {
            return quantity * price;
        }

    }
}


