/*
 * Jacob Lanham
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nile.Host 
{
    class Program 
    {
        static void Main( string[] args )
        {
            bool quit = false;
            do
            {
                char choice = GetInput();
                switch (choice)
                {
                    case 'A': AddProduct(); break;
                    case 'L': ListProducts(); break;
                    case 'Q': quit = true; break;
                };
            } while (!quit);
        }
        private static void ListProducts()
        {
            throw new NotImplementedException();
        }

        private static void AddProduct()
        {
            Console.Write("Enter product name: ");
            productName = Console.ReadLine().Trim();

            //Ensure not empty

            Console.Write("Enter product price (> 0): ");
            string price = Console.ReadLine().Trim();

            Console.Write("Enter optinal description: ");
            productDescription = Console.ReadLine().Trim();

            Console.Write("Is it discontinued (Y/N");
            string discontinued = Console.ReadLine().Trim();

        }

        static char GetInput()
        {
            while (true)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("".PadLeft(10, '-'));
                Console.WriteLine("A)dd Product");
                Console.WriteLine("L)ist Products");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine().Trim();

                //option 1 = string literal
                //if (input != "")

                //option 2 - string field
                //if(input != String.Empty)

                //option 3 - length
                if(input != null && input.Length != 0)
                {
                    //String comparison
                    if (String.Compare(input, "A", true) == 0)
                        return 'A';
                   
                    //char comparison 
                    char letter = Char.ToUpper(input[0]);

                    if (letter == 'A')
                        return 'A';
                    else if (letter == 'L')
                        return 'L';
                    else if (letter == 'Q')
                        return 'Q';

                    //Error
                    Console.WriteLine("Please choose a valid option");
                };
            };
        }

        // A single line comment
        static void Main2( string[] args )
        {
            int hours = 5;
            hours = 10;

            //+ - * / %
            //hours = (4 + 5) * 7.25 / 4;
            //hours = Math.Min(hours, 56);

            string name = "John";

            //Concat
            name = name + " Williams";

            //Copy
            name = "Hello";

            bool areEqual = name == "Hello";
            bool areNotEqual = name != "Hello";

            //Verbatim string - no espace sequences
            string path = @"C:\Temp\test.txt";

            //String formating - John worked 10 hours

            //option 1
            string format1 = name + " worked " + hours.ToString() + " hours";
            
            //option 2
            string format2 = String.Format("{0} worked for {1} hours", name, hours);

            //option 3 - prefered
            string format3 = $"{name} worked for {hours} hours";

        }

        //Product
        static string productName;
        static decimal productPrice;
        static string productDescription;
        static bool productDiscontinued;
    }
}