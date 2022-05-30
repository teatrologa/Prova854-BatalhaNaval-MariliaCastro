


using System.Text.RegularExpressions;

var posicao = "F10G10";
//var num = "";

Regex regexVerificacao = new Regex(@"^([A-J][0-9]{1,2}){2}$");
Regex regexCorte = new Regex(@"([A-J])([0-9]{1,2})");



//var x1 = Char.ConvertToUtf32(posicaoInicial, 0) - 65;


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


Console.WriteLine(posicaoCortada);
Console.WriteLine(posicaoFinal);
Console.WriteLine(posicaoInicial);
Console.WriteLine(x1);
Console.WriteLine(y1);
Console.WriteLine(x2);
Console.WriteLine(y2);
Console.ReadKey();