using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPExemploAluno.RegrasDeNegocio
{
    internal class Aluno
    {
        //atributos
        private string nome;
        private double nota1;
        private double nota2;
        private double media;


        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); } // O .ToUpper() faz com que tudo fique em letra maiuscula
        }
        public double Nota1
        {
            get { return nota1; }   
            set { nota1 = value; }
        }
        public double Nota2
        {
            get { return nota2; }   
            set { nota2 = value; }
        }
        public double Media
        {
            get { return media; }
           
        }

        public void CalcularMedia()
        {
            media = ((nota1 + nota2) / 2);
        }

        public string SituacaoAluno()
        {
            string msg =   "Reprovador";
            if (media >= 70) msg = "Aprovado";
            
            return msg;
            
        }
    }
}
