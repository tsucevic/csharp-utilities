using System;
using System.Xml.Linq;

namespace UtilitiesLib
{
    public class Utilities
    {
        /// <summary>
        /// Reads string from console and saves to variable.
        /// </summary>
        /// <param name="message">A message to print out to the user.</param>
        /// <param name="outputVariable">Variable in which the string will be saved.</param>
        /// <returns>User input.</returns>
        public static string ReadString(string message, out string outputVariable)
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
        public static string ReadString(string message)
        {
            ReadString(message, out string s);
            return s;
        }

        /// <summary>
        /// Reads int from console.
        /// </summary>
        /// <param name="message">A message to print out to the user.</param>
        /// <param name="outputVariable">Variable in which the int will be saved.</param>
        /// <returns>User input.</returns>
        public static int ReadInt(string message, out int outputVariable)
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
        public static int ReadInt(string message)
        {
            ReadInt(message, out int n);
            return n;
        }

        /// <summary>
        /// Reads double from console.
        /// </summary>
        /// <param name="message">A message to print out to the user.</param>
        /// <param name="outputVariable">Variable in which the double will be saved.</param>
        /// <returns>User input.</returns>
        public static double ReadDouble(string message, out double outputVariable)
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
        public static double ReadDouble(string message)
        {
            ReadDouble(message, out double n);
            return n;
        }
    }


}
