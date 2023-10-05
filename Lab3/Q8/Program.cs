/*
 * 
 *  Name:               Samuel Ayres
 *  Student Number:     S00237258
 *  
 *  Beginning Date:     05/10/2023
 *  Completion Date:    05/10/2023
 *  
 *  Question:           8
 *                      Get each team members name using a sentinel value of -1.
 *                      Sort them alphabhetically 
 *  
*/

namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> teamNames = new List<string>();

            Console.WriteLine("- Please enter the names of the players on the team (or enter -1 to finish):");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "-1")
                {
                    break; // Exit the loop when -1 is entered
                }

                teamNames.Add(input);
            }

            // Sort the list of names in alphabetical order
            teamNames.Sort();

            Console.WriteLine("\n- The names of the team members in alphabetical order are:");
            foreach (string name in teamNames)
            {
                Console.WriteLine($"-> {name}");
            }
        }
    }
}