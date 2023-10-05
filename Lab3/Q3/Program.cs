/*
 * 
 *  Name:               Samuel Ayres
 *  Student Number:     S00237258
 *  
 *  Beginning Date:     05/10/2023
 *  Completion Date:    05/10/2023
 *  
 *  Question:           3
 *                      Write a method named Zero that accepts an int array
 *                      as an argument and stores the value 0 in each element.
 *  
*/

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // My Array
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("- The array before zeroing all elements:");
            Console.WriteLine(string.Join(", ", numbers));

            // Method called
            Zero(numbers);

            Console.WriteLine("- The array after zeroing all elements:");
            Console.WriteLine(string.Join(", ", numbers));
        }

        static void Zero(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
        }
    }
}