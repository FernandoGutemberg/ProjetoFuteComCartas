using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuteCartas
{
    public class CartasJogos
    {
        public List<string> Cards = new List<string> { 
		/*00*/ "Gol",
		/*01*/ "Pênalti", 
		/*02*/ "Energia", 
		/*03*/ "Falta", 
		/*04*/ "Cartão Amarelo", 
   		/*05*/ "Cartão Vermelho" };
        public List<int> PontCards = new List<int> {
		/*00*/ 3,
		/*01*/ 2,
		/*02*/ 2,
		/*03*/ 1,
		/*04*/ 1,
		/*05*/ 0 };
        public List<string> CartasRodada = new List<string>();
        public List<int> ScoreDaRodada = new List<int>();
        public int CartaJogada { get; set; }
        public int ScoreCartas { get; set; }
        public bool Amarela { get; set; }
        public bool Vermelho { get; set; }
        public bool Energia { get; set; }
        public bool Penalti { get; set; }
        public bool golBool { get; set; }
        public bool Repeticao { get; set; }
        public const string LBordadaAcima = "╔═══════════════════════════════╗";
        public const string LBordadaAbaixo = "╚═══════════════════════════════╝";
        // public const string LBordaLaterais = "║                                 ║";
        Random Sorteio = new Random();

        public void BordaCima()
        {
            Console.WriteLine("");
            Console.WriteLine(LBordadaAcima);
        }
        public void BordaBaixo()
        {
            Console.WriteLine(LBordadaAbaixo);
            Console.WriteLine("");
        }


        /*
            -------	ACRESCENTAR O SORTEIO --------  
        */


        public void CartaoAmarelo()
        {
            if (Repeticao == true && CartaJogada == 4)
            {
                BordaCima();
                Console.WriteLine("Cartão Amarelo!");
                BordaBaixo();
                this.Amarela = true;
                Repeticao = false;
            }
        }

        public void CartaoVermelho()
        {
            if (Repeticao == true && CartaJogada == 5)
            {
                BordaCima();
                Console.WriteLine("Cartão Vermelho!");
                Console.WriteLine(" O jogador Perdeu 2 energias!  ");
                BordaBaixo();
                this.Vermelho = true;
                Repeticao = false;

            }
        }

        public void CartaoEnergia()
        {
            if (Repeticao == true && CartaJogada == 2)
            {
                BordaCima();
                Console.WriteLine("Energia extra!");
                BordaBaixo();
                this.Energia = true;
                Repeticao = false;
            }
        }

        public void CartaoPenalti()
        {
            if (Repeticao == true && CartaJogada == 1)
            {
                BordaCima();
                Console.WriteLine("Penalti");
                BordaBaixo(); ;
                this.Penalti = true;
                Repeticao = false;
            }
        }


        public void CartaoGol()
        {
            if (Repeticao == true && CartaJogada == 0)
            {
                BordaCima();
                Console.WriteLine("Gol");
                BordaBaixo();
                this.golBool = true;
                Repeticao = false;
            }
        }
        public void CartaoFalta()
        {
            if (Repeticao == true && CartaJogada == 3)
            {
                BordaCima();
                Console.WriteLine("Falta!! Perdeu uma rodada");
                Repeticao = false;
                BordaBaixo();
            }
        }
    }
}
