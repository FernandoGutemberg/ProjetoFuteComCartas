using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuteCartas
{
    public class Textos
    {
        public const string LBordadaUp = "╔══════════════════════════════════════════════════╗";
        public const string LBordadaDown = "╚══════════════════════════════════════════════════╝";

        public const string LBordadaUp2 = "╔═══════════════════════════════════════════════════════════════════════╗";
        public const string LBordadaDown2 = "╚═══════════════════════════════════════════════════════════════════════╝";
        public int AlTela = Console.WindowHeight;
        public int LaTela = Console.WindowWidth;

        List<string> listCreditos = new List<string>();
        
        public string[] textoJogo = new string[]
        {
           /* 0 */ "--- Bem vindo ao TRUCOBOLL ---",
           /* 1 */ "GOOOOOOOOOOOLLLL!!!! Do ",
           /* 2 */ "Total de gols é de ",
           /* 3 */ "Incrivel defesa do Goleiro!! Não foi dessa fez que vemos um Gol!",
           /* 4 */ "Parabens! ",
           /* 5 */ "É o(a) ganhador(a)!",
           /* 6 */ "Infelizmente o jogador ",
           /* 7 */ "não ganhou dessa vez!",
           /* 8 */ "Apesar do empate, parabens aos jogadores! ",
           /* 9 */ "Penalidade MAXIMA!",
           /* 10 */ "É uma boa chance de tentar marcar um gol",
           /* 11 */ "Rodada da vez : Jogador ",
           /* 12 */ "Pontuação: ",
           /* 13 */ "║                Jogador  {0,-23}  ║",
           /* 14 */ "Energia restante: ",
           /* 15 */ "║ Pontuação: {0,-37} ║",
           /* 16 */ "║ Gols marcados: {0,-34}║",
           /* 17 */ "║ Energia restante: {0,-30} ║",
           /* 18 */ "Desenvolvido por:",
           /* 19 */ "Jeú Victor, Gabriel Bento, Gabriella França,",
           /* 20 */ "Fernando Gutemberg e Vitor Leopoldo",
           /* 21*/  "Pressione qualquer tecla pra continuar ",
            /* 22*/ "║ Score da Rodada: {0,-32}║"

        };
        public string[] OpcaoInicio = new string[]
        {
          /*00*/  "Prefere jogar:",
          /*01*/  " [ 1 ]  1x1 - Player x Player",
          /*02*/  " [ 2 ]  1xPC - player x Computador ",
          /*03*/  " [ 3 ]  Como Jogar ",
          /*04*/  " [ 4 ]  Configurações"
        };
        public string[] Regras = new string[]
        {
            /*00*/ //"",
            /*01*/ "Quando o jogo começar, ambos jogadores recebem 10 energias.",
            /*02*/"A cada tentativa, cada jogador terá “três cartas”\r\npara abrir.",
            /*03*/"Estas cartas serão apresentadas: \r\n1 – Gol,\r\n2 - Pênalti,\r\n3 - Falta,\r\n4 - Cartão Amarelo,\r\n5 - Cartão Vermelho,\r\n6 - Energia.",
            /*04*/"As três cartas serão abertas de forma aleatória.",
            /*05*/"Caso as três cartas apresentem o valor “GOL”, marca-se um ponto para\r\no jogador, e passa a vêz para o adversário.",
            /*06*/"Caso as três cartas apresentem o valor “ENERGIA”, o jogador ganha\r\nmais uma energia para jogar, e passa a vêz para o adversário.",
            /*07*/"Caso as três cartas apresentem o valor “PENALTI”, o jogador continuará\r\njogando e deverá escolher outras três opções (Direita, Esquerda ou\r\nCentro).",
            /*08*/"Após escolhido as três opções é a vez do adversário tentar defender.\r\n- Se a opção escolhida for diferente do jogador que cobrou o pênalti, \r\nSerá “GOL” para o jogador que fez o chute",
            /*09*/"Caso as três cartas apresentem o valor “FALTA”, o jogador passa a vêz\r\npara o adversário.",
            /*10*/"Caso as três cartas apresentem o valor “CARTÃO AMARELO”, o jogador\r\nperde UMA energia e é advertido que no próximo cartão amarelo ele\r\nperderá duas energias, e passa a vêz para o adversário.",
            /*11*/"Caso as três cartas apresentem o valor “CARTÃO VERMELHO”, o\r\n jogador perde DUAS energias, e passa a vêz para o adversário.",
            /*12*/"Em caso de as cartas não saírem iguais serão obedecidas a seguinte\r\npontuação:\r\n1 – Gol – 3 pontos,\r\n2 – Pênalti – 2 pontos,\r\n3 – Falta – 1 ponto,\r\n4 - Cartão Amarelo – 1 ponto,\r\n5 - Cartão Vermelho – 0 pontos,\r\n6 – Energia - 2 pontos.",
            /*13*/"O número de gols marcados prevalece sobre qualquer pontuação, ou\r\nseja, por mais que um jogador tenha 100 pontos, mas ele não marcou\r\nnenhum gol, caso o adversário tenha feito um único gol, ele irá ganhar o\r\njogo.",
            /*14*/"A partida irá empatar se:\r\nA) O número de gols e pontuação for igual.\r\nB) O número de pontos for igual, desde que nenhum adversário tenha\r\nmarcado gols.",
            /*15*/"A partida irá estabelecer o vencedor quando:\r\nA) O número de energias acabar de ambos jogadores.\r\nB) Caso um único jogador tiver finalizado as suas jogadas e o outro\r\njogador ainda tiver energias, o jogo irá finalizar somente quando a\r\nenergia do último jogador acabar.\r\nC) No caso de número de gols igual, verifica-se a pontuação e\r\nestabelece o vencedor com maior pontuação.",
          //  /*16*/ ""
        };

        public string[] TitulosG = new string[]
        {
            /*00*/ "████████╗██████╗  ██╗   ██╗  ██████╗   ████    ██████╗    ████    ██╗     ██╗     ",
            /*01*/ "╚══██╔══╝██╔══██╗ ██║   ██║ ██╔════╝ ██╔═══██╗ ██╔══██╗ ██╔═══██╗ ██║     ██║     ",
            /*02*/ "   ██║   ██████╔╝ ██║   ██║ ██║      ██║   ██║ ██████╔╝ ██║   ██║ ██║     ██║     ",
            /*03*/ "   ██║   ██╔══██╗ ██║   ██║ ██║      ██║   ██║ ██╔══██╗ ██║   ██║ ██║     ██║     ",
            /*04*/ "   ██║   ██║  ██║ ╚██████╔╝   █████╗   ████  ║ ██████╔╝   ████  ║ ██████╗ ██████╗ ",
            /*05*/ "   ╚═╝   ╚═╝  ╚═╝  ╚═════╝    ╚════╝   ╚═════╝ ╚═════╝    ╚═════╝ ╚═════╝ ╚═════╝ "
        };
        public string[] BolaAscii = new string[]
        {
/*00*/          "▓▓▓▓▓▓▓▓▓▓▓▓████████████",
/*01*/          "▓▓▓▓▓▓▓▓███████▒▒▒▒▒▒▒▒▒███",
/*02*/          "▓▓▓▓▓█████████▒▒▒▒▒▒▒▒▒▒▒▒████",
/*03*/          "▓▓▓▓██▒███▒▒▒▒██▒▒▒▒▒▒▒▒▒█▒▒▒██",
/*04*/          "▓▓▓█▒▒▒█▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒█▒▒▒▒▒▒██",
/*05*/          "▓▓█▒▒▒█▒▒▒▒▒▒▒▒▒▒████████▒▒▒▒▒▒▒██",
/*06*/          "▓█▒▒▒██▒▒▒▒▒▒▒▒▒█████████▒▒▒▒▒▒▒▒█",
/*07*/          "██▒▒▒█▒▒▒▒▒▒▒▒▒▒██████████▒▒▒▒▒▒▒▒█",
/*08*/          "█▒▒▒██▒▒▒▒▒▒▒▒████████████▒▒▒▒▒▒▒▒█",
/*09*/          "█▒▒█████▒▒▒███▒▒▒███████▒▒████▒▒▒██",
/*10*/          "███████████▒▒▒▒▒▒▒▒███▒▒▒▒▒▒▒▒█████",
/*11*/          "█▒███████▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒████",
/*12*/          "█▒███████▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒████",
/*13*/          "▓█▒██████▒▒▒▒▒▒▒▒▒▒██▒▒▒▒▒▒▒▒▒▒███",
/*14*/          "▓▓█▒██▒▒██▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒██▒██",
/*15*/          "▓▓▓██▒▒▒▒▒███▒▒▒▒█████▒▒▒▒███▒▒▒█",
/*16*/          "▓▓▓▓██▒▒▒▒▒▒███████████████▒▒▒██",
/*17*/          "▓▓▓▓▓███▒▒▒▒▒▒██████████▒▒▒▒██",
/*18*/          "▓▓▓▓▓▓▓████▒▒▒█████████▒▒███",
/*19*/          "▓▓▓▓▓▓▓▓▓▓█████▒▒▒▒▒▒████"

        };
        public string[] TrofeuASCII = new string[]
        {
/*00*/"        ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶ ",
/*01*/"        ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶ ",
/*02*/"   ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶ ",
/*03*/" ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶ ",
/*04*/"¶¶¶¶______¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_______¶¶¶¶ ",
/*05*/"¶¶¶_______¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶________¶¶¶ ",
/*06*/"¶¶________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶________¶¶¶ ",
/*07*/"¶¶¶_____¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶______¶¶¶ ",
/*08*/"¶¶¶____¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶____¶¶¶¶ ",
/*09*/" ¶¶¶___¶¶¶_¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_¶¶¶____¶¶¶ ",
/*10*/" ¶¶¶¶___¶¶¶_¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_¶¶¶¶__¶¶¶¶ ",
/*11*/"   ¶¶¶¶__¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_¶¶¶¶¶ ",
/*12*/"    ¶¶¶¶¶¶¶¶_¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_¶¶¶¶¶¶¶¶¶ ",
/*13*/"      ¶¶¶¶¶¶__¶¶¶¶¶¶¶¶¶¶¶¶¶¶___¶¶¶¶¶¶ ",
/*14*/"               ¶¶¶¶¶¶¶¶¶¶¶¶ ",
/*15*/"                 ¶¶¶¶¶¶¶¶ ",
/*16*/"                   ¶¶¶¶ ",
/*17*/"                   ¶¶¶¶ ",
/*18*/"                   ¶¶¶¶ ",
/*19*/"                   ¶¶¶¶ ",
/*20*/"               ¶¶¶¶¶¶¶¶¶¶¶¶ ",
/*21*/"            ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶ ",
/*22*/"            ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶ "     ,
/*23*/"      ╔════════════════════════════╗                     ",
/*24*/"      ║     pts: {0,-8}          ║ ",
/*25*/"      ║    Nome: {0,-12}      ║ ",
/*26*/"      ║     Gol: {0,-8}          ║",
/*27*/"      ╚════════════════════════════╝",
/*28*/"            ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶ ",
/*24*/"            ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶ ",
/*24*/"           ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶ "

        };
        
        public string[] CartaoAmareloArray = new string[]
        {
            "▃▃▃▃▃▃▃▃▃▃▃▃▃▃▃▃",
            "▇▇▇   CARTÃO ▇▇▇",
            "▇▇▇  AMARELO ▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇ Pts: 01▇",
            "▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔"
        };
        public string[] CartaoVermelhoArray = new string[]
        {
            "▃▃▃▃▃▃▃▃▃▃▃▃▃▃▃▃",
            "▇▇▇  CARTÃO  ▇▇▇",
            "▇▇▇ VERMELHO ▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇ Pts: 00▇",
            "▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔"
        };
        public string[] arrayGol = new string[]
        {
            "▃▃▃▃▃▃▃▃▃▃▃▃▃▃▃▃",
            "▇▇▇▇   GOL   ▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇╔═══════════╗▇",
            "▇▇║▯▯▯▯▯▯▯▯▯▯▯║▇",
            "▇▇║▯▯▯▚ ● ▞▯▯▯║▇",
            "▇▇║▯▯▯ ▘█▝ ▯▯▯║▇",
            "▇▇     ▕▕      ▇",
            "▇▇▃▃▃▃▃▃▃▃▃▃▃▃▃▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇ Pts: 03▇",
            "▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔"
        };
        public string[] arrayPenalti = new string[]
        {
            "▃▃▃▃▃▃▃▃▃▃▃▃▃▃▃▃", //00
            "▇▇▇▇ PENALTI ▇▇▇", //01
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇", //02
            "▇▇▇       ▇▇▇▇▇▇", //03
            "▇▇▇ ▇▇▇▇▇  ▇▇▇▇▇", //04
            "▇▇▇      ▇▇▇▇▇▇▇", //05
            "▇▇▇  ▇▇▇▇▇▇▇▇▇▇▇", //06
            "▇▇▇  ▇▇▇▇▇▇▇▇▇▇▇", //07
            "▇▇▇  ▇▇▇▇▇▇▇▇▇▇▇", //08
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇", //10
            "▇▇▇▇▇▇▇ Pts: 02▇", //11
            "▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔"  //12
        };
        public string[] arrayFalta = new string[]
        {
            "▃▃▃▃▃▃▃▃▃▃▃▃▃▃▃▃",
            "▇▇▇▇  FALTA  ▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇        ▇▇▇▇▇",
            "▇▇  ▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇  ▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇        ▇▇▇▇▇▇",
            "▇▇  ▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇  ▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇  ▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▇▇▇ Pts: 01▇",
            "▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔"
        };
        public string[] ArrayEnergia = new string[]
        {
            "▃▃▃▃▃▃▃▃▃▃▃▃▃▃▃▃", //00
            "▇▇▇▇ ENERGIA ▇▇▇",//01
            "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇",
            "▇▇▇▇▎    ▐▇▇▇▇▇▇", //04
            "▇▇▇▎    ▐▇▇▇▇▇▇▇", //05
            "▇▇▎          ▐▇▇", //06
            "▇▎          ▐▇▇▇", //07
            "▇▇▇▇▇▎    ▐▇▇▇▇▇", //08
            "▇▇▇▇▎   ▐▇▇▇▇▇▇▇", //09
            "▇▇▇▎  ▐▇▇▇▇▇▇▇▇▇", //10
            "▇▇▎ ▐▇▇▇▇▇▇▇▇▇▇▇", //11
            "▇▇▎▇▇▇▇ Pts: 02▇", //12
            "▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔" //13
        };
        public string[,] TuplaCards = new string[13, 6];
        public void BaralhoTupla()
        {
            for (int i = 0; i < arrayGol.Length; i++) 
            { TuplaCards[i, 0] = arrayGol[i]; }
            for (int j = 0; j < arrayPenalti.Length; j++)
            {
                TuplaCards[j,1] = arrayPenalti[j];
            }
            for (int i = 0; i < ArrayEnergia.Length; i++)
            {
                TuplaCards[i,2] = ArrayEnergia[i];
            }
            for (int i = 0; i <arrayFalta.Length; i++)
            { TuplaCards[i, 3] = arrayFalta[i]; }
            for (int i = 0;i < CartaoAmareloArray.Length; i++)
            { TuplaCards[i,4] = CartaoAmareloArray[i];}
            for (int i = 0; i < CartaoVermelhoArray.Length ; i++)
            { TuplaCards[i,5] = CartaoVermelhoArray[i];}
        }
        public void Creditos()
        {
            int AlturaTela = Console.WindowHeight - 4;
            Console.SetCursorPosition(0, AlturaTela);
            Console.WriteLine(textoJogo[18]);
            Console.WriteLine(textoJogo[19]);
            Console.WriteLine(textoJogo[20]);
        }
        public void TituloGrande()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            for (int i = 0; i <6; i++) 
            { 
                Thread.Sleep(250);
                Console.WriteLine(this.TitulosG[i].PadLeft(Console.WindowWidth / 2 + this.TitulosG[i].Length / 2));
            }
            Console.WriteLine("\n \n \n \n");
            Console.WriteLine(this.textoJogo[21].PadLeft(Console.WindowWidth / 2 + this.textoJogo[21].Length / 2));//("Pressione qualquer tecla pra continuar: ");
            Creditos();
            Console.ReadKey();
            Console.Clear();
        }
        public void DimensaoTela()
        {
            AlTela = Console.WindowHeight;
            LaTela = Console.WindowWidth;
    }
        public void CreditoFinais()
        {
            listCreditos.AddRange(this.TitulosG);
            listCreditos.AddRange(new List<string>
{
                "",
    "Materia: Programação Orientada Objetos II",
    "Prof Cesar",
    "",
    "DESENVOLVEDORES:",
    "Jeú Victor",
    "Gabriella França",
    "Gabriel Bento",
    "Fernando Gutemberg",
    "Vitor Leopoldo",
    "",
    "",
    "",
    " OBRIGADO POR JOGAR! "
});
            int a = 0;
            int j = 0;
            int AlturaTela = Console.WindowHeight;
            int LarguraTela = Console.WindowWidth;
            int z = (LarguraTela / 2) - 10;
            int VariavelControle = AlturaTela - 19;
            List<string> listFinal = new List<string>();
            for (int i = AlturaTela; i > 0; i--)
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                if (i < VariavelControle && i >= 1)
                {
                    listCreditos.Add(" ");
                }
                listFinal.Add(listCreditos[a]);
                j = i - 2;
                if (j > 0)
                {
                    Thread.Sleep(450);
                    Console.Clear();
                    Console.SetCursorPosition(0, j);
                    int larguraMaxima = listFinal.Max(item => item.Length);
                    foreach (string item in listFinal)
                    {
                        int espacosEsquerda = (LarguraTela / 2) - (item.Length / 2);
                        Console.WriteLine($"{new string(' ', espacosEsquerda)}{item}");
                    }
                }
                a++;
            }
        }
        
        public void CartaoAmareloAcao() 
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n \n \n \n");
            foreach (string C in  CartaoAmareloArray) {  Console.WriteLine(C); }
            Console.ResetColor();
        }
        public void CartaoVermelhoAcao()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n \n \n \n");
            foreach (string A in CartaoVermelhoArray) { Console.WriteLine(A); }
            Console.ResetColor();
            Console.Clear();
        }
        public void GolAcao()
        {
            Console.ForegroundColor= ConsoleColor.DarkGreen;
            string[] CapiGol = new string[] 
            {
                "           ヘ───ヘ      ",
                "　＿／　 　　＼      ",
                "  ／ 　    　^  ^＼   ",
                "｜ 　　　　　▼　  |    ",
                "           ｜　　　　　　ɞ  ノ -GOOOOLLLLL!!! ",
                "  U￣U￣￣￣￣U￣U     "
            };
            DimensaoTela();
            AlTela = AlTela / 2 - 10;
            foreach (string C in CapiGol)
            {
                LaTela = (Console.WindowWidth / 2)-(C.Length/2);
                AlTela += 1;
                Console.SetCursorPosition(LaTela, AlTela);
                Console.WriteLine(C);
            }
            Console.ResetColor();
            
            
                           // "01020304050607080910,5"
        }
        public void PenaltiAcao()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            foreach (string p in arrayPenalti) { Console.WriteLine(p); }
              
                Console.ResetColor();
            
        }
        public void FaltaAcao()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach(string f in arrayFalta) {  Console.WriteLine(f); }

                Console.ResetColor();
            
        }
        public void EnergiaAcao()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach (string e in ArrayEnergia) { Console.WriteLine(e); }
                                             //"0102030405060708" 16 de largura
       
                Console.ResetColor();
            
        }
    }
}
