/*
 * Jacob Lanham
 * ITSE 1430
 * 9-18-2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1 
    {
    class Program 
        {
        static void Main( string[] args )
        {
            var quit = false;
            do
            {
               
                var choice = GetInput();
                switch (choice)
                {
                    case 'A': AddMovie(); break;
                    case 'L': ListMovies(); break;
                    case 'R': RemoveMovie(); break;
                    case 'Q': quit = true; break;
                };
            } while (!quit);
        }

        static void AddMovie()
        {
            Console.WriteLine();

            Console.Write("Enter a title: ");
            movieTitle = ReadString(false);

            Console.Write("Enter an optional description: ");
            movieDescription = ReadString(true);

            Console.Write("Enter the optional length (in minutes): ");
            movieLength = ReadInt(true, 0);

            Console.Write("Do you own this movie? (Y/N): ");
            movieOwned = ReadYesNo();
        }

        static char GetInput()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine("".PadLeft(10, '-'));
                Console.WriteLine("L)ist Movie");
                Console.WriteLine("A)dd Movie");
                Console.WriteLine("R)emove Movie");
                Console.WriteLine("Q)uit");

                var input = Console.ReadLine().Trim();

                if (input != String.Empty)
                {
                    if (String.Compare(input, "A", true) == 0)
                        return 'A';
                    else if (String.Compare(input, "L", true) == 0)
                        return 'L';
                    else if (String.Compare(input, "R", true) == 0)
                        return 'R';
                    else if (String.Compare(input, "Q", true) == 0)
                        return 'Q';
                };

                Console.WriteLine("Please choose a valid option");
            };
        }

        static void ListMovies()
        {
            Console.WriteLine();

            if (String.IsNullOrEmpty(movieTitle))
                Console.WriteLine("No movies available");
            else
            {
                Console.WriteLine($"Title: {movieTitle}");

                if (!String.IsNullOrEmpty(movieDescription))
                    Console.WriteLine($"Description: {movieDescription}");

                if (movieLength >= 0)
                    Console.WriteLine($"Runtime: {movieLength} mins");

                Console.WriteLine($"Status: {(movieOwned ? "Owned" : "Not Owned")}");
            }
        }

        /// <summary>Reads an int from Console.</summary>
        /// <returns>The decimal value.</returns>
        static int ReadInt(bool allowEmpty, int minNumber)
        {
            do
            {
                var input = Console.ReadLine();

                if (String.IsNullOrEmpty(input) && allowEmpty)
                    return (minNumber - 1);

                //decimal result;
                if (Int32.TryParse(input, out var result) && result >= minNumber)
                    return result;

                Console.WriteLine("Enter a valid int");
            } while (true);
        }

        /// <summary>Reads a boolean from Console.</summary>
        /// <returns>The boolean value.</returns>
        static bool ReadYesNo()
        {
            do
            {
                var input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input))
                {
                    switch (Char.ToUpper(input[0]))
                    {
                        case 'Y':
                            return true;
                        case 'N':
                            return false;
                    };
                };

                Console.WriteLine("Enter either Y or N");
            } while (true);
        }

        /// <summary>Reads a string from Console.</summary>
        /// <returns>The string value</returns>
        static string ReadString(bool allowEmpty)
        {

            do
            {
                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input) && allowEmpty)
                    return "";
                else if (!String.IsNullOrEmpty(input))
                    return input.Trim();

                Console.WriteLine("Please enter a valid string");

            } while (true);
        }
        
        static void RemoveMovie()
        {
            Console.WriteLine("Are you sure you want to remove this movie? (Y/N): ");
            var delete = ReadYesNo();

            if (delete)
            {
                movieTitle = "";
                movieLength = -1;
                movieDescription = "";
                movieOwned = false;
            }
        }

        //Movie
        static string movieTitle;
        static int movieLength;
        static string movieDescription;
        static bool movieOwned;

    }
}
