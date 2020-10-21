using System;
using System.Xml.Linq;

namespace UtilitiesLib
{
    /// <summary>
    /// Library for console reads.
    /// </summary>
    public class Read
    {
        /// <summary>
        /// Reads string from console and saves to variable.
        /// </summary>
        /// <param name="message">A message to print out to the user.</param>
        /// <param name="outputVariable">Variable in which the string will be saved.</param>
        /// <returns>User input.</returns>
        public static string String(string message, out string outputVariable)
        {
            do
            {
                Console.WriteLine(message);
                outputVariable = Console.ReadLine().Trim(); // remove excess whitespaces
            } while (string.IsNullOrWhiteSpace(outputVariable));

            return outputVariable;
        }

        /// <summary>
        /// Reads string from console.
        /// </summary>
        /// <param name="message">A message to print out to the user.</param>
        /// <returns>User input.</returns>
        public static string String(string message)
        {
            String(message, out string s);
            return s;
        }

        /// <summary>
        /// Reads int from console.
        /// </summary>
        /// <param name="message">A message to print out to the user.</param>
        /// <param name="outputVariable">Variable in which the int will be saved.</param>
        /// <returns>User input.</returns>
        public static int Int(string message, out int outputVariable)
        {
            do
            {
                Console.WriteLine(message);
            } while (!int.TryParse(Console.ReadLine(), out outputVariable)); // check if it can be parsed into int and parse to n

            return outputVariable;
        }

        /// <summary>
        /// Reads int from console.
        /// </summary>
        /// <param name="message">A message to print out to the user.</param>
        /// <returns>User input.</returns>
        public static int Int(string message)
        {
            Int(message, out int n);
            return n;
        }

        /// <summary>
        /// Reads double from console.
        /// </summary>
        /// <param name="message">A message to print out to the user.</param>
        /// <param name="outputVariable">Variable in which the double will be saved.</param>
        /// <returns>User input.</returns>
        public static double Double(string message, out double outputVariable)
        {
            do
            {
                Console.WriteLine(message);
            } while (!double.TryParse(Console.ReadLine(), out outputVariable)); // check if it can be parsed into double and parse to n

            return outputVariable;
        }

        /// <summary>
        /// Reads double from console.
        /// </summary>
        /// <param name="message">A message to print out to the user.</param>
        /// <returns>User input.</returns>
        public static double Double(string message)
        {
            Double(message, out double n);
            return n;
        }
    }


}
