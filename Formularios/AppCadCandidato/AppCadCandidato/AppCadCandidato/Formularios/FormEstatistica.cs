using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCadCandidato.RegrasDeNegocio;
using AppCadCandidato.Contexto;

namespace AppCadCandidato.Formularios
{
    public partial class FormEstatistica : Form
    {
        List<Candidato> lista = new List<Candidato>();
        public FormEstatistica()
        {
            InitializeComponent();
            lista = Registro.cadastro;
            int qtdAp = lista.Where(k => k.Situacao == "APROVADO").Count() ;
            int qtdRep = lista.Where(k => k.Situacao == "REPROVADO").Count() ;
            int qtdAcima50 = lista.Where(k => k.Nota >=50 ).Count();
            int qtdAbaixo50 = lista.Where(k => k.Nota <50 ).Count();
            edQtdAprovados.Text = Convert.ToString(qtdAp);
            edQtdReprovados.Text = Convert.ToString(qtdRep);
            edQtdAcima50.Text = Convert.ToString(qtdAcima50);
            edqtdAbaixo50.Text = Convert.ToString(qtdAbaixo50);
            

        }

        private void edQtdAcima50_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
