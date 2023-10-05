/*
 * 
 *  Name:               Samuel Ayres
 *  Student Number:     S00237258
 *  
 *  Beginning Date:     05/10/2023
 *  Completion Date:    05/10/2023
 *  
 *  Question:           5
 *                      Write a method that accepts a stock-on-hand figure and a sales figure as an int argument.
 *                      Update the stock if there is enough to cover the sale.
 *  
*/

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int stockOnHand = 50,
                salesFigure = 30,
                newStockOnHand = UpdateStock(stockOnHand, salesFigure);

            // Main
            if (newStockOnHand >= 0)
            {
                Console.WriteLine($"- Stock is updated. \n- New stock-on-hand: {newStockOnHand}");
            }
            else
            {
                Console.WriteLine($"- Not enough stock. \n- Stock-on-hand remains unchanged: {newStockOnHand}");
            }
        }

        static int UpdateStock(int stockOnHand, int salesFigure)
        {
            if (stockOnHand >= salesFigure)
            {
                return stockOnHand - salesFigure;
            }
            else
            {
                return -1;
            }
        }
    }
}