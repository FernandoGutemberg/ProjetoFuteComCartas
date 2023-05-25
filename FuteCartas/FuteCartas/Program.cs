using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuteCartas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            PlayerX Efeito = new PlayerX();
            int EncerrarJogo = 0;
            Random sorte = new Random();
            int currentCursorTop = Console.CursorTop;
            int currentCursorLeft = Console.CursorLeft;
            while (EncerrarJogo == 0)
            {
                bool sair = false;
                int r = 0;
                int r1 = 0;
                bool rodada = false;
                PlayerX p = new PlayerX();
                PlayerX p2 = new PlayerX();
                CartasJogos c = new CartasJogos();
                p.Reset();
                p2.Reset();
                Console.Clear();
                p.TituloGrande();
                p.Apresentacao();
                if (p.PlayerPC == 2)
                { p2.PC = true; }

                string linha1 = " Player 1 ";
                string linha2 = " Player 2 ";
                p.NumPlayer = 1;
                p.PlayerNumero();
                p.NomePlayer();
                p2.NumPlayer = 2;
                p2.PlayerNumero();
                p2.NomePlayer();

                Console.Clear();

                rodada = sorte.Next(1, 3) == 1 ? true : false;


                while (sair == false)
                {
                    Console.SetCursorPosition(currentCursorLeft, currentCursorTop);
                    if (rodada == false)
                    {
                        if (p.PenaltiDefesa == true && p2.PenaltiChute == true)
                        {
                            if (p.PenaltiDefesa == true) { p.PenalidadeDefesa(); }
                            if (p.Defesa == p2.Chute) { p.DefesaGoleiro(); }
                            else { p2.GolMarcado(); }
                            Console.Clear();
                            p2.Cabecario();
                            p2.Pontuacao();
                            Console.ReadKey();
                            p.PenaltiDefesa = false;
                            p2.PenaltiChute = false;
                        }
                        if (p.Acabou == false)
                        {
                            Console.Clear();
                            p.JogoRodando();
                            if (p.PenaltiChute == true)
                            {
                                p2.PenaltiDefesa = true;
                            }

                            p.Score += c.ScoreCartas;
                            if (p.PenaltiChute != true) { p.Pontuacao(); }
                            Console.ReadKey();
                            //Console.Clear();
                            p.encerrandoRodada();
                            r++;
                            rodada = true;
                        }
                        else
                        {
                            Console.WriteLine("Jogador {0} está sem energia! ", p.Nome);
                            
                            rodada = true;
                        }
                    }
                    Console.SetCursorPosition(currentCursorLeft, currentCursorTop);
                    if (rodada == true)
                    {
                        if (p2.Acabou == false)
                        {
                            if (p2.PenaltiDefesa == true) { p2.PenalidadeDefesa(); }
                            if (p2.PenaltiDefesa == true && p.PenaltiChute == true)
                            {
                                if (p2.Defesa == p.Chute) { p2.DefesaGoleiro(); }
                                else { p.GolMarcado(); }
                                //Console.Clear() ;
                                p.Cabecario();
                                p.Pontuacao();
                                Console.ReadKey();
                                p2.PenaltiDefesa = false;
                                p.PenaltiChute = false;
                            }
                            Console.Clear();
                            p2.JogoRodando();
                            if (p2.PenaltiChute == true)
                            {
                                p.PenaltiDefesa = true;
                            }

                            p2.Score += c.ScoreCartas;
                            if (p2.PenaltiChute != true) { p2.Pontuacao(); }
                            Console.ReadKey();
                            Console.Clear();
                            p2.encerrandoRodada();
                            r1++;
                            rodada = false;
                        }
                        else
                        {
                            Console.WriteLine("Jogador {0} está sem energia! ", p2.Nome);
                            rodada = false;
                        }
                    }

                    if (p2.Acabou == true && p.Acabou == true) { sair = true; }

                }
                if (p.Gol > p2.Gol) { p.Ganhador(); p2.Perdedor(); }
                else if (p2.Gol > p.Gol) { p2.Ganhador(); p.Perdedor(); }
                else if (p.Gol == p2.Gol && p2.Score > p.Score) { p2.Ganhador(); p.Perdedor(); }
                else if (p.Gol == p2.Gol && p.Score > p2.Score) { p.Ganhador(); p2.Perdedor(); }
                else { p.Empate(); Console.WriteLine(p.Nome + " e " + p2.Nome); p.Pontuacao(); p2.Pontuacao(); }
                Console.WriteLine("Rodadas {0} e {1}", r, r1);

                Console.WriteLine("");
                Console.WriteLine("Deseja Continuar? \n [ 0 ] - Sim; \n [ 1 ] - Não;");
                EncerrarJogo = int.Parse(Console.ReadLine());
             
            }
            Console.Clear();
            Efeito.CreditoFinais();
            Thread.Sleep(10000);

        }
    }
}
