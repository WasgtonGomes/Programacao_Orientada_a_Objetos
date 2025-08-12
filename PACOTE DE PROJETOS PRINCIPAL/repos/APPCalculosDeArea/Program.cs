using APPCalculosDeArea.RegraDeNegocio;
AreasGeometricas areageo = new AreasGeometricas();

string opc1;
do // inicio do loop
{
	Console.WriteLine(" ############ SISTEMA PARA CÁLCULAR ÁREAS GEOMÉTRICAS #########");
	Console.WriteLine(" ");
	Console.WriteLine("ESCOLHA QUAL FORMA GEOMÉTRICA DESEJA CALCULAR A ÁREA: ");
	Console.WriteLine("1 - Retângulo");
    Console.WriteLine("2 - Lozangulo");
    Console.WriteLine("3 - Trapézio");
    Console.WriteLine("4 - Triângulo");
    Console.WriteLine("5 - Sair do Sistema");


	int opc2 = Convert.ToInt32(Console.ReadLine());
	opc1 = "N";
    switch (opc2)
	{//começo da case
		case 1:
            {
				Console.Clear();
				Console.WriteLine("########### Calculo de área do Retângulo #######");
				Console.WriteLine(" ");
				Console.WriteLine("Informe o lado 1 do retangulo: ");
				areageo.Lado1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" ");
				Console.WriteLine("Informe o lado 2 do retangulo: ");
				areageo.Lado2 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" ");
				areageo.UnidaDeMedida();
				Console.WriteLine(" ");

				areageo.CalcularAreaDoRetangulo();
				Console.WriteLine(" ");
				Console.WriteLine("A área do retângulo é : " + areageo.Area.ToString("") + areageo.UnidadeRetorno);
				Console.ReadKey();

				break;
            }

		case 2:
			{
				Console.Clear();
				Console.WriteLine("########### Calculo de área do Lozangulo #######");
				Console.WriteLine(" ");

				Console.WriteLine("Informe a diagonal maior do lozangulo: ");
				areageo.Lado1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" ");

				Console.WriteLine("Informe a diagonal menor do lozangulo: ");
				areageo.Lado2 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" ");
				areageo.UnidaDeMedida();
				Console.WriteLine(" ");

				areageo.CalcularAreaDoLosangulo();
				Console.WriteLine(" ");
				Console.WriteLine("A área do lozangulo é : " + areageo.Area.ToString("") + areageo.UnidadeRetorno);
				Console.ReadKey();

				break;
			}

		case 3:
			{
				Console.Clear();
				Console.WriteLine("########### Caulculo de área do Trapézio #######");
				Console.WriteLine(" ");
				Console.WriteLine("Informe a base maior do Trápézio: ");
				areageo.Lado1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" ");
				Console.WriteLine("Informe a base menor do Trápézio: ");
				areageo.Lado2 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" ");
				Console.WriteLine("Informe a altura do Trápézio: ");
				areageo.Altura = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" ");
				areageo.UnidaDeMedida();
				Console.WriteLine(" ");
				areageo.CalcularAreaDoLosangulo();
				Console.WriteLine(" ");
				Console.WriteLine("A área do trapézio é : " + areageo.Area.ToString("") + areageo.UnidadeRetorno);
				Console.ReadKey();

				break;
			}

		case 4:
			{
				Console.Clear();
				Console.WriteLine("########### Caulculo de área do Triângulo #######");
				Console.WriteLine(" ");
				Console.WriteLine("Informe o lado 1 do trinagulo que não seja a sua base: ");
				areageo.Lado1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" ");
				Console.WriteLine("Informe o lado 2 do triângulo que não seja a sua base: ");
				areageo.Lado2 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" ");
				Console.WriteLine("Informe o lado 3 sendo este a base do triângulo: ");
				areageo.Lado3 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" ");
				areageo.UnidaDeMedida();
				Console.WriteLine(" ");
				areageo.TipoDeTriangulo();
				Console.WriteLine(" ");
				Console.ReadKey();

				break;
			}



		case 5:
            {
                
                opc1 = "S";

                break;
            }

		default: { Console.WriteLine("OPÇÃO INVALIDA!!");break;}		
	}// fim case


	Console.Clear();
}while (opc1 !="S");// fim do loop




