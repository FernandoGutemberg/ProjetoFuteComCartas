#ProjetoFutComCartas

Criar um jogo onde o usuário jogará será sorteado 3 cartas com efeitos podendo ser benéficos ou não.
                                                                                                      
RELATÓRIO

No dia 28 de março de 2023 foi apresentado pelo professor Cesar Ferreira da disciplina de Programação Orientada a Objetos II, como trabalho de 25 pontos, a realização, em grupo, o de um jogo para a empresa xPlayB2. 

Jogo TRUCOBOLL

Divisão do trabalho: 
1.	Foi executado pelo Fernando Gutemberg a criação de 2 classes, a PlayerX e a CartasJogos. 
2.	Foi executado pela Gabriella França o Objeto cartas, variáveis e ações. 
3.	Foi executado pelo Gabriel Bento implementação da classe player.
4.	Foi executado pelo Jeú Victor o jogo em projeto mínimo viável
5.	Foi executado pelo Victor Leopoldo a estética, início e instruções

O projeto foi dividido em 5 classes, sendo essas:
1)	Textos
2)	ConfGeral
3)	CartasJogos
4)	PlayerX
5)	E a mais importante a Program

Na Classe Textos foi criado varias Arrays de partes importantes de textos e mensagens que usamos no código para visualização do cliente.


No Array TextoJogo foi colocado as principais mensagens de que aparecem na tela ao iniciar a aplicação.


Também foi criado os Arrays para as Regras do jogo e alguns menus de interação para o usuário 


Nessa Classe também tem as funções e construtores:
BaralhoTuplas, onde é extremamente importante para o formato que as cartas vão aparecer na tela.

Créditos, onde está a lógica para os créditos aparecerem no final da tela
TituloGrande, onde é tem a lógica para que fique centralizado no começo do jogo,
E a CreditosFinais, onde é feito uma animação de créditos subindo na tela e os agradecimentos.


E outros são referentes as ações das cartas
Todas as demais classes vão herdar a classe textos para simplificar a utilização das mensagens.
A Classe ConfGeral foi a mais recente criação, foi pensando para diminuir a quantidade de código da classe Program.

Nela é possível outros construtores e funções: Apresentação, é a segunda tela que usuário vai visualizar, e será apresentado a lógica que permite escolher 1x1, 1xPc, Modo Dev (escolhe as cartas que vai jogar) e as regras do jogo.

E redimensionandoTela, foi criada para evitar certos erros, quando o texto que o console imprime na tela for maior que o tamanho da janela, nesse caso, delimitamos um tamanho que consideramos necessário.
Na Classe CartaJogo, o mais importante é o sorteio das cartas e sua lógica 


Essa lógica consiste em dividir a tela em 3 aéreas distintas, e utilizar o Console.SetCursorPosition para definir o local certo de cada uma das cartas (dessa forma ficando uma ao lado da outra).

Também utilizamos um Switch para que fosse possível colorir apenas a determinada carta que foi impressa.


Toda vez que é sorteado uma carta, o sorteio vai para uma lista e deixa salvo até completar os 3 sorteios, após isso é feito uma verificação se as cartas são iguais ou não.
Se iguais, ativa um boleano para a sua ação
O restante do código se direciona a parte do efeito das cartas
A classe Program é a principal pois é a que chama todas as  funções e criar os principais objetos (player 1, Player 2, cartas e a tela), ela utiliza um Radom para decidir quem será o primeiro a jogar e um Do While para durar enquanto as energias ainda não foram gastas.

A rodada é definida por um boleano, sempre que a jogada termina muda o valor pra seu inverso e assim começa a rodada pro outro player.

O penalti é feito antes de iniciar a rodada, pois assim ficou mais simples de implementar a movimentação dos dois jogadores 

E no final é utilizado uma sequência de 4 if e um Else para encerrar a partida e decidir o jogador, respeitando a regra que o campeão é o de mais gols ou que tiver mais pontos em caso de empate de gols.



