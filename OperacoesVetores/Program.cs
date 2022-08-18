using System;

namespace OperacoesVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vetor1 = new double[5];
            double[] vetor2 = new double[5];

            void InformarValores()
            {
                Console.WriteLine("Informe os valores para o vetor 1: ");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Informe o " + (i + 1) + "º valor: ");
                    vetor1[i] = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                Console.WriteLine("Informe os valores para o vetor 2: ");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Informe o " + (i + 1) + "º valor: ");
                    vetor2[i] = int.Parse(Console.ReadLine());
                }
            }

            void ImprimirVetores()
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("\n\tvetA [" + i + "] = " + vetor1[i] + " |  | vetB [" + i + "] = " + vetor2[i]);
                }
            }

            void Operacoes(string operacao)
            {
                for (int i = 0; i < 5; i++)
                {
                    switch (operacao)
                    {
                        case "soma":
                            Console.WriteLine("\t\tsoma = " + (vetor1[i] + vetor2[i]));
                            break;
                        case "subtracao":
                            Console.WriteLine("\t\tsubtracao = " + (vetor1[i] - vetor2[i]));
                            break;
                        case "multiplicacao":
                            Console.WriteLine("\t\tmultiplicacao = " + (vetor1[i] * vetor2[i]).ToString("F2"));
                            break;
                        case "divisao":
                            if (vetor2[i] == 0)
                                Console.WriteLine("Impossível dividir por zero!");
                            else
                                Console.WriteLine("\t\tdivisao = " + (vetor1[i] / vetor2[i]).ToString("F2"));
                            break;
                    }
                }
            }

            void InformarOperacao()
            {
                Console.WriteLine("\n\n\t DENTRE AS OPCOES ABAIXO");
                Console.WriteLine("(soma) (subtracao) (multiplicacao) (divisao)");
                Console.Write("\nQual operacao deseja fazer? ");

                string opcoes = Console.ReadLine();
                opcoes = opcoes.ToLower();
                if (opcoes != "soma" && opcoes != "subtracao" && opcoes != "multiplicacao" && opcoes != "divisao")
                {
                    Console.WriteLine("VOCE INFORMOU: " + opcoes + ", ESTA É UMA OPCAO INVÁLIDA!");
                }
                Operacoes(opcoes);
            }

            void Comparacao()
            {
                Console.WriteLine("\n");
                for (int i = 0; i < 5; i++)
                {
                    if (vetor1[i] > vetor2[i])
                    {
                        Console.WriteLine("vetor 1 maior que 2!\n\n");
                    }
                    else if (vetor2[i] > vetor1[i])
                    {
                        Console.WriteLine("vetor 2 maior que 1!\n\n");
                    }
                    else
                    {
                        Console.WriteLine("vetores iguais!\n\n");
                    }
                }
            }

            int opcao = 0;
            do
            {
                Console.WriteLine("DIGITE (1) PARA EXECUTAR OU (O) PARA SAIR!");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                if (opcao == 1)
                {
                    InformarValores();
                    Console.Clear();
                    ImprimirVetores();
                    InformarOperacao();
                    Comparacao();
                }
            } while (opcao != 0);
            Console.WriteLine("Pressione qualquer tecla para finalizar a aplicacao.");
            Console.ReadKey();
        }
    }
}