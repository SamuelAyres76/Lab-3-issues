/*
 * 
 *  Name:               Samuel Ayres
 *  Student Number:     S00237258
 *  
 *  Beginning Date:     05/10/2023
 *  Completion Date:    05/10/2023
 *  
 *  Question:           6
 *                      Create an array with 3 movie films with ratings.
 *                      Each has 3 reviews. Find the average.
 *  
*/

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int[,] movieRatings = 
                {
                    { 3, 4, 5 }, // Avengers Endgame
                    { 1, 2, 1 }, // Spider-Man: Far From Home
                    { 5, 4, 2 }  // Once Upon A Time in Hollywood
                };

            // Calculate and output the average rating for each film
            for (int film = 0; film < movieRatings.GetLength(0); film++)
            {
                string filmTitle;
                switch (film)
                {
                    case 0:
                        filmTitle = "Avengers Endgame";
                        break;
                    case 1:
                        filmTitle = "Spider-Man: Far From Home";
                        break;
                    case 2:
                        filmTitle = "Once Upon A Time in Hollywood";
                        break;
                    default:
                        filmTitle = "Unknown";
                        break;
                }

                // Calling method
                double averageRating = CalculateAverageRating(movieRatings, film);

                Console.WriteLine($"- The average rating for '{filmTitle}' is: {averageRating:F2}");
            }
        }

        static double CalculateAverageRating(int[,] ratings, int filmIndex)
        {
            // Variables
            double sum = 0;
            int numReviews = ratings.GetLength(1);

            for (int i = 0; i < numReviews; i++)
            {
                sum += ratings[filmIndex, i];
            }

            return sum / numReviews;
        }
    }
}