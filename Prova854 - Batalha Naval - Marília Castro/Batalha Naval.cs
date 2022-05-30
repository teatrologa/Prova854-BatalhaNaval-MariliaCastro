

//======= Crie um jogo de batalha naval onde 2 jogadores podem participar =======

//=== Sobre o jogo ===

//Batalha naval é um jogo de tabuleiro de dois jogadores, no qual os jogadores têm de adivinhar em que quadrados estão os navios do oponente.
//Cada jogador possui seu próprio tabuleiro de dimensão 10x10
//onde as linhas são representadas por letras (A-J) e as colunas são representadas por números (1-10).
//Os jogadores devem posicionar suas embarcações dentro dos quadrantes correspondentes.
//As embarcações devem ser posicionadas na vertical ou horizontal sempre formando uma reta e nunca em diagonal.
//Cada jodagor pode disparar uma vez em cada turno e para efetuar o disparo ele deve informar a posição do quadrante por letra e número.
//Exemplo: E7.

//Caso o disparo acerte uma embarcação aquele local é sinalizado.
//Quando um navio receber todos os disparos ele afunda.
//O jodo termina quando um dos dois jogadores afundar todos os navios do seu oponente.

//Cada jogador possui as seguintes embarcações:

//1 Porta-Aviões (5 quadrantes)
//2 Navio-Tanque (4 quadrantes)
//3 Destroyers (3 quadrantes)
//4 Submarinos (2 quadrantes)
//Definições e regras do programa
//Jogando contra outro oponente


//1. Programa pergunta se o jogo será entre dois jogadores reais ou se vai jogar sozinho, ou seja, contra o computador.

//2. Caso seja contra outro oponente, o programa pergunta o nome do primeiro jogador e armazena.

//3. Depois de armazenar o nome do primeiro jogador o programa pergunta o nome do segundo jogador e armazena.

//4. Após armazenar ambos os nomes o programa pergunta ao jogador onde ele vai posicionar cada um dos navios.

//5. Os navios são identificados por siglas:

//PS - Porta-Aviões (5 quadrantes)
//NT - Navio-Tanque (4 quadrantes)
//DS - Destroyers (3 quadrantes)
//SB - Submarinos (2 quadrantes)

//6. O programa pergunta qual o tipo de embarcação e em seguida a posição inicial e a final. Exemplo: [IMAGEM NO CLASS]

// Console.WriteLine("Qual o tipo de embarcação?")
// var embarcacao = Console.ReadLine();
// // input: SB
// Console.WriteLine("Qual a sua posição?")
// // input: H1H2
// Console.WriteLine("Qual o tipo de embarcação?")
// var embarcacao = Console.ReadLine();
// // input: SB
// Console.WriteLine("Qual a sua posição?")
// // input: F6G6


//7. O programa repete as instruções até que o primeiro jogador termine de posicionar os navios.

//8. Quando os dois jogadores terminarem de colocar os navios o jogo começa.

//9. Quando o jogador for efetuar um disparo o pregrama recebe a posição indicada e verifica se acertou o navio.


//======= Regras Gerais =======

//- O programa só deve receber entradas válidas, ou seja, a sigla deve ser alguma das correspondentes.
//- A embarcação não pode ser de um tamnaho maior do que o especificado para cada uma delas.
//- Uma embarcação não pode sobrepor a outra.
//- Um mapa do campo adversario deve ser mostrado cada vez que o jogador for efetuar um disparo.
//- O mapa deve representar os espaços da seguinte maneira:
//- Em branco: Espaços que não receberam disparos
//- Letra 'A': Espaço que recebeu disparo mas não tinha embarcação
//- Letra 'X': Espaço que recebeu disparo e tinha uma embarcação.
//- A cada turno o programa deve limpar a tela e apresentar o tabuleiro adversário
//- Quando um disparo for certeiro o programa deve apresentar uma mensagem e também quando o disparo for errado.


// */


