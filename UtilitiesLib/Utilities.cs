using System;

namespace UtilitiesLib
{
    public class Utilities
    {
        /// <summary>
        /// Reads string from console.
        /// </summary>
        /// <param name="message">A message to print out to the user.</param>
        /// <returns>User input.</returns>
        public static string ReadString(string message)
        {
            string s;
            do
            {
                Console.WriteLine(message);
                s = Console.ReadLine().Trim(); // remove excess whitespaces
            } while (string.IsNullOrWhiteSpace(s));

            return s;
        }

        /// <summary>
        /// Reads int from console.
        /// </summary>
        /// <param name="message">A message to print out to the user.</param>
        /// <returns>User input.</returns>
        public static int ReadInt(string message)
        {
            int n;
            do
            {
                Console.WriteLine(message);
            } while (!int.TryParse(Console.ReadLine(), out n)); // check if it can be parsed into int and parse to n

            return n;
        }

        /// <summary>
        /// Reads double from console.
        /// </summary>
        /// <param name="message">A message to print out to the user.</param>
        /// <returns>User input.</returns>
        public static double ReadDouble(string message)
        {
            double n;
            do
            {
                Console.WriteLine(message);
            } while (!double.TryParse(Console.ReadLine(), out n)); // check if it can be parsed into double and parse to n

            return n;
        }
    }


}
