/*
 * 
 *  Name:               Samuel Ayres
 *  Student Number:     S00237258
 *  
 *  Beginning Date:     05/10/2023
 *  Completion Date:    05/10/2023
 *  
 *  Question:           2
 *                      Write a method that uses a switch statement
 *                      to return the cost of a product.
 *  
*/

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("- Please enter the product description: ");
            string description = Console.ReadLine();

            double cost = GetProductCost(description);

            if (cost == -999.0)
            {
                Console.WriteLine("- Error: The product was not found.");
            }
            else
            {
                Console.WriteLine($"- The cost of {description} is: {cost:c}");
            }
        }

        static double GetProductCost(string productDescription)
        {
            switch (productDescription.ToLower())
            {
                case "jeans":
                    return 67.99;
                case "jacket":
                    return 68.99;
                case "boots":
                    return 34.99;
                case "scarves":
                case "belts":
                case "socks":
                    return 10.0;
                default:
                    return -999.0; // Signal error for unknown products
            }
        }
    }
}