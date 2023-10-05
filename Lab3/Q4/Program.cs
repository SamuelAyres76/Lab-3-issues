/*
 * 
 *  Name:               Samuel Ayres
 *  Student Number:     S00237258
 *  
 *  Beginning Date:     05/10/2023
 *  Completion Date:    05/10/2023
 *  
 *  Question:           4
 *                      Write a method That returns the sum of all even numbers
 *                      between the two integer arguments passed to it.
 *  
*/

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int result = Sum(2, 10);

            Console.WriteLine("- The sum of the even numbers between 2 and 10 are: " + result);
        }

        static int Sum(int n1, int n2)
        {
            // Variables
            int sum = 0;

            // Is number 1 the smaller number? and number 2 the larger number?
            if (n1 > n2)
            {
                int temp = n1;
                n1 = n2;
                n2 = temp;
            }

            // Loop through the numbers between them and add the even numbers to the sum
            for (int i = n1; i <= n2; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}