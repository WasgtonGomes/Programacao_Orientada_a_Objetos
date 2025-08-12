using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeramentasBiblioteca.Validacoes
{
    public class ValidacoesSociais
    {


        public static bool ValidarCpf(string cpf)
        {
            bool verificador = false;
            int digitoVerficador01 = 0;
            int digitoVerificador02 = 0;
            int total = 0;
            int total02 = 0;
            int peso = 10;
            //06517519262

            for (int i = 0; i < 9; i++)
            {
                total = peso * Convert.ToInt32(cpf.Substring(i,1)) + total;
                peso--;
            }

            int resto01 = (total % 11);
            

            if ((resto01==1)||(resto01 ==0))
            {
                digitoVerficador01 = 0;
            }
            else
            {
                digitoVerficador01 = 11 - resto01;
            }
            peso = 10;
            for (int i = 1; i < 10; i++)
            {
                total02 = peso * Convert.ToInt32(cpf.Substring(i, 1)) + total02;
                peso--;
            }
            int resto02 = (total02 % 11);

            if ((resto02 == 1) || (resto02 == 0))
            {
                digitoVerificador02 = 0;
            }
            else
            {
                digitoVerificador02 = 11 - resto02;
            }

            if (digitoVerficador01==Convert.ToInt32(cpf.Substring(9,1))&& digitoVerificador02 == Convert.ToInt32(cpf.Substring(10, 1)))
            {
                verificador = true;
            }
            else
            {
                verificador = false;
            }
            return verificador;
        }


    }
}
