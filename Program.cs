using System;
using System.IO;
using System.Text;

namespace OOPDWeek1Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string quest1;
            string quest2;
            string quest3;
            string quest4;
            string quest5;
            string quest6;
            string quest7;
            string quest8;
            string quest9;
            string quest10;

            Console.WriteLine("Welcome to the ice cream selection program!");
            Console.WriteLine("You will be asked some questions that will provide you with which ice cream flavour you desire");
            Console.WriteLine("Person 1, Which flavour do you like most, out of R, G and B?");
            quest1 = Console.ReadLine();
            Console.WriteLine("Person 2, Which flavour do you like most, out of R, G and B?");
            quest2 = Console.ReadLine();
            Console.WriteLine("Person 3, Which flavour do you like most, out of R, G and B?");
            quest3 = Console.ReadLine();
            Console.WriteLine("Person 4, Which flavour do you like most, out of R, G and B?");
            quest4 = Console.ReadLine();
            Console.WriteLine("Person 5, Which flavour do you like most, out of R, G and B?");
            quest5 = Console.ReadLine();
            Console.WriteLine("Person 6, Which flavour do you like most, out of R, G and B?");
            quest6 = Console.ReadLine();
            Console.WriteLine("Person 7, Which flavour do you like most, out of R, G and B?");
            quest7 = Console.ReadLine();
            Console.WriteLine("Person 8, Which flavour do you like most, out of R, G and B?");
            quest8 = Console.ReadLine();
            Console.WriteLine("Person 9, Which flavour do you like most, out of R, G and B?");
            quest9 = Console.ReadLine();
            Console.WriteLine("Person 10, Which flavour do you like most, out of R, G and B?");
            quest10 = Console.ReadLine();

        while (quest2 != quest1 || quest3 != quest1 || quest4 != quest1 || quest5 != quest1 || quest6 != quest1 || quest7 != quest1 || quest8 != quest1 || quest9 != quest1 || quest10 != quest1)
        {           
                Console.WriteLine("Try again! You all need to select the same flavour!");            
        }
       
        //if (quest2 == quest1 && quest3 == quest1 && quest4 == quest1 && quest5 == quest1 && quest6 == quest1 && quest7 == quest1 && quest8 == quest1 && quest9 == quest1 && quest10 == quest1)
         //   {
           //     Console.WriteLine("You have all selected {0}", quest1);
            //}
        }
    }
}
