
using AppAumentoSalario.RegrasDeNegocio;
Reajuste rej = new Reajuste();


string opc1; // definir a continuidade do loop

do //começo do Loop
{
    Console.WriteLine("############ SISTEMA DE REAJUSTE DE SALÁRIO ############");
    Console.WriteLine();
    Console.Write("Informe o salário............................: ");
    rej.SalarioAtual = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Esolha a categoria para dar aumento: ");
    Console.WriteLine("1 - Auxiliar de Servições Gerais");//5%
    Console.WriteLine("2 - Técnicos operativos");//7%
    Console.WriteLine("3 - Supervisores");//8%
    Console.WriteLine("4 - Reajuste Livre");
    Console.WriteLine("5 - Sair do Sistema");
    Console.Write("OPC.........................................: ");
    int opc2 = Convert.ToInt32(Console.ReadLine());
    opc1 = "N";// Não quero encerrar o sistema
    switch (opc2)
    {//começo case
        case 1: 
            {
                Console.Clear();
                Console.WriteLine("######## SERVIÇOS GERAIS ###########");
                rej.CalcularAumentoServicoGerais();
                Console.WriteLine("O salário reajustado é de R$ " + rej.SalarioReajustado);

                Console.ReadKey();
                break; 
            }
        case 2:
            {
                Console.Clear();
                rej.CalcularAumentoTecnicosOperativos();
                Console.WriteLine("######## TÉCNICOS OPERATIVOS ###########");
                Console.WriteLine("O salário reajustado é de R$ " + rej.SalarioReajustado);
                Console.ReadKey();

                break;
            }
        case 3:
            {
                Console.Clear();
                rej.CalcularAumentoSupervisores();
                Console.WriteLine("######## SURPEVISORES ###########");
                Console.WriteLine("O salário reajustado é de R$ " + rej.SalarioReajustado);
                Console.ReadKey();

                break;
            }
        case 4:
            {
                Console.WriteLine("######## REAJUSTE LIVRE ###########");
                Console.WriteLine("Informe a porcentagem de aumento que deseja calcular  : ");
                rej.PerAumento = Convert.ToInt32(Console.ReadLine());     
                rej.CalcularReajsuteLivre();
                Console.WriteLine("O salário reajustado é de R$ " + rej.SalarioReajustado);     
                Console.ReadKey();

                break;
            }

        case 5:
            {
                
                opc1 = "S";

                break;
            }
        default: { Console.WriteLine("OPÇÃO INVÁLIDA!");break; }    

    }//fim case
    Console.Clear ();
} while (opc1 != "S"); // fim do loop 
