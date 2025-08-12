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
using ClosedXML.Excel;

namespace AppCadCandidato.Formularios
{
 
    public partial class FormLista : Form
    {
        List<Candidato> listaCand = Registro.cadastro;
        XLWorkbook pasta = new XLWorkbook(@"C:\Users\2021202060005\Documents\Cantidatos.xlsx");
        public FormLista()
        {
            InitializeComponent();
            bindingSource1.DataSource = listaCand.ToList(); // ordem normal da lista
            //bindingSource1.DataSource = listaCand.OrderBy(k => k.Nome).ToList(); // ordem alfabética
            gdLista.DataSource = bindingSource1; 
        }
        public void ContarRegistro()
        {

            var plan1 = pasta.Worksheet(1);
            int l = 2;
            Registro.cadastro.Clear();
            while (plan1.Cell(l, 1).Value != "")
            {
                Candidato candidato = new Candidato();
                candidato.Insc = Convert.ToInt32((plan1.Cell(l, 1).Value.ToString()));
                candidato.Nome = plan1.Cell(l, 2).Value.ToString();
                candidato.Nota = Convert.ToUInt32((plan1.Cell(l, 3).Value.ToString()));

                Registro.cadastro.Add(candidato);
                l++;
            }
            listaCand = Registro.cadastro;
        }
    }
}
