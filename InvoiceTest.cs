using System;
using System.IO;

namespace InvoiceTest
{
    class InvoiceTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Harry's Hardware Customer Invoice" + "!");
            Console.WriteLine(("").PadRight(34, '-'));
            Console.WriteLine();

            //create object of Invoice - invoice
            Invoice inv = new Invoice("Z58966TG776", "Brake Pads", 25, 52.69);
            double cost = inv.getInvoiceAmount();
            Console.WriteLine("Part Number = {0}", inv.PartNumber, inv.PartDescription, inv.Quantity, inv.Price, cost);
            Console.WriteLine();
            Console.WriteLine("Part Description = {1}", inv.PartNumber, inv.PartDescription, inv.Quantity, inv.Price, cost);
            Console.WriteLine();
            Console.WriteLine("Part Quantity = {2}", inv.PartNumber, inv.PartDescription, inv.Quantity, inv.Price, cost);
            Console.WriteLine();
            Console.WriteLine("Price per Item = $ {3}", inv.PartNumber, inv.PartDescription, inv.Quantity, inv.Price, cost);
            Console.WriteLine();
            Console.WriteLine(("").PadRight(34, '-'));
            Console.WriteLine();
            Console.WriteLine("Total Cost = $ {4}", inv.PartNumber, inv.PartDescription, inv.Quantity, inv.Price, cost);
            Console.WriteLine();
        }
    }
}
