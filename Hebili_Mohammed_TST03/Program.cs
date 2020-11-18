using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hebili_Mohammed_TST03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No. of invoice"); 
            int invNo = int.Parse(Console.ReadLine()); 
            int[] invoices = new int[invNo]; 
            Console.WriteLine("Enter minimum discount amount"); 
            int discountAmount = int.Parse(Console.ReadLine()); 
            for (int i = 0; i < invNo; i++) 
            {
                Console.WriteLine("Enter the amount of Invoice {0}", i + 1);
                invoices[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(); 
            for (int i = 0; i < invNo; i++) 
            {
                if (invoices[i] >= discountAmount)
                    Console.WriteLine("Discount of 5% allowed for invoice {0}", i + 1);
                else
                    Console.WriteLine("No Discount for invoice {0}", i + 1);
            }

            Console.ReadLine(); 
        }
    }
}
