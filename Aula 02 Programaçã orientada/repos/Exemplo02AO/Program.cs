


using Exemplo02AO.RegrasDeNegocio;




Console.Write("vLAOR 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Valor 2: ");
int b = Convert.ToInt32(Console.ReadLine());

SomaDeValores objeto = new SomaDeValores();
int total = objeto.SomarValores(a, b);
Console.WriteLine("Total:    " + total);// a variavel total já possui o calculo da soma de valores, pois a linha anterior já está atribuindo o seu valor 
Console.WriteLine("Resultado da multiplicação por 5  é :      " + objeto.MultiplicarValores(a,b));



