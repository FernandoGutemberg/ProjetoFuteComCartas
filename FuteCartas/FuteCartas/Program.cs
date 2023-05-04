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
            int EncerrarJogo = 0;
            Random sorte = new Random();
            while (EncerrarJogo == 0)
            {
                bool sair = false;
                int r = 0;
                bool rodada = false;
                PlayerX p = new PlayerX();
                PlayerX p2 = new PlayerX();
              //  p.Reset();
               // p2.Reset();
                Console.Clear();

                rodada = sorte.Next(1, 3) == 1 ? true : false;


                while (sair == false)
                {

                    if (rodada == false)
                    {
                        Console.ReadKey();
                        Console.Clear();
                        r++;
                        rodada = true;
                    }

                    if (rodada == true)
                    {
                        Console.ReadKey();
                        Console.Clear();
                        r++;
                        rodada = false;
                    }

                   // if (p2.Acabou == true && p.Acabou == true) { sair = true; }

                }

                Console.WriteLine("");
                Console.WriteLine("Deseja Continuar? \n [ 0 ] - Sim; \n [ 1 ] - Não;");
                EncerrarJogo = int.Parse(Console.ReadLine());

            }
        }
    }
}
