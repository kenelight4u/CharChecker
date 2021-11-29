using System;
using System.Linq;

namespace CharChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            Console.WriteLine("Enter a char to check if repeated or not");
            char ch = Convert.ToChar(Console.ReadLine());

            Program check = new Program();
            Console.WriteLine(check.Checker(str, ch));
            
        }

        public bool Checker(string str, char ch)
        {
            var count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (ch == str[i])
                {
                    count++;
                    if (count > 1) return true;
                }
            }

            return false;
        }
    }
}
