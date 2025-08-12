using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo02AO.RegrasDeNegocio
{
    internal class SomaDeValores
    {
        //ATRIBUTOS
        private int valor1;
        private int valor2;
        private int total;

        //Métodos da classe
        public int SomarValores(int v1, int v2)
        {
            valor1 = v1;
            valor2 = v2;
            total = valor1 + valor2;
            return total;
        }

        public int MultiplicarValores(int v1, int v2)
        {
            valor1 = v1;
            valor2 = v2;
            total = valor1 * valor2;
            return total;
        }

        public int SubtracaoValores(int v1, int v2)
        {
            valor1 = v1;
            valor2 = v2;
            total = valor1 - valor2;
            return total;
        }

        public int DivisaoValores(int v1, int v2)
        {
            valor1 = v1;
            valor2 = v2;
            total = valor1 * valor2;
            return total;
        }
    }
}
