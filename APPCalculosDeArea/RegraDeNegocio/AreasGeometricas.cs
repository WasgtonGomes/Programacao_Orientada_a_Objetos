using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPCalculosDeArea.RegraDeNegocio
{
    internal class AreasGeometricas
    {
        private double lado1;
        private double lado2;
        private double lado3;
        private double altura;
        private double unidadeMedida;
        private string unidadeRetorno;



        private double area;

        public double Lado1
        {
            get { return lado1; }
            set { lado1 = value; }
        }
        public double Lado2
        {
            get { return lado2; }
            set { lado2 = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public double Lado3
        {
            get { return lado3; }
            set { lado3 = value; }
        }
        public double Area
        {
            get { return area; }
        }


        public double UnidadeMedida
        {
            get { return unidadeMedida; }
            set { unidadeMedida = value; }
        }
        public string UnidadeRetorno
        {
            get { return unidadeRetorno; }
            set { unidadeRetorno = value; }
        }

        private bool VerificarTriangulo()
        {
            if (lado1 + lado2 > lado3 && lado3 + lado1 > lado2 && lado3 + lado2 > lado1)
            {

                return true;
            }
            else
            {

                return false;
            }



        }

        public void CalcularAreaDoRetangulo()
        {
            area = lado1 * lado2;
        }
        public void CalcularAreaDoLosangulo()
        {
            //lado 1 = diagonal maior e lado2 = diagonal menor
            area = ((lado1 + lado2) / 2);
        }
        public void CalcularAreaDoTrapezio()
        {
            // lado1 = base maior , lado2=base menor  
            area = (((lado1 + lado2) * altura) / 2);

        }


        public void CalcularAreaDoTrianguloEquilatero()
        {
            if (VerificarTriangulo())
            {
                //implementar o código para calcular
                //lado3 = base 
                altura = ((lado1 * (Math.Sqrt(3))) / 2);               // Formula para calculara a altura do triângulo equilátero ->> x√3 / 2
                area = ((lado3 * altura) / 2);
                Console.WriteLine("As medidas do triângulo informada forma o triângulo Equilatero de area de : " + area.ToString("") + unidadeRetorno);
            }
            else
            {
                area = 0;
                Console.WriteLine("Os valores informados não forma um triangulo");
            }

        }

        public void CalcularAreaDoTrianguloIsoceles()
        {
            if (VerificarTriangulo())
            {
                //implementar o código para calcular
                //lado3 = base 

                altura = Math.Sqrt(Math.Pow(lado1, 2) - (Math.Pow((lado3 / 2), 2))); //  Formula para calcular a altura do triangulo isoceles--> h = √lado²-(base/2)²
                area = ((lado3 * altura) / 2);
                Console.WriteLine("As medidas do triângulo informada forma o triângulo Isoceles de area de : " + area.ToString("") + unidadeRetorno);
            }
            else
            {
                area = 0;
                Console.WriteLine("Os valores informados não forma um triangulo");
            }

        }

        public void CalcularAreaDoTrianguloEscaleno()
        {
            if (VerificarTriangulo())
            {

                double semiPerimetro = ((lado1 + lado2 + lado3) / 2);     //implementei uma variavel local para somente calcular o semiperimetro dentro desde método

                area = (Math.Sqrt((semiPerimetro * (semiPerimetro - lado1) * (semiPerimetro - lado2) * (semiPerimetro - lado3)))); // Formula de Heron para calcular a Area do triangulo escaleno pois todos os lados são conhecidos A= √(p*(p-lado1)*(p- lado2)* (p - lado3)     )
                Console.WriteLine("As medidas do triângulo informada forma o triângulo Escaleno de area de : " + area.ToString("") + unidadeRetorno);
            }
            else
            {
                area = 0;
                Console.WriteLine("Os valores informados não forma um triangulo");
            }
        }

        public void TipoDeTriangulo()
        {
            if (Lado1 == Lado2 && Lado3 == Lado2)
            {
                CalcularAreaDoTrianguloEquilatero();

            }
            else
            {
                if (Lado1 == Lado2 || Lado3 == Lado2 || Lado1 == Lado3)
                {
                    CalcularAreaDoTrianguloIsoceles();

                }
                else
                {
                    if (Lado1 != Lado2 && Lado3 != Lado2)
                    {
                        CalcularAreaDoTrianguloEscaleno();

                    }
                }
            }
        }

        public void UnidaDeMedida()
        {
            Console.Clear();
            Console.WriteLine("Por favor informe a unidade de medida que o resultado seja exibido : ");
            Console.WriteLine();
            Console.WriteLine(" 1 para 'mm' milimetro  : ");
            Console.WriteLine();
            Console.WriteLine(" 2 para 'CM' centimetro: ");
            Console.WriteLine();
            Console.WriteLine(" 3 para 'M' metro: ");
            Console.WriteLine();
            Console.WriteLine(" 4 para 'km' Kilometro: ");
            Console.WriteLine();
            unidadeMedida = Convert.ToInt32(Console.ReadLine());

            //string unidadeRetorno = " !! ";

            if (unidadeMedida == 1)
            {
                unidadeRetorno = "  mm²";

            }
            else
            {
                if (unidadeMedida == 2)
                {
                    unidadeRetorno = " CM² ";

                }
                else
                {
                    if (unidadeMedida == 3)
                    {
                        unidadeRetorno = " M² ";

                    }
                    else
                    {
                        if (unidadeMedida == 4)
                        {
                            unidadeRetorno = " KM² ";

                        }
                        else
                        {
                            unidadeRetorno = " A Unidade Informado não esta indisponível !! ";

                        }
                    }
                }
            }


        }

    }

}
