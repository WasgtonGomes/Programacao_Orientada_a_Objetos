using APPExemplo1PO.RegrasDeNegocio; // Parte que chama a classe

// foi criado o objeto
CalculadoraDePotencia calc = new CalculadoraDePotencia();// OBJETO 1

Console.WriteLine("########## Calcular Raiz Quadrada###########");
Console.WriteLine("");
Console.WriteLine("Digite o radical: ");
Console.WriteLine("");
calc.Baze = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");
calc.CalcularRaizQuadrada(); // processamento dos dados de entrada


Console.ForegroundColor = ConsoleColor.Green;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("######### RESULTADO DA RAIZ #########");
Console.WriteLine("");
Console.WriteLine("RAIZ QUADRADA ...........:"+ calc.Resultado);
Console.WriteLine("");

CalculadoraDePotencia calc2 = new CalculadoraDePotencia(); // OBJETO2:  criando um segundo objeto o primeiro obejeto não interfere no segundo objeto. 
Console.WriteLine("########## Calcular Potência#########");
Console.WriteLine("");
Console.WriteLine("Digite a base:  ");
Console.WriteLine("");
calc2.Baze = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Digite o expoente:  ");
Console.WriteLine("");
calc2.Expoente = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");
calc2.CalcularPotencia(); // procesamnto dos dados de entrada

Console.ForegroundColor= ConsoleColor.Green;
Console.WriteLine("########## RESULTADO DA POTÊNCIA #######");
Console.WriteLine("");
Console.WriteLine("POTÊNCIA.........:  " + calc2.Resultado);

 


