using System.Text.RegularExpressions;

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
    var opcaoMenu = Console.ReadLine();
    while (String.IsNullOrEmpty(opcaoMenu))
    {
        Console.WriteLine("Por favor, digite uma opção válida.");
        opcaoMenu = Console.ReadLine();
    }
    intOpcaoMenu = Int32.Parse(opcaoMenu);


    if (intOpcaoMenu == 0)
    {
        break;
    }

    else if (intOpcaoMenu == 1)
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Iniciando Jogo");
        Console.ReadLine();
        BatalhaNaval jogo = new BatalhaNaval();
        jogo.IniciarJogo();
    }

    else if (intOpcaoMenu == 2)
    {
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine("                                        ====== REGRAS ======                                           ");
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
        Console.WriteLine(" - Aperte qualquer tecla para voltar ao menu.");
        Console.ReadKey();
        //Escrever que ENTRE volta para o menu principal.
    }

    else 
    {
        Console.Clear();
        Console.WriteLine("Opção Inválida!");
        Console.WriteLine("Aperte qualquer tecla e volte ao menu.");
        Console.ReadKey();
    }


}

public class BatalhaNaval
{
    public List<Jogador> Participantes = new List<Jogador>();
    public Dictionary<string, Embarcacao> Pecas = new Dictionary<string, Embarcacao>(){
        {"PS", new Embarcacao("Porta-avioes","PS", 5)},
        {"NT", new Embarcacao("Navio Tanque","NT", 4)},
        {"DS", new Embarcacao("Destroyer","DS", 3)},
        {"SB", new Embarcacao("Submarino", "SB", 2)},
    };

    int turnoDoJogador = 0;

