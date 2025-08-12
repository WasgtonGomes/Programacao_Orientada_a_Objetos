using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPCalculadoraFinaceira.RegrasDeNegocio
{
    internal class Financeiro
    {
        private double montante;
        private double capitalAplicado;
        private double taxaDeJuros;
        private double tempo;
        private double juros;

        public double Montante
        {
            get { return montante; }    
            set { montante = value; }
        }
        public double CapitalAplicado
        {
            get { return capitalAplicado; }
            set { capitalAplicado = value;}
        }

        public double TaxaDeJuros
        {
            get { return taxaDeJuros;}
            set { taxaDeJuros = value/100;}
        }
        public double Tempo
        {
            get { return tempo; }
            set { tempo = value;}
        }
        public double Juros
        {
            get { return juros; }  
            set { juros = value;}
          
        }

        public void CalcularMontanteComposto()
        {
            montante = (capitalAplicado * Math.Pow ((1 + taxaDeJuros),tempo));
            CalcularJuros();
            
        }


        private void CalcularJuros()
        {
            juros = Montante - capitalAplicado;

            
        }

        public void CalcularMontanteSimples()
        {
            montante = (capitalAplicado * (1 + taxaDeJuros * tempo));
            CalcularJuros();
        }

        public void CalcularCapitalAplicadoSimples()
        {
            //código
            capitalAplicado = (montante) / (Math.Pow((1 + taxaDeJuros),tempo));
            CalcularJuros ();
        }

        public void CalcularTempoSimples()
        {
            // código
            tempo = (juros) / (capitalAplicado * taxaDeJuros);
            CalcularJuros();
        }


        public void CalcularTaxaSimples()
        {
            //código
            taxaDeJuros = (juros / (capitalAplicado * tempo));
            CalcularJuros();
        }
    }
}
