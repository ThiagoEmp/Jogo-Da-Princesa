using System;

namespace JogoDaPrincesa
{
    public class Program
    {
        static void Main(string[] args)
        {
            Candidato[] candidatos = new Candidato[6];
            bool entrada = true;
            int escolher = 0;
            Funcoes funcao = new Funcoes();

            


             

                while (entrada == true)
                {
                    Console.WriteLine("Bem vindo ao jogo da princesa");
                    Console.WriteLine("Para jogar aperte 1, Para sair aperte 0");
                    escolher = int.Parse(Console.ReadLine());
                    if (escolher == 1)
                    {
                    Console.Clear();
                    int[] resultado = new int[6];
                    resultado = funcao.PreencherTipos();
                   
                    
                    candidatos = funcao.PreencherCandidatos(resultado);
                    
                    Console.Clear();
                    


                    Console.ReadLine();
                    }
                    else if (escolher == 0)
                    {
                        entrada = false;
                    }
                    else
                    {
                        Console.WriteLine("Essa opção não existe.");
                    }
                }
        }

        
    }
}
