using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAumentoSalario.RegrasDeNegocio
{
    internal class Reajuste
    {
        private double salarioAtual;
        private double perAumento;//percentual de aumento 
        private double salarioReajustado; 

        //métodos get e Set
        public double SalarioAtual
        {
            get { return salarioAtual; }
            set { salarioAtual = value;}
        }
        public double PerAumento
        {
            get { return perAumento;  }  
            set { perAumento = value / 100.0;  }
        }
        public double SalarioReajustado
        {
            get { return salarioReajustado; }    
            
        }
  
        
        

        // métodos para reajuste do salário
        
        public void CalcularAumentoServicoGerais()
        {
            PerAumento = 5;
            salarioReajustado= (salarioAtual * (1 +  perAumento)) ;
        }

        public  void CalcularAumentoTecnicosOperativos()
        {

            PerAumento = 7;
            salarioReajustado = (salarioAtual * (1+ perAumento));
        }
        public void CalcularAumentoSupervisores()
        {
            PerAumento = 8;
            salarioReajustado = (salarioAtual * ( 1 +perAumento));
        }

        public void CalcularReajsuteLivre()
        {
            salarioReajustado = (salarioAtual * (1 + perAumento));
        }

    }
}
