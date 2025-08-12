using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeramentasBiblioteca.Formatacoes
{
    public static class Mascaras
    {
        public static string ColocarMascaraDoTelefone(string num)
        {
            // (69)9246-9341
            string ddd = num.Substring(0, 2);
            string num1 = num.Substring(2, 5);
            string num2 = num.Substring(7, 4);
            //colocar máscara

            string msk = "(" + ddd + ")-" + num1 + "-" + num2;
            return msk;
        }

        public static string ColocarMascaraDoTelefone(long num)
        {

            //6992469341
            string ddd = num.ToString().Substring(0, 2);
            string num1 = num.ToString().Substring(2, 4);
            string num2 = num.ToString().Substring(7, 4);
            //colocar máscara

            string msk = "(" + ddd + ")-" + num1 + "-" + num2;
            return msk;
        }

        public static string ColocarMascaraCPF(string num)
        {

            // 065.175.162-62

            string parti01 = num.Substring(0, 3);
            string parti02 = num.Substring(3, 3);
            string parti03 = num.Substring(7, 3);
            string parti04 = num.Substring(9, 2);

            //ColocarMascara

            string msk = parti01 + " . " + parti02 + " . " + parti03 + " - " + parti04;

            return msk;


        }

        public static string ColocarMascaraCPF(long num)
        {

            // 065.175.162-62

            string parti01 = num.ToString().Substring(0, 3);
            string parti02 = num.ToString().Substring(4, 3);
            string parti03 = num.ToString().Substring(8, 3);
            string parti04 = num.ToString().Substring(9, 2);

            //ColocarMascara
            string msk = parti01 + " . " + parti02 + " . " + parti03 + " - " + parti04;

            return msk;


        }


        public static string ColocarMascaraCNPJ(string num)
        {

            // 44.479.706/0001-04

            string parti01 = num.Substring(0, 2);
            string parti02 = num.Substring(3, 3);
            string parti03 = num.Substring(7, 3);
            string parti04 = num.Substring(11, 4);
            string parti05 = num.Substring(16, 2);

            //ColocarMascara

            string msk = parti01 + " . " + parti02 + " . " + parti03 + " / " + parti04 + " - " + parti05;

            return msk;


        }

        public static string ColocarMascaraCNPJ(long num)
        {


            // 44.4790.706/0001-04

            string parti01 = num.ToString().Substring(0, 2);
            string parti02 = num.ToString().Substring(3, 3);
            string parti03 = num.ToString().Substring(7, 3);
            string parti04 = num.ToString().Substring(11, 4);
            string parti05 = num.ToString().Substring(16, 2);


            //ColocarMascara
            string msk = parti01 + " . " + parti02 + " . " + parti03 + " / " + parti04 + " - " + parti05;

            return msk;


        }




        //string smsk = ddd + num1 + num2;


        public static string RemoverMascaraDoTelefone(string num)
        {
            // (69)9246-9341

            string ddd = num.Substring(1, 2);
            string num1 = num.Substring(4, 4);
            string num2 = num.Substring(9, 4);
            //Remover máscara

            string msk = ddd + num1 + num2;
            return msk;
        }

        public static string RemoverrMascaraDoTelefone(long num)
        {
            string ddd = num.ToString().Substring(1, 2);
            string num1 = num.ToString().Substring(4, 4);
            string num2 = num.ToString().Substring(9, 4);
            //Remover máscara

            string msk = ddd + num1 + num2;
            return msk;
        }

        public static string RemoverMascaraCPF(string num)
        {

            // 065.175.162-62

            string parti01 = num.Substring(0, 3);
            string parti02 = num.Substring(4, 3);
            string parti03 = num.Substring(8, 3);
            string parti04 = num.Substring(12, 2);

            //Remover Mascara

            string msk = parti01 + parti02 + parti03 + parti04;

            return msk;


        }

        public static string RemoverMascaraCPF(long num)
        {

            // 065.175.162-62

            string parti01 = num.ToString().Substring(0, 3);
            string parti02 = num.ToString().Substring(4, 3);
            string parti03 = num.ToString().Substring(8, 3);
            string parti04 = num.ToString().Substring(12, 2);

            //Remover Mascara
            string msk = parti01 + parti02 + parti03 + parti04;

            return msk;


        }


        public static string RemoverMascaraCNPJ(string num)
        {

            // 44.479.706/0001-04

            string parti01 = num.Substring(0, 2);
            string parti02 = num.Substring(3, 3);
            string parti03 = num.Substring(7, 3);
            string parti04 = num.Substring(11, 4);
            string parti05 = num.Substring(16, 2);

            //Remover Mascara

            string msk = parti01 + parti02 + parti03 + parti04 + parti05;

            return msk;


        }


        public static string RemoverMascaraCNPJ(long num)
        {


            // 44.4790.706/0001-04

            string parti01 = num.ToString().Substring(0, 2);
            string parti02 = num.ToString().Substring(3, 3);
            string parti03 = num.ToString().Substring(7, 3);
            string parti04 = num.ToString().Substring(11, 4);
            string parti05 = num.ToString().Substring(16, 2);


            //Remover Mascara
            string msk = parti01 + parti02 + parti03 + parti04 + parti05;

            return msk;


        }
    }
}
