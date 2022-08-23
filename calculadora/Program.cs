using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main()
        {
            {
                bool ligada = true;
                string name;
                string lastname;
                int opt = 0;
                int count = 0;

                Console.WriteLine("Insira seu nome");
                name = Console.ReadLine();

                Console.WriteLine("Insira seu sobrenome");
                lastname = Console.ReadLine();

                while (ligada)
                {
                    
                    Console.Clear();
                    Console.WriteLine("Bem vindo(a) " + name + " " + lastname);
                    Console.WriteLine("Favor insira o número de acordo com o que deseja fazer: ");
                    Console.WriteLine("1 - para soma");
                    Console.WriteLine("2 - para subtração");
                    Console.WriteLine("3 - para multiplicação");
                    Console.WriteLine("4 - para divisão");
                    Console.WriteLine("0 - para sair");
                    opt = int.Parse(Console.ReadLine());

                    switch (opt)
                    {
                        case 1:
                            soma();
                            break;
                        case 2:
                            sub();
                            break;
                        case 3:
                            mult();
                            break;
                        case 4:
                            div();
                            break;
                        case 0:
                            ligada = false;
                            break;
                        default:
                            if(count < 2)
                            {
                                Console.Clear();
                                Console.WriteLine("CÊ É BURRO É???!!!");
                                Console.ReadLine();
                                count++;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("A NÃO MANO, DESISTO DE VOCÊ!!");
                                Console.ReadLine();
                                ligada = false;
                            }
                            break;
                    }

                    Console.Clear();

                }

                static void soma()
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

                static void sub()
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

                static void mult()
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

                static void div()
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
    }
}
