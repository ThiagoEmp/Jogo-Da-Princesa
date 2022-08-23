using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projeto2
{
    public class Program
    {

        //criar uma lista e inserir com uma função quantos numeros a pessoa desejar ate digitar 0, retornar a lista que foi inserida e somar os valores e mostrar.

        static void Main(string[] args)
        {

            var numeros = new List<int>();
            var total = 0;

            numeros = preencher();

            foreach(int i in numeros)
            {
                total = total + i;

            }

            Console.WriteLine(total);  
        }

        static List<int> preencher()
        {
            var num = new List<int>();
            bool valor = true;
            int num1 = 0;
            while(valor)
            {
                Console.WriteLine("Escreva um numero, digite 0 para sair: ");
                num1 = int.Parse(Console.ReadLine()); 

                if(num1 == 0)
                {
                    valor = false;
                }

                num.Add(num1);

            }

            return num;
        }

    }
}
