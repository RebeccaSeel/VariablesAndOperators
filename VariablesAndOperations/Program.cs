using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperations
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int age = 65;
            string why = "because I said so";
            char firstInitial = 'L';

            //floating point types
            float floatNumber = 2.16440334897294849383961032f;
            Console.WriteLine(floatNumber);

            double doubleNumber = 2.16440334897294849383961032d;
            Console.WriteLine(doubleNumber);

            decimal decimalNumber = 2.16440334897294849383961032m;
            Console.WriteLine(decimalNumber);

            int jessicaAge = 23;
            int samAge = 47;
            Console.WriteLine(jessicaAge < samAge);


            Console.WriteLine("What is the name on the reservation?");
            string reserveName = Console.ReadLine();

            Console.WriteLine("How many people are in your party?");
            int numberOfPeople = int.Parse(Console.ReadLine());

            Console.WriteLine();
            double amountEach = 13.53d;
            double totalBill = numberOfPeople * amountEach;
            Console.WriteLine(totalBill);


            Console.WriteLine("Reservation: " + reserveName);
            Console.WriteLine("Total Due: $" + totalBill);










        }
    }
}
