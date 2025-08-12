using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCadCandidato.Contexto;
using AppCadCandidato.RegrasDeNegocio; 

namespace AppCadCandidato.Formularios
{
    public partial class FormConsulta : Form
    {
        List<Candidato> lista = Registro.cadastro; 
        public FormConsulta()
        {
            InitializeComponent();
            cbNome.DataSource = lista.ToList();
            cbNome.DisplayMember = "Nome";
            cbNome.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNome.SelectedIndex > -1)
            {
                Candidato candidato = new Candidato();
                candidato = lista.ToList().ElementAt(cbNome.SelectedIndex);
                edInscricao.Text = candidato.Insc.ToString();
                edNome.Text = candidato.Nome;
                edNota.Text = candidato.Nota.ToString();
                edSituacao.Text = candidato.Situacao;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
