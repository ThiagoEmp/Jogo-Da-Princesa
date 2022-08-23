using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    public class operacoes
    {
        public void soma()
        {
            int x = 0;
            int y = 0;
            Console.Clear();

            Console.WriteLine("Insira um número");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um número");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine(x + " + " + y + " = " + (x + y));
            Console.ReadLine();
        }

        public void sub()
        {
            int x = 0;
            int y = 0;
            Console.Clear();

            Console.WriteLine("Insira um número");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um número");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine(x + " - " + y + " = " + (x - y));
            Console.ReadLine();
        }

        public void mult()
        {
            int x = 0;
            int y = 0;
            Console.Clear();

            Console.WriteLine("Insira um número");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um número");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine(x + " * " + y + " = " + (x * y));
            Console.ReadLine();
        }

        public void div()
        {
            int x = 0;
            int y = 0;
            Console.Clear();

            Console.WriteLine("Insira um número");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um número");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine(x + " / " + y + " = " + (x / y));
            Console.ReadLine();
        }
    }
}
