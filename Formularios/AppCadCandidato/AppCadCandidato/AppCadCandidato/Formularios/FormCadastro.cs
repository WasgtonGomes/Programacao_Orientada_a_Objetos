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
using ClosedXML.Excel;

namespace AppCadCandidato.Formularios
{
    
    public partial class FormCadastro : Form
    {
        XLWorkbook pasta = new XLWorkbook (@"C:\Users\2021202060005\Documents\Cantidatos.xlsx");
        
        private  int numInscricao = 0; 
        private  int linha = 2;
        public FormCadastro()
        {
            InitializeComponent();
            edNome.Enabled = false;
            edNota.Enabled = false;
            edInscricao.Enabled = false;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;
            ContarRegistro(); // chamada do contador do método de contador de registro
        }

        private void Cancelar()
        {
    
            edNome.Clear();
            edNota.Clear();
            edInscricao.Clear();
            edNome.Enabled = false;
            edNota.Enabled = false;
            edInscricao.Enabled = false;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;
            btAdd.Enabled = true;
            edNome.Select();
            numInscricao--;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            edNome.Enabled = true;
            edNota.Enabled = true;
            btSalvar.Enabled=true;
            btAdd.Enabled = false;
            btCancelar.Enabled = true;
            numInscricao++;
            edInscricao.Text = numInscricao.ToString();
            edNome.Select(); 

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Cancelar(); 
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            var plan1 = pasta.Worksheet(1); // CHAMADA DE PLANILHA
            Candidato candidato = new Candidato();
            candidato.Nome = edNome.Text;
            candidato.Nota = Convert.ToDouble(edNota.Text);
            candidato.Insc = numInscricao;
            Registro.cadastro.Add(candidato);
            plan1.Cell(linha, 1).Value = candidato.Insc;
            plan1.Cell(linha, 2).Value = candidato.Nome;
            plan1.Cell(linha, 3).Value = candidato.Nota;
            plan1.Cell(linha, 4).Value = candidato.Situacao;
            pasta.Save();
            linha++;

            MessageBox.Show("SALVO COM SUCESSO!");
            edNome.Clear();
            edNota.Clear();
            edInscricao.Clear();
            edNota.Enabled=false;  
            edNome.Enabled=false;
            btCancelar.Enabled=false;  
            btSalvar.Enabled = false;
            btAdd.Enabled = true; 

        }
        public void ContarRegistro()
        {

            var plan1 = pasta.Worksheet(1);
            int l = 2;
            Registro.cadastro.Clear();
            while (plan1.Cell(l,1).Value !="")
            {
                Candidato candidato = new Candidato();
                candidato.Insc = Convert.ToInt32((plan1.Cell(l, 1).Value.ToString()));
                candidato.Nome = plan1.Cell(l, 2).Value.ToString();
                candidato.Nota = Convert.ToUInt32((plan1.Cell(l,3).Value.ToString()));
                
                Registro.cadastro.Add(candidato);
                l++;
            }
            linha = l;
            numInscricao = l -2;
        }
    }
}
