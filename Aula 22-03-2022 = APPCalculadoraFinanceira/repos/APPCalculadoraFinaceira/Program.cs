using APPCalculadoraFinaceira.RegrasDeNegocio;
Financeiro finance = new Financeiro();


finance.CapitalAplicado = 300;
finance.Tempo = 12;
// TESTE finance.Montante = 338.05 ;
finance.TaxaDeJuros = 1;
finance.CalcularMontanteComposto();
Console.WriteLine("Montante Composto: " + finance.Montante.ToString("C"));
Console.WriteLine("Juros Composto:  " + finance.Juros.ToString("C"));



finance.CalcularMontanteSimples();
Console.WriteLine("Montante Simples: " + finance.Montante.ToString("C"));
Console.WriteLine("Juros Simples:  " + finance.Juros.ToString("C"));

Console.WriteLine("############################ TESTE 02#################");

finance.CalcularTempoSimples();
Console.WriteLine("Montante Simples: " + finance.Tempo.ToString("C"));






/**
Console.WriteLine("############# CALCULADORA FINANCEIRA ##########");
Console.WriteLine("");
Console.WriteLine("Insira o valor do Capital aplicado..................: ");
finance.CapitalAplicado = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Isira o valor da Taxa de juros em porcentagem % ....:");
finance.TaxaDeJuros = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insira o Tempo a ser calculado .....................:");
finance.Tempo = Convert.ToInt32(Console.ReadLine());

finance.CalcularMontanteSimples();

Console.WriteLine("O valor do juros claculado foi de : R$ "+ finance.Juros );*/
