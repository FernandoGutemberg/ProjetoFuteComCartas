using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuteCartas
{
    public class CartasJogos : Textos
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
        public List<string> BaralhoConcat = new List<string> { " //00 ", " //01", "//03 ", "//04 ", "//05 ", "//06 ", "//07 ", " //08", "//09 ", "//10 ", "//11 ", "//12 ", "//13 "};
        public List<int> ScoreDaRodada = new List<int>();
        public int CartaJogada { get; set; }
        public int ScoreCartas { get; set; }
        public bool Amarela { get; set; }
        public bool Vermelho { get; set; }
        public bool Energia { get; set; }
        public bool Penalti { get; set; }
        public bool falta { get; set; }
        public bool golBool { get; set; }
        public bool DesenvolvedorSort { get; set; }
        public bool Repeticao { get; set; }
        public const string LBordadaAcima = "╔═══════════════════════════════╗";
        public const string LBordadaAbaixo = "╚═══════════════════════════════╝";
        public string[] ArrayConcat = new string[15];
        public string StringVago1 { get; set; }
        public string StringVago2 { get; set; }
        public string StringConcat { get; set; }

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


        public void SorteioCartas()
        {
            int TercoJanela = Console.WindowWidth/3;
            int largura = TercoJanela/3;
            CartasRodada.Clear();
            ScoreDaRodada.Clear();
            BaralhoConcat.Clear();
            ScoreCartas = 0;
            BaralhoTupla();
            Array.Clear(ArrayConcat, 0, ArrayConcat.Length);
            
            for (int i = 0; i < 3; i++) 
            {
                int Altura = 5;
                var indice = 0;
                if (DesenvolvedorSort == false) { CartaJogada = Sorteio.Next(6); }
                else 
                {
                    Console.SetCursorPosition(5, 18);
                    Console.WriteLine("Escolha o numero da carta para jogar: \n [00] Gol \n [01] Penalti \n [02] Energia \n [03] Falta \n [04] Cartão Amarelo \n [05] Cartão Vermelho");
                    CartaJogada = int.Parse(Console.ReadLine());
                    
                }
                
                ScoreCartas += PontCards[CartaJogada];
                CartasRodada.Add(Cards[CartaJogada]);
                switch (CartaJogada)
                {
                    case 0: Console.ForegroundColor = ConsoleColor.DarkCyan; break;
                    case 1: Console.ForegroundColor= ConsoleColor.DarkMagenta; break;
                    case 2: Console.ForegroundColor=ConsoleColor.DarkGreen; break;
                    case 3:Console.ForegroundColor= ConsoleColor.DarkBlue; break;
                    case 4:Console.ForegroundColor= ConsoleColor.DarkYellow; break;
                    case 5: Console.ForegroundColor = ConsoleColor.DarkRed; break;
                }
                   for (int j = 0; j < 13; j++)
                   {
                       Altura++;
                       Console.SetCursorPosition(largura, Altura);
                       Console.WriteLine(TuplaCards[j,CartaJogada]);
                   }
                   Console.ResetColor();
                   largura += TercoJanela;
                   
            }
            if (CartasRodada[0] == CartasRodada[1] && CartasRodada[1] == CartasRodada[2]) 
            {
                Thread.Sleep(400);
                Console.Clear();
                Repeticao = true;
            }
        }


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
               // BordaCima();
               // Console.WriteLine("Gol");
               // BordaBaixo();
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
                falta = true;
                BordaBaixo();
            }
        }
    }
}
