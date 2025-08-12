using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCadCandidato.Formularios; 

namespace AppCadCandidato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro form = new FormCadastro();
            form.ShowDialog();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            FormLista form = new FormLista();
            form.ShowDialog();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            FormConsulta form = new FormConsulta();
            form.ShowDialog(); 
        }

        private void btStatistica_Click(object sender, EventArgs e)
        {
            FormEstatistica form = new FormEstatistica();
            form.ShowDialog();
        }
    }
}
