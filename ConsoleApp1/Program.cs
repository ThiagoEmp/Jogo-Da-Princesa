using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

            string x = nomedif(-25, "Wendril");

        }

        static string nomedif(int num, string nome)
        {
            string testenum = Math.Abs(num).ToString();
            Console.WriteLine(testenum);
            return testenum;

        }


    }
}
