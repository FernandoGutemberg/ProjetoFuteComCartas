using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuteCartas
{
        public class ConfGeral : Textos
        {

            public int PlayerPC { get; set; }
            public bool Desenvolvedor { get; set; }
            public int MetTela { get; set; }
            public int metLargTela { get; set; }

            public void Apresentacao()
            {
                do
                {

                    PlayerPC = 0;
                    Desenvolvedor = false;
                    Console.Clear();
                    Console.WriteLine(LBordadaUp.PadLeft(Console.WindowWidth / 2 + LBordadaUp.Length / 2));
                    Console.WriteLine(textoJogo[0].PadLeft(Console.WindowWidth / 2 + textoJogo[0].Length / 2));  //"--- Bem vindo ao jogo de cartas e futebol ---",
                    Console.WriteLine(LBordadaDown.PadLeft(Console.WindowWidth / 2 + LBordadaDown.Length / 2));
                    MetTela = (Console.WindowHeight / 2) - 5;
                    metLargTela = (Console.WindowWidth / 2)+4;
                for (int i = 0; i < 5; i++)
                     {
                        MetTela += 2;
                        int l = metLargTela;
                        Console.SetCursorPosition(l, MetTela);
                        Console.WriteLine(OpcaoInicio[i]);
                     }
                for (int i = 0; i <20 ; i++ )
                {
                    MetTela += 1;
                    Console.SetCursorPosition( 2, (i+5) );
                    Console.WriteLine(BolaAscii[i]);
                }
                    Console.WriteLine();
                    PlayerPC = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (PlayerPC == 3)
                    {
                        for (int i = 0; i < 15; i++)
                        {
                            Console.WriteLine("As regras são: \n");
                            Console.WriteLine(Regras[i] + "\n ");
                            Console.WriteLine("\n pressione qualquer botão para continuar: ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else if (PlayerPC == 4)
                    {
                        int Dev;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Deseja entrar no modo Desenvolvedor? Você irá ter total controle das Cartas \n [ 1 ] Sim \n [ 2 ] Não");
                            Dev = int.Parse(Console.ReadLine());
                            if (Dev == 1) { Desenvolvedor = true; }
                            else if (Dev == 2) { PlayerPC = 3; }
                            else { Console.Clear(); Console.WriteLine("Opção invalida!"); }
                        } while (Dev != 1 && Dev != 2);
                    }
                } while (PlayerPC == 3);

            }
            public void RedimensionandoTela()
            {

                int LarTela = Console.WindowWidth;
                int AltTela = Console.WindowHeight;
                if (AltTela < 30 || LarTela < 120)
                {
                    Console.SetBufferSize(120, 30);
                    Console.SetWindowSize(120, 30);

                }
            }

        }
    }

