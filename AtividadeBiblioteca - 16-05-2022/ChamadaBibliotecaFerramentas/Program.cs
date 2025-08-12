

using FeramentasBiblioteca.Validacoes;

Console.WriteLine(" ");

ValidacoesSociais objetoValicoes = new ValidacoesSociais();

//Console.WriteLine(" O cnpj para  teste de validação é esse --> 04.796.015/0001-69");
Console.WriteLine(" ");

string testeCNPJ = "04796015000169";
    
bool sitacaoCNPJ =   ValidacoesSociais.ValidarCNPJ(testeCNPJ);


Console.WriteLine(" ");
/*
if (sitacaoCNPJ==true)
{
    Console.WriteLine(" ");
    Console.WriteLine(" O CNPJ é valido ");
    Console.WriteLine(" ");
}
else
{
    Console.WriteLine(" ");
    Console.WriteLine(" O CNPJ deveria ser valido, portanto não é valido infelismente!!!");
    Console.WriteLine(" ");
}
*/

string mensagem = sitacaoCNPJ ? "é válido" : "não é válido";

Console.WriteLine($"O CNPJ informada {mensagem}");
Console.ReadKey();
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Digite a Placa do Veículo:");
var placa = Console.ReadLine();

var resultado = ValidacoesSociais.ValidarPlaca(placa);
var mensagem01 = resultado ? "é válida" : "não é válida";

Console.WriteLine($"A placa informada {mensagem01}");
Console.ReadKey();

Console.WriteLine(" ");
Console.ReadKey();
