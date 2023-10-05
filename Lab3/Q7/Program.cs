/*
 * 
 *  Name:               Samuel Ayres
 *  Student Number:     S00237258
 *  
 *  Beginning Date:     05/10/2023
 *  Completion Date:    05/10/2023
 *  
 *  Question:           7
 *                      Use Q6 as a basis and add a jagged array to contain the reviews.
 *  
*/

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The Jagged Array :)
            int[][] filmReviews = new int[][]
            {
            new int[] { 3, 4 },          // Avengers Endgame
            new int[] { 1, 2, 1, 3 },    // Spider-Man: Far From Home
            new int[] { 5, 4, 2 }        // Once Upon A Time in Hollywood
            };

            // Main
            for (int film = 0; film < filmReviews.Length; film++)
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
                double averageRating = CalculateAverageRating(filmReviews[film]);

                Console.WriteLine($"- The average rating for '{filmTitle}' is: {averageRating:F2}");
            }
        }

        static double CalculateAverageRating(int[] ratings)
        {
            // Variables
            double sum = 0;
            int numReviews = 0;

            foreach (int rating in ratings)
            {
                if (rating != -1)
                {
                    sum += rating;
                    numReviews++;
                }
            }

            if (numReviews == 0)
            {
                return 0; // No reviews
            }

            return sum / numReviews;
        }
    }
}