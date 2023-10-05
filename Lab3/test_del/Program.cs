/*
 * 
 *  Name:               Samuel Ayres
 *  Student Number:     S00237258
 *  
 *  Beginning Date:     05/10/2023
 *  Completion Date:    05/10/2023
 *  
 *  Question:           Deceased
 *                      Symptoms: Incorrect file path?
 *  
*/

namespace Q9
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string filePath = "..\\..\\sales.txt";

            string[] temp = File.ReadAllLines("c:\\temp\\test.txt");

            Console.WriteLine(temp.Length);

            // Reading the file
            //List<string> reportLines = ProcessSalesData(filePath);

            // Display the report
            //Console.WriteLine("Store ID\tTotal Sales\tPerformance");
            //foreach (string line in reportLines)
            //{
            //    Console.WriteLine(line);
            //}
        }

        static List<string> ProcessSalesData(string filePath)
        {
            List<string> reportLines = new List<string>();

            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    // Split each line into store_id and total_sales
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        // Variables
                        string storeId = parts[0].Trim();
                        int totalSales = int.Parse(parts[1].Trim());

                        // How good did it perform?
                        string performance;
                        if (totalSales < 1000)
                        {
                            performance = "Needs attention";
                        }
                        else if (totalSales >= 1000 && totalSales <= 1999)
                        {
                            performance = "Moderate";
                        }
                        else
                        {
                            performance = "Very good";
                        }

                        // Creating a report
                        string reportLine = $"{storeId}\t{totalSales}\t{performance}";
                        reportLines.Add(reportLine);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"- An error occurred while reading the file :( {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("- An error occured while reading format.");
            }

            return reportLines;
        }
    }
}