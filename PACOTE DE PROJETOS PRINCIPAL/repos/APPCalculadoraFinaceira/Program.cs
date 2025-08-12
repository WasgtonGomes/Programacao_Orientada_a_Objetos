using APPCalculadoraFinaceira.RegrasDeNegocio;
Financeiro finance = new Financeiro();

string opc1;
do
{
    Console.WriteLine("############# CALCULADORA FINANCEIRA ##########");
    Console.WriteLine(" ");
    Console.WriteLine("ESCOLHA QUAL CALCULO DESEJA EXECULAR: ");
    Console.WriteLine();
    Console.WriteLine("1 - Montante e Juro Composto");
    Console.WriteLine("2 - Montante e Juro Simples");
    Console.WriteLine("3 - Tempo Simples");
    Console.WriteLine("4 - Taxa Simples");
    Console.WriteLine("5 - Capital Aplicado Simples");
    Console.WriteLine("6 - Sair do Sistema");
    Console.WriteLine(" ");

    int opc2 = Convert.ToInt32(Console.ReadLine());
    opc1 = "N";
    switch (opc2)
    { // Inicio da case

        case 1:
            {
                Console.Clear();
                Console.WriteLine("###################### CALCULO DE MONTATE E JURO COMPOSTO ################## ");
                Console.WriteLine(" ");
                Console.Write("Informe o capital aplicado:   ");
                finance.CapitalAplicado = Convert.ToInt32(Console.ReadLine()) ;
                Console.WriteLine(" ");
                Console.Write("Informe o tempo em mês : ");
                finance.Tempo = Convert.ToInt32(Console.ReadLine()) ;
                Console.WriteLine(" ");
                Console.Write("Informe a taxa % :  ");
                finance.TaxaDeJuros = Convert.ToInt32(Console.ReadLine()) ;
                Console.WriteLine(" ");

                finance.CalcularMontanteComposto();
                Console.WriteLine("Montante Composto: " + finance.Montante.ToString("C"));
                Console.WriteLine(" ");
                Console.WriteLine("Juros Composto:  " + finance.Juros.ToString("C"));
                Console.WriteLine(" ");




                break;
            }

        case 2:
            {
                Console.Clear();
                Console.WriteLine("###################### CALCULO DE MONTATE E JURO SIMPLES ################## ");
                Console.WriteLine(" ");
                Console.Write("Informe o capital aplicado:   ");
                finance.CapitalAplicado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("Informe o tempo em mês : ");
                finance.Tempo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("Informe a taxa % :  ");
                finance.TaxaDeJuros = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                finance.CalcularMontanteSimples();
                Console.WriteLine("Montante Simples: " + finance.Montante.ToString("C"));
                Console.WriteLine(" ");
                Console.WriteLine("Juros Simpes:  " + finance.Juros.ToString("C"));
                Console.WriteLine(" ");




                break;
            }

        case 3:
            {
                Console.Clear();
                Console.WriteLine("###################### CALCULO DE TEMPO SIMPLES ######################## ");
                Console.WriteLine(" ");
                Console.Write("Informe o capital aplicado:   ");
                finance.CapitalAplicado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("Informe o valor do Juros : ");
                finance.Juros = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("Informe a taxa % de juros :  ");
                finance.TaxaDeJuros = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                finance.CalcularTempoSimples();
                Console.WriteLine("Tempo Simples foi de: " + finance.Tempo + " meses");
                Console.WriteLine(" ");





                break;
            }

        case 4:
            {
                Console.Clear();
                Console.WriteLine("###################### CALCULO DE TAXA SIMPLES ######################## ");
                Console.WriteLine(" ");
                Console.Write("Informe o capital aplicado:   ");
                finance.CapitalAplicado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("Informe o valor do Juros : ");
                finance.Juros = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("Informe o tempo em mês :  ");
                finance.Tempo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                finance.CalcularTaxaSimples();
                Console.WriteLine("Taxa de juros Simples foi de : " + (finance.TaxaDeJuros * 100) + " % ao mês");
                Console.WriteLine(" ");





                break;
            }

        case 5:
            {
                Console.Clear();
                Console.WriteLine("###################### CALCULO DE CAPITAL APLICADO SIMPLES ######################## ");
                Console.WriteLine(" ");
                Console.Write("Informe o valor do juros:   ");
                finance.Juros = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe a taxa % de juros :  ");
                finance.TaxaDeJuros = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                Console.Write("Informe o tempo em mês :  ");
                finance.Tempo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                finance.CalcularCapitalAplicadoSimples();
                Console.WriteLine("O capital aplicado Simples foi de : " + finance.CapitalAplicado.ToString("C"));
                Console.WriteLine(" ");






                break;
            }

        case 6:
            {
                opc1 = "S";
                break;
            }



        default:  { Console.WriteLine("OPÇÃO INVALIDA !! "); }
            break;
    }// Fim da case
    

}while (opc1 !="S");