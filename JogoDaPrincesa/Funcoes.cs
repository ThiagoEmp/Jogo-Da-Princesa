using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaPrincesa
{
    public class Funcoes
    {
        public int[] PreencherTipos()
        {
            Random rnd = new Random();
            int sorteado = 0;
            int[] verificador = new int[6];
            int[] resultado = new int[6];

            for (int i = 0; i < 6; i++)
            {
            inicio:
                sorteado = rnd.Next(1, 7);
                for (int j = 0; j < 6; j++)
                {
                    if (verificador[j] == sorteado)
                    {
                        goto inicio;
                    }
                }

                resultado[i] = sorteado;
                verificador[i] = sorteado;

            }
            return resultado;
        }

        public Candidato[] PreencherCandidatos(int[] tipos)
        {
            candidato = new Candidato() { };
            candidato1 = new Candidato() { };
            candidato2 = new Candidato() { };
            candidato3 = new Candidato() { };
            candidato4 = new Candidato() { };
            candidato5 = new Candidato() { };
            candidatos = new Candidato[6] {candidato, candidato1, candidato2, candidato3, candidato4, candidato5};

            for (int i = 0; i < 6; i++)
            {
                candidatos[i].nome = "Candidato" + (i + 1);
                candidatos[i].tipo = tipos[i];
                if (candidatos[i].tipo == 1 || candidatos[i].tipo == 2)
                {
                    candidatos[i].classe = "Verde";
                }
                else if (candidatos[i].tipo == 3 || candidatos[i].tipo == 4)
                {
                    candidatos[i].classe = "Vermelho";
                }
                else
                {
                    candidatos[i].classe = "Azul";
                }

                if (candidatos[i].classe == "Verde")
                {
                    candidatos[i].decisao = true;
                }
                else if (candidatos[i].classe == "Vermelho")
                {
                    candidatos[i].decisao = false;
                }
                else
                {
                    Random rnd = new Random();
                    int verificador = rnd.Next(1, 11);
                    if (verificador % 2 != 0)
                    {
                        candidatos[i].decisao = false;
                    }
                    else
                    {
                        candidatos[i].decisao = true;
                    }

                }

                switch (candidatos[i].tipo)
                {
                    case 1:
                        candidatos[i].nomeReal = "Princesa";
                        break;

                    case 2:
                        candidatos[i].nomeReal = "Fada madrinha";
                        break;

                    case 3:
                        candidatos[i].nomeReal = "Rainha má";
                        break;

                    case 4:
                        candidatos[i].nomeReal = "Guarda";
                        break;

                    case 5:
                        candidatos[i].nomeReal = "Espião";
                        break;

                    default:
                        candidatos[i].nomeReal = "Camponesa";
                        break;
                }
                candidatos[i].pergunta1 = false;
                candidatos[i].pergunta2 = false;



            }
            return candidatos;
        }

        public Candidato[] candidatos { get; set; }
        public Candidato candidato { get; set; }
        public Candidato candidato1 { get; set; }
        public Candidato candidato2 { get; set; }
        public Candidato candidato3 { get; set; }
        public Candidato candidato4 { get; set; }
        public Candidato candidato5 { get; set; }

    }
    
    
}
