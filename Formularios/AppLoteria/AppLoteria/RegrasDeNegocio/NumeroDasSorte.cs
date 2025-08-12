using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLoteria.RegrasDeNegocio
{
    internal class NumeroDasSorte
    {
        public int NumOrdem { get; set; }
        public int Numero { get; set; }

        public string Tipo() {
            string tipo = "impar";
            if (Numero % 2 == 0) tipo = "par";

            return tipo;
        }

        public int SequenciaLotoFacio()
        {
            int valor = 0;
            for (int i = 1; i < 26; i++)
            {
                valor= i;
                
            }

            return valor;
        }
    }
}
