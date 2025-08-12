using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPExemplo1PO.RegrasDeNegocio
{
    internal class CalculadoraDePotencia
    {// começo da classe
        private double expoente;
        private double baze;
        private double resultado;


        public double Expoente
        {
            get { return expoente; }
            set { expoente = value; }
        }

        public double Baze
        {
            get { return baze; }
            set { baze = value; }
        }
        
        
        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public void CalcularPotencia()
        {
            resultado = Math.Pow(baze,expoente);
        }

        public void CalcularRaizQuadrada()
        {
            resultado = Math.Pow(baze,0.5);
        }

        /*
         //método GET tradicional
        public  void GetExpoente()
        {
            return ;
        }

        public void GetBaze()
        {
            return ;
        }
       

        // método set tradicional
        
        public void SetExpoente()
        {
            return;
        }
        */

    }//fim da classe
}