    public void IniciarJogo()
    {
        Console.WriteLine("Batalha Naval é um jogo de estratégia onde disputam 2 participantes.");
        Console.WriteLine("Jogador 1, pegue o comando e vamos começar!");
        Console.ReadLine();

        Jogador jogador1 = IniciarJogador(1);
        Jogador jogador2 = IniciarJogador(2);
        Jogador[] jogadores = new Jogador[2] { jogador1, jogador2 };


        while (true)
        {
            turnoDoJogador = turnoDoJogador == 0 ? 1 : 0;
            var atacante = jogadores[turnoDoJogador];
            var defensor = jogadores[turnoDoJogador == 0 ? 1 : 0];
           

            Console.WriteLine($"O jogo já vai começar. Passe o controle para {atacante.Nome}");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"{atacante.Nome} é o seu turno!");
            MostrarTabuleiro(defensor.TabuleiroAtaque);
            Console.WriteLine("Insira abaixo uma posição para atacar [ex: B2]");
            var ataque = Console.ReadLine();
            int ataqueX;
            int ataqueY;
            int ataqueXInicial;
           



            while (String.IsNullOrEmpty(ataque))
            {
                Regex regexCoordenada = new Regex(@"([A-J])([0-9]{1,2})");


                if (!String.IsNullOrEmpty(ataque) && regexCoordenada.Match(ataque).Success)
                {
                    ataque = ataque.ToUpper();
                    ataqueXInicial = Convert.ToInt32(ataque[0]);
                    ataqueX = ataqueXInicial - 65;
                    ataqueY = Int32.Parse(ataque.Substring(1));

                    if (defensor.TabuleiroAtaque[ataqueX, ataqueY] != "..")
                    {
                        Console.WriteLine("Posição já escolhida, tente outra!");
                        continue;
                    }



                }



            }


            ataque = ataque.ToUpper();

            ataqueXInicial = Convert.ToInt32(ataque[0]);
            ataqueX = ataqueXInicial - 65;
            ataqueY = Int32.Parse(ataque.Substring(1));
            if (defensor.TabuleiroEntradas[ataqueX, ataqueY] != "..")
            {

                defensor.TabuleiroAtaque[ataqueX, ataqueY] = "X";
                MostrarTabuleiro(defensor.TabuleiroAtaque);
                Console.WriteLine("Parabéns, você acertou!!!");
                Console.WriteLine("Dê 'enter' e passe para o oponente");
                Console.ReadLine();
                atacante.Pontuacao++;
                if (atacante.Pontuacao == 30){
                    Console.Clear();
                    Console.WriteLine ($"PARABÉNS {atacante.Nome}!");
                    Console.WriteLine ("VOCÊ É O VENCEDOR DESSA BATALHA!");
                    Console.ReadLine();
                    break;
                }

            }
            else
            {
                defensor.TabuleiroAtaque[ataqueX, ataqueY] = "A";
                MostrarTabuleiro(defensor.TabuleiroAtaque);
                Console.WriteLine("Opa, não foi dessa vez. Você acertou na água!!");
                Console.WriteLine("Dê 'enter' e passe para o oponente");
                Console.ReadLine();

            }




            // entradas dos jogadores
            // loop()

            // == loop ==
            // ataque jogador X
            // - entrada correta
            // - verificar se acertou o navio
            // - alterar/adicionar marcação de posição
            // - render tabuleiro
        }
    }

    public Jogador IniciarJogador(int numeroJogador)
    {
        Console.Clear();
        Console.WriteLine($"Você será o Jogador nº{numeroJogador}, por favor digite seu nome abaixo: ");
        var nome = (Console.ReadLine());
        while (String.IsNullOrEmpty(nome))
        {
            Console.WriteLine("Por favor, digite como gostaria de ser chamado.");
            nome = Console.ReadLine();
        }

        var tabuleiro = EntradaTabuleiro();
        var jogador = new Jogador(nome, tabuleiro);
        jogador.TabuleiroAtaque = IniciarTabuleiro();

        return jogador;
    }

    public void MostrarCabecalho(string[,] tabuleiro, Dictionary<string, int> quantidadePecas)
    {

        Console.Clear();
        Console.WriteLine("Comece agora a preencher o seu tabuleiro com suas embarcações.");
        Console.WriteLine("Veja abaixo quais são suas opções e boa sorte!");
        Console.WriteLine("");
        Console.WriteLine("");
        MostrarTabuleiro(tabuleiro);
        Console.WriteLine("---------------------------Lista de Embarcações---------------------------");
        Console.WriteLine("Peça \t\t\t Tamanho \t\t\t Quantidade");

        foreach (var peca in Pecas.Values)
        {
            Console.WriteLine($"({peca.Icone}) {peca.Nome}   \t {peca.Tamanho} casas \t\t\t {quantidadePecas[peca.Icone]}");
        }
        Console.WriteLine(" ");

    }

    public string[,] EntradaTabuleiro()
    {
        string[,] tabuleiro = IniciarTabuleiro();

        Dictionary<string, int> quantidadePecas = new Dictionary<string, int>()
        {
        {"PS", 1},
        {"NT", 2},
        {"DS", 3},
        {"SB", 4}
        };

        int quantidadeTotalPecas = 10;


        while (quantidadeTotalPecas > 0)
        {
            MostrarCabecalho(tabuleiro, quantidadePecas);

            Console.WriteLine("Escolha qual embarcação você vai inserir: [digite a sigla correspondente, ex: SB]");

            var pecaEscolhida = Console.ReadLine();
            pecaEscolhida = pecaEscolhida.ToUpper().Trim();


            do
            {

                if (String.IsNullOrEmpty(pecaEscolhida) || !Pecas.Keys.Contains(pecaEscolhida.ToUpper()))
                {
                    Console.WriteLine("Escolha inválida, tente novamente!");
                    Console.WriteLine("Escolha qual embarcação você vai inserir: [digite a sigla correspondente, ex: SB]");
                    pecaEscolhida = Console.ReadLine();

                }
                else if (quantidadePecas[pecaEscolhida] <= 0)
                {
                    Console.WriteLine("Acabaram-se este tipo de embarcações, aloque as demais!");
                    pecaEscolhida = Console.ReadLine();

                }

            } while (String.IsNullOrEmpty(pecaEscolhida) || !Pecas.Keys.Contains(pecaEscolhida.ToUpper()) || quantidadePecas[pecaEscolhida] <= 0);

        

            MostrarCabecalho(tabuleiro, quantidadePecas);
            Console.WriteLine("Insira a posição da sua embarcação: [ex: A1B1]");
            var posicaoEscolhida = Console.ReadLine();
            posicaoEscolhida = posicaoEscolhida.ToUpper().Trim(); //Eu vi o aviso (os anteriores também) mas só assim garanto que ela vai vir certinha, maisculo e sem espaço.

            while (String.IsNullOrEmpty(posicaoEscolhida) || !verificarPosicaoValida(posicaoEscolhida, pecaEscolhida, tabuleiro))
            {
                Console.WriteLine("Escolha inválida, tente novamente!");
                Console.WriteLine("Dê 'enter' para reescrever!");
                Console.Read();
                Console.WriteLine("Insira a posição da sua embarcação: [ex: A1B1]");
                posicaoEscolhida = Console.ReadLine();
            }
            posicaoEscolhida = posicaoEscolhida.ToUpper().Trim();

            tabuleiro = PreencherTabuleiro(posicaoEscolhida, pecaEscolhida, tabuleiro);

            quantidadePecas[pecaEscolhida]--;

            quantidadeTotalPecas--;
        }

        return tabuleiro;

    }

    public string[,] PreencherTabuleiro(string posicao, string pecaEscolhida, string[,] tabuleiro)
    {
        Regex regexCorte = new Regex(@"([A-J])([0-9]{1,2})");

        var posicaoCortada = regexCorte.Matches(posicao).ToArray();
        var posicaoInicial = posicaoCortada[0].Value;
        var posicaoFinal = posicaoCortada[1].Value;
        var posicaoXInicial = Convert.ToInt32(posicaoInicial[0]);
        
        var x1 = posicaoXInicial - 65;
        //var x1 = Convert.ToInt32(posicaoInicial.Substring(0, 1)) - 65;
        var y1 = Int32.Parse(posicaoInicial.Substring(1));


        var posicaoXFinal = Convert.ToInt32(posicaoFinal[0]);
        var x2 = posicaoXFinal - 65;
        //var x2 = Convert.ToInt32(posicaoFinal.Substring(0, 1)) - 65;
        var y2 = Int32.Parse(posicaoFinal.Substring(1));

        if (x1 == x2)
        {
            if (y2 > y1)
            {
                for (int i = y1; i <= y2; i++)
                {
                    tabuleiro[x1, i] = Pecas[pecaEscolhida].Icone;
                }
            }
            else
            {
                for (int i = y2; i <= y1; i++)
                {
                    tabuleiro[x1, i] = Pecas[pecaEscolhida].Icone;
                }
            }
        }
        else
        {
            if (x2 > x1)
            {
                for (int i = x1; i <= x2; i++)
                {
                    tabuleiro[i, y1] = Pecas[pecaEscolhida].Icone;
                }
            }
            else
            {
                for (int i = x2; i <= x1; i++)
                {
                    tabuleiro[i, y1] = Pecas[pecaEscolhida].Icone;
                }
            }

        }

        return tabuleiro;
    }

    public bool verificarPosicaoValida(string posicao, string pecaEscolhida, string[,] tabuleiro)
    {
        Regex regexVerificacao = new Regex(@"^([A-J][0-9]{1,2}){2}$");
        Regex regexCorte = new Regex(@"([A-J])([0-9]{1,2})");

        if (!regexVerificacao.Match(posicao).Success) return false;

        var posicaoCortada = regexCorte.Matches(posicao).ToArray();
        var posicaoInicial = posicaoCortada[0].Value;
        var posicaoFinal = posicaoCortada[1].Value;
        var posicaoXInicial = Convert.ToInt32(posicaoInicial[0]);
        var posicaoXFinal = Convert.ToInt32(posicaoFinal[0]);

        var x1 = posicaoXInicial - 65;
        var y1 = Int32.Parse(posicaoInicial.Substring(1));

        var x2 = posicaoXFinal - 65;
        var y2 = Int32.Parse(posicaoFinal.Substring(1));

        if (x2 != x1 && y2 != y1)
        {
            Console.WriteLine("Impossível alocar sua embarcação em uma diagonal. Por favor, realoque.");
            return false;
        }

        if (Math.Abs(x2 - x1) != Pecas[pecaEscolhida].Tamanho && Math.Abs(y2 - y1) != Pecas[pecaEscolhida].Tamanho)
        {

            Console.WriteLine("A distância das coordendas é diferente do tamanho da peça escolhida");
            return false;
        }



        if (x1 == x2)
        {
            if (y2 > y1)
            {
                for (int i = y1; i <= y2; i++) // percorre as colunas entre y1 e y2
                {
                    if (tabuleiro[x1, i] != "..") //sobreposição dos barcos
                    {
                        Console.WriteLine("Sinto muito, você já colocou um barco nessa posição.");
                        Console.WriteLine("Infelizmente, para nós meros mortais, dois corpos não ocupam o mesmo espaço no universo.");
                        return false;
                    };
                }
            }
            else
            {
                for (int i = y2; i <= y1; i++)
                {
                    if (tabuleiro[x1, i] != "..")
                    {

                        Console.WriteLine("Sinto muito, você já colocou um barco nessa posição.");
                        Console.WriteLine("Infelizmente, para nós meros mortais, dois corpos não ocupam o mesmo espaço no universo.");
                        return false;
                    };
                }


            }
        }
        else // ainda sobreposição
        {
            if (x2 > x1)
            {
                for (int i = x1; i <= x2; i++) // percorre a linha indo de x1 até x2
                {
                    if (tabuleiro[i, y1] != "..")
                    {
                        Console.WriteLine("Sinto muito, você já colocou um barco nessa posição.");
                        Console.WriteLine("Infelizmente, para nós meros mortais, dois corpos não ocupam o mesmo espaço no universo.");
                        return false;
                    };
                }
            }
            else
            {
                for (int i = x2; i <= x1; i++)
                {
                    if (tabuleiro[i, y1] != "..")
                    {
                        Console.WriteLine("Sinto muito, você já colocou um barco nessa posição.");
                        Console.WriteLine("Infelizmente, para nós meros mortais, dois corpos não ocupam o mesmo espaço no universo.");
                        return false;
                    };
                }
            }
        }

        return true;
    }

    public string[,] IniciarTabuleiro()
    {
        string[,] tabuleiro = new string[10, 10];

        int tamanhoLinha = tabuleiro.GetLength(0);  //GetLenght(0) pega a quantidade de numero da linha
        int tamanhoColuna = tabuleiro.GetLength(1);  //GetLenght(1) pega a quantidade de numero da coluna


        for (int linha = 0; linha < tamanhoLinha; linha++)
        {
            for (int coluna = 0; coluna < tamanhoColuna; coluna++)
            {
                tabuleiro[linha, coluna] = "..";
            }
        }
        return tabuleiro;
    }

    public void MostrarTabuleiro(string[,] tabuleiro)
    {
        int tamanhoLinha = tabuleiro.GetLength(0);  //GetLenght(0) pega a quantidade de numero da linha
        int tamanhoColuna = tabuleiro.GetLength(1);  //GetLenght(1) pega a quantidade de numero da coluna

        for (int linha = 0; linha < tamanhoLinha; linha++)
        {
            if (linha == 0) Console.Write("  ");
            Console.Write(linha + 1 + "   ");
        }
        Console.WriteLine();

        for (int linha = 0; linha < tamanhoLinha; linha++)
        {
            char letra = Convert.ToChar(65 + linha); //toChar 65, pois o 65 começa o alfabeto A 65 = A 

            Console.Write(letra);
            for (int coluna = 0; coluna < tamanhoColuna; coluna++)
            {
                Console.Write(" ");
                Console.Write(tabuleiro[linha, coluna]); // "  " ".."
                if (coluna < tamanhoColuna - 1) Console.Write(" ");
            }
            Console.WriteLine();
        }

    }


}



public class Embarcacao
{

    public int Tamanho { get; }
    public string Nome { get; }
    public string Icone { get; }

    public Embarcacao(string nome, string icone, int tamanho)
    {
        Nome = nome;
        Tamanho = tamanho;
        Icone = icone;
    }
}

public class Jogador
{
    public string Nome { get; }
    public int Pontuacao {get; set;} = 0;
    public string[,] TabuleiroEntradas { get; } = new string[10, 10];
    public string[,] TabuleiroAtaque { get; set; } = new string[10, 10];

    public Jogador(string nome, string[,] tabuleiro)
    {
        Nome = nome;
        TabuleiroEntradas = tabuleiro;

    }



}