/*string texto = "FICA EM CASA!"; 
Console.WriteLine(texto.Length);
Console.WriteLine(texto.Substring(2,4));//CA E

string num = "69999594589";
string ddd = num.Substring(0, 2);
string num1 = num.Substring(2, 5);
string num2 = num.Substring(7, 4);
//colocar máscara

string msk = "(" + ddd + ")-" + num1 + "-" + num2; 
Console.WriteLine(msk);*/

/*string num = "(69)-99959-4589";
string ddd = num.Substring(1,2);
string num1 = num.Substring(5, 5);
string num2 = num.Substring(11, 4); 

string smsk = ddd+num1+num2;
Console.WriteLine(smsk);*/
using AppExemploClasseEstatica.RegrasDeNegocio;

/*
Console.Write("Telefone: "); 
string numTelefone = Console.ReadLine();

numTelefone = Mascaras.ColocarMascaraDoTelefone(numTelefone);
Console.WriteLine("Tel com Máscara: "+numTelefone);

long numero = 69999594589;
string numeroMsk = Mascaras.ColocarMascaraDoTelefone(numero);
Console.WriteLine("Telefone com Msk: " + numeroMsk);*/

/*
Console.Write(" CPF : ");
string cpf =  Console.ReadLine();


 string cpfInt = Mascaras.ColocarMascaraCPF(cpf);

Console.WriteLine("CPF (String) com MASCARÁ : " + cpfInt);*/

//##############################

Console.Write("CPF (000.000.000-00) :");
string cpf = Console.ReadLine();
string cpfString = Mascaras.ColocarMascaraCPF(cpf);
Console.WriteLine(" ");
Console.Write(" CPF Com mascara  : " + cpfString);
Console.ReadKey();
