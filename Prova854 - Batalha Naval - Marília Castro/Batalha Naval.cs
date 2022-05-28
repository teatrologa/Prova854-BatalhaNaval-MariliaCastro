/*


======= Crie um jogo de batalha naval onde 2 jogadores podem participar =======

=== Sobre o jogo ===

Batalha naval é um jogo de tabuleiro de dois jogadores, no qual os jogadores têm de adivinhar em que quadrados estão os navios do oponente.
Cada jogador possui seu próprio tabuleiro de dimensão 10x10
onde as linhas são representadas por letras (A-J) e as colunas são representadas por números (1-10).
Os jogadores devem posicionar suas embarcações dentro dos quadrantes correspondentes.
As embarcações devem ser posicionadas na vertical ou horizontal sempre formando uma reta e nunca em diagonal.
Cada jodagor pode disparar uma vez em cada turno e para efetuar o disparo ele deve informar a posição do quadrante por letra e número.
Exemplo: E7.

Caso o disparo acerte uma embarcação aquele local é sinalizado.
Quando um navio receber todos os disparos ele afunda.
O jodo termina quando um dos dois jogadores afundar todos os navios do seu oponente.

Cada jogador possui as seguintes embarcações:

1 Porta-Aviões (5 quadrantes)
2 Navio-Tanque (4 quadrantes)
3 Destroyers (3 quadrantes)
4 Submarinos (2 quadrantes)
Definições e regras do programa
Jogando contra outro oponente


1. Programa pergunta se o jogo será entre dois jogadores reais ou se vai jogar sozinho, ou seja, contra o computador.

2. Caso seja contra outro oponente, o programa pergunta o nome do primeiro jogador e armazena.

3. Depois de armazenar o nome do primeiro jogador o programa pergunta o nome do segundo jogador e armazena.

4. Após armazenar ambos os nomes o programa pergunta ao jogador onde ele vai posicionar cada um dos navios.

5. Os navios são identificados por siglas:

PS - Porta-Aviões (5 quadrantes)
NT - Navio-Tanque (4 quadrantes)
DS - Destroyers (3 quadrantes)
SB - Submarinos (2 quadrantes)

6. O programa pergunta qual o tipo de embarcação e em seguida a posição inicial e a final. Exemplo: [IMAGEM NO CLASS]

 Console.WriteLine("Qual o tipo de embarcação?")
 var embarcacao = Console.ReadLine();
 // input: SB
 Console.WriteLine("Qual a sua posição?")
 // input: H1H2
 Console.WriteLine("Qual o tipo de embarcação?")
 var embarcacao = Console.ReadLine();
 // input: SB
 Console.WriteLine("Qual a sua posição?")
 // input: F6G6

 
7. O programa repete as instruções até que o primeiro jogador termine de posicionar os navios.

8. Quando os dois jogadores terminarem de colocar os navios o jogo começa.

9. Quando o jogador for efetuar um disparo o pregrama recebe a posição indicada e verifica se acertou o navio.
 

======= Regras Gerais =======

- O programa só deve receber entradas válidas, ou seja, a sigla deve ser alguma das correspondentes.
- A embarcação não pode ser de um tamnaho maior do que o especificado para cada uma delas.
- Uma embarcação não pode sobrepor a outra.
- Um mapa do campo adversario deve ser mostrado cada vez que o jogador for efetuar um disparo.
- O mapa deve representar os espaços da seguinte maneira:
- Em branco: Espaços que não receberam disparos
- Letra 'A': Espaço que recebeu disparo mas não tinha embarcação
- Letra 'X': Espaço que recebeu disparo e tinha uma embarcação.
- A cada turno o programa deve limpar a tela e apresentar o tabuleiro adversário
- Quando um disparo for certeiro o programa deve apresentar uma mensagem e também quando o disparo for errado.


 */


Console.WriteLine("============================");
Console.WriteLine("|                          |");
Console.WriteLine("|                          |");
Console.WriteLine("|        SE PREPARE        |");
Console.WriteLine("|        PARA JOGAR        |");
Console.WriteLine("|                          |");
Console.WriteLine("|                          |");
Console.WriteLine("============================");
Console.ReadLine();
Console.Clear();

Console.WriteLine("============================");
Console.WriteLine("|                          |");
Console.WriteLine("|                          |");
Console.WriteLine("|      BATALHA NAVAL       |");
Console.WriteLine("|                          |");
Console.WriteLine("|                          |");
Console.WriteLine("============================");
Console.ReadLine();
Console.Clear();

int intOpcaoMenu = 1;
while (intOpcaoMenu != 0)
{
    Console.Clear();
    Console.WriteLine(" ");
    Console.WriteLine("Bem vindo ao menu principal!");
    Console.WriteLine("Escolha uma das opção abaixo e digite seu número correspondente.");
    Console.WriteLine(" ");
    Console.WriteLine("1. Iniciar Jogo");
    Console.WriteLine("2. Regras e Como de Jogar");
    Console.WriteLine("0. Fechar Jogo");
    string opcaoMenu = Console.ReadLine ();
    intOpcaoMenu = Convert.ToInt32(opcaoMenu);

    if (intOpcaoMenu == 0)
    {
        break;
    }

    else if (intOpcaoMenu == 1)
    {
        Console.Clear();
        Console.WriteLine("Iniciando Jogo");
        entradaDados();
    }

    else if (intOpcaoMenu == 2)
    {
        Console.Clear();
        Console.WriteLine("====== REGRAS ======");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("Batalha naval é um jogo de tabuleiro de dois jogadores,");
        Console.WriteLine("no qual os jogadores têm de adivinhar em que quadrados estão os navios do oponente.");
        Console.WriteLine(" ");
        Console.WriteLine("Cada jogador possui seu próprio tabuleiro de dimensão 10x10");
        Console.WriteLine("onde as linhas são representadas por letras(A - J) e as colunas são representadas por números(1 - 10).");
        Console.WriteLine(" ");
        Console.WriteLine("Os jogadores devem posicionar suas embarcações dentro dos quadrantes correspondentes.");
        Console.WriteLine("As embarcações devem ser posicionadas na vertical ou horizontal sempre formando uma reta e nunca em diagonal.");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("‣ Aperte qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    else //DESCOBRIR COMO APENAS ACEITAR NUMERO E NÃO LETRA
    {
        Console.Clear();
        Console.WriteLine("Opção Inválida!");
        Console.WriteLine("Aperte qualquer tecla e volte ao menu.");
        Console.ReadKey();
    }



}

  static void entradaDados ()
{
    var jogador1 = "";
    var jogador2 = "";

    List<string> jogadores = new List<string> ();

    Console.Clear ();
    Console.WriteLine(" ");
    Console.WriteLine("Jogador nº1, digite seu nome abaixo: ");
    jogador1 = Console.ReadLine ();
    jogadores.Add (jogador1);

    Console.Clear();
    Console.WriteLine(" ");
    Console.WriteLine("Jogador nº2, agora é a sua vez, digite seu nome abaixo: ");
    jogador2 = Console.ReadLine();
    jogadores.Add (jogador2);

    Console.Clear(); //ESTÁ VOLTANDO PARA O MENU PRINCIPAL, CORRIGIR ISSO
    Console.WriteLine(" ");
    Console.WriteLine("Muito bem " + jogadores[0] + " e " + jogadores[1] + "!" );
    Console.WriteLine("O jogo já vai começar!");
    Console.WriteLine("Passe o comando para " + jogadores[0] + ", por favor.");
}