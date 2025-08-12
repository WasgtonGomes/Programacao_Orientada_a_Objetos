using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeramentasBiblioteca.Validacoes
{
    public static class ContaBancaria
    {
        public static bool ValidarContaBB(string agencia, string conta)
        {
            bool vefrificador = false;
            int digitoCont = 0;
            int total = 0;
            int peso = 9;

            if (conta.Substring(8,1).ToUpper() == "X")
            {
                digitoCont = 10;
            }
            else
            {
                digitoCont = Convert.ToInt32(conta.Substring(8, 1));
            }

            for (int i = 0; i < 8; i++)
            {
                total = peso * Convert.ToInt32(conta.Substring(i, 1)) + total;
                peso--;
            }
            int resto = total % 11;
            int dvConta = 11 - resto;
            if (dvConta ==digitoCont)
            {
                vefrificador = true;
            }
            else
            {
                Console.WriteLine(" Conta invalida!!");
            }

            return vefrificador;


        }
       
    }
}
