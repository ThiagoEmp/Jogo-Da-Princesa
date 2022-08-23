using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projeto2
{
    public class Program
    {

        //crie um programa que leia um vetor de 5 posições e leia uma opção de 1 ou 2 que se caso escolher 1- crescente, 2- decrescente

        static void Main(string[] args)
        {
            int[] vetor = new int[5];
            bool VouD = true;
            int num = 0;
            int Count = 0;


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("escreva o número " + (i+1) + ":");
                vetor[i] = int.Parse(Console.ReadLine());
      
            }

            while (VouD)
            {
                Console.WriteLine("-Escreva 1 para Ordenar de forma crescente ou");
                Console.WriteLine("-Escreva 2 para Ordenar de forma decrescente");
                Console.WriteLine("-0 para sair.");
                num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        vetor = crescente(vetor);
                        for (int i = 0; i < vetor.Length; i++)
                            Console.WriteLine("Os valores são: " + vetor[i]);
                        break;
                    case 2:
                        vetor = decrescente(vetor);
                        for (int i = 0; i < vetor.Length; i++)
                            Console.WriteLine("Os valores são: " + vetor[i]);
                        break;
                    case 0:
                        VouD = false;
                        break;
                    default:
                        if (Count < 2)
                        {
                            Console.WriteLine("para de trol krai");
                            Console.ReadLine();
                            Count++;
                        }
                        else
                        {
                            Console.WriteLine("vsf então");
                            Console.ReadLine();
                            VouD = false;
                        }
                        break;
                }

                


            }

        }

        static int[] crescente(int[] vetor)
        {
            int aux = 0;
            for(int j = 0; j < 5; j++)
            {
                for(int i = 0; i < 4; i++)
                {
                    if (vetor[i] > vetor[i+1])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = aux;
                    }
                }

            }



            return vetor;

        }
        
        static int[] decrescente(int[] vetor)
        {
            int aux = 0;
            for(int j = 0; j < 5; j++)
            {
                for(int i = 0; i < 4; i++)
                {
                    if (vetor[i] < vetor[i+1])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i+1];
                        vetor[i+1] = aux;
                    }
                }

            }

            


            return vetor;
        }


        
    }
}
