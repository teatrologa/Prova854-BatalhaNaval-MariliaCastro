

// string[,] tabuleiro = new string[10, 10];

// List<string> linhasCabecalho = new List<string>(10) { "  A", "  B", "  C", "  D", "  E", "  F", "  G", "  H", "  I", "  J" };
// Console.WriteLine("");


// Console.WriteLine("    1  2  3  4  5  6  7  8  9  10");
// for (int i = 0; i < 10; i++)
// {
//     Console.Write(linhasCabecalho[i]);
//     for (int j = 0; j < 10; j++)
//     {
//         Console.Write($" {(tabuleiro[i, j] == null ? ".." : tabuleiro[i, j])}");
//         //▒▒
//     }
//     Console.WriteLine(" ");
// }
// Console.WriteLine("");



using System.Text.RegularExpressions;

var posicao = "A10B1";

Regex regexVerificacao = new Regex(@"^([A-J][0-9]{1,2}){2}$");
Regex regexCorte = new Regex(@"([A-Z])([0-9]{1,2})");


var posicaoCortada = regexCorte.Matches(posicao).ToArray();
var posicaoInicial = posicaoCortada[0].Value;
var posicaoFinal = posicaoCortada[1].Value;

Console.WriteLine(posicaoInicial);
Console.WriteLine(posicaoFinal);

