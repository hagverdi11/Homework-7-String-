using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            //Homework7 Reverse words.


            Console.WriteLine(reverse("Haqverdi"));
            
        }
        public static string reverse(string s)
        {
            string reverse = "";
            for (int a = s.Length - 1; a >= 0; a--)
            {
                reverse = reverse + s[a];
            }
            return reverse;
        }
    }
}
