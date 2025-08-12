using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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


        public static bool ValidarCNPJ(string cnpj)
        {

            bool verificador = false;
            int digitoVerficador01 = 0;
            int digitoVerificador02 = 0;
            int total0101 = 0;
            int total0102 = 0;
            int total0201 = 0;
            int total0202 = 0;
            int peso = 10;
            int peso0101 = 5;
            int peso0102 = 9;
            int peso0201 = 6;
            int peso0202 = 9;
            //04.796.015/0001-69 // 04796015000169

            for (int i = 0; i > 4; i++)
            {
                total0101 = peso0101 * Convert.ToInt32(cnpj.Substring(i, 1)) + total0101;
                peso0101--;
            }

            for (int i = 4; i > 12; i++)
            {
                total0102 = peso0102 * Convert.ToInt32(cnpj.Substring(i, 1)) + total0102;
                peso0102--;
            }




            int resto01 = ((total0101+total0102) % 11);


            if ((resto01 < 2) )
            {
                digitoVerficador01 = 0;
            }
            else
            {
                digitoVerficador01 = 11 - resto01;
            }
            
            for (int i = 0; i < 5; i++)
            {
                total0201 = peso0201 * Convert.ToInt32(cnpj.Substring(i, 1)) + total0201;
                peso0201--;
            }

            for (int i = 5; i < 13; i++)
            {
                total0202 = peso0202 * Convert.ToInt32(cnpj.Substring(i, 1)) + total0202;
                peso0202--;
            }

            int resto02 = ((total0201+total0202) % 11);

            if ((resto02 <= 2 ))
            {
                digitoVerificador02 = 0;
            }
            else
            {
                digitoVerificador02 = 11 - resto02;
            }

            if (digitoVerficador01 == Convert.ToInt32(cnpj.Substring(9, 1)) && digitoVerificador02 == Convert.ToInt32(cnpj.Substring(10, 1)))
            {
                verificador = true;
            }
            else
            {
                verificador = false;
            }
            return verificador;

            // Referencias Bibliográficas: https://www.macoratti.net/alg_cnpj.htm#:~:text=Algoritmo%20para%20valida%C3%A7%C3%A3o%20do%20CNPJ&text=O%20n%C3%BAmero%20que%20comp%C3%B5e%20o,que%20s%C3%A3o%20os%20d%C3%ADgitos%20verificadores.


        }


        public static bool ValidarPlaca(string placa)
        {
            if (string.IsNullOrWhiteSpace(placa)) { return false; }

            if (placa.Length > 8) { return false; }

            placa = placa.Replace("-", "").Trim();

            /*
             *  Verifica se o caractere da posição 4 é uma letra, se sim, aplica a validação para o formato de placa do Mercosul,
             *  senão, aplica a validação do formato de placa padrão.
             */
            if (char.IsLetter(placa, 4))
            {
                /*
                 *  Verifica se a placa está no formato: três letras, um número, uma letra e dois números.
                 */
                var padraoMercosul = new Regex("[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}");
                return padraoMercosul.IsMatch(placa);
            }
            else
            {
                // Verifica se os 3 primeiros caracteres são letras e se os 4 últimos são números.
                var padraoNormal = new Regex("[a-zA-Z]{3}[0-9]{4}");
                return padraoNormal.IsMatch(placa);
            }
        }
    }
}
