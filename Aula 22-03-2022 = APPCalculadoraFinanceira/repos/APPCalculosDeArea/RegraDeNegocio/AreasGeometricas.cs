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
        public double Lado3
        {
            get { return lado3; }
            set { lado3 = value; }
        }
        public double Area
        {
            get { return area; }
        }

        private bool VerificarTriangulo()
        {
            if(lado1 + lado2 > lado3 && lado3 + lado1 >lado2 && lado3 + lado2 >lado1)
            {
                Console.WriteLine("Os três valores informados formam um triangulo");
                
            }
            else
            {
                Console.WriteLine("Os valores infoemados não formam um  triângulo!! ");
            }

            return true;

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
            // lado1 = base maior , lado2=base menor e lado3 = altura 
            area = (((lado1 + lado2) * lado3) / 2);

        }


        public void CalcularAreaDoTrianguloEquilatero()
        {
            if (VerificarTriangulo())
            {
                //implementar o código para calcular
            }
            else
            {
                area = 0;
                Console.WriteLine("Os valores informados não forma um triangulo");
            }

        }

        public void CalcularAreaDoTrianguloIsoceles()
        {

        }

        public void CalcularAreaDoTrianguloEscaleno()
        {

        }


    }
}
