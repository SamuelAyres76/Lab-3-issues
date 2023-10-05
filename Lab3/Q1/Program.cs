/*
 * 
 *  Name:               Samuel Ayres
 *  Student Number:     S00237258
 *  
 *  Beginning Date:     05/10/2023
 *  Completion Date:    05/10/2023
 *  
 *  Question:           1
 *                      Write a method that accepts the age as an int argument
 *                      and decides whether it is possible to access the site.
 *  
*/

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // variables
                int age;

                Console.Write("- Please enter your age: ");
                age = int.Parse(Console.ReadLine());

                if (CanAccessWebsite(age))
                {
                    Console.WriteLine("- You are permitted to access this website.");
                }
                else
                {
                    Console.WriteLine("- You are not permitted to access this website.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("- Invalid input. Please enter a valid age!");
            }
        }

        static bool CanAccessWebsite(int age)
        {
            return age >= 18 && age <= 21;
        }
    }
}