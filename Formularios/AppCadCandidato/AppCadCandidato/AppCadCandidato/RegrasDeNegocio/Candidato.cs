using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCadCandidato.RegrasDeNegocio
{
    internal class Candidato
    {
        public int Insc { get; set; }
        public string Nome { get; set; }
        public double Nota { get; set; }

        public string Situacao 
        {
            get {
                string situacao = "REPROVADO";
                if (Nota >= 70) situacao = "APROVADO";
                return situacao;
            }
        }
    }
}
