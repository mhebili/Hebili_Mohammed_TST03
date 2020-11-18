using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No. of PostalCode and City to enter"); 
            int recordCount = int.Parse(Console.ReadLine()); 
            object[] arr = new object[recordCount];
            for (int i = 0; i < arr.Length; i++) 
            {
                Address add = new Address();
                Console.WriteLine("Enter the PostalCode");
                add.PostalCode = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the City");
                add.City = Console.ReadLine();
                arr[i] = add;
            }
            Console.WriteLine(); 

            Console.WriteLine("Enter a postal code to search");
            int postalCode = int.Parse(Console.ReadLine()); ;
            bool isFound = false;
            for (int i = 0; i < arr.Length; i++) 
            {
                if (((Address)arr[i]).PostalCode == postalCode)
                {
                    Console.WriteLine("Postal Code: {0} City: {1}", ((Address)arr[i]).PostalCode, ((Address)arr[i]).City);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
                Console.WriteLine("Not Found");
            Console.ReadLine(); 
        }
    }
    class Address
    {
        public int PostalCode { get; set; }
        public string City { get; set; }
    }
    
}
