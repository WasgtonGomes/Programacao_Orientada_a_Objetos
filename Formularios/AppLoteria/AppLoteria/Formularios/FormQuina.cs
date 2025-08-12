using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLoteria.RegrasDeNegocio;

namespace AppLoteria.Formularios
{
    public partial class FormQuina : System.Windows.Forms.Form
    {
        List<NumeroDasSorte> lista = new List<NumeroDasSorte>();
        public FormQuina()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            int numeroTemp = 0;
            int contador = 0;
            Random rand = new Random();

            while (contador < 15)
            {
                numeroTemp = rand.Next(1, 81);
                NumeroDasSorte numero = new NumeroDasSorte();
                if (lista.Count(n => n.Numero == numeroTemp) == 0)
                {
                    numero.Numero = numeroTemp; // objeto recebe numero
                    lista.Add(numero);         //  Adiciona objeto na lista
                    contador++;
                }


            }
            bindingSource1.DataSource = lista.OrderBy(n => n.Numero).ToList();
            gridNumerosQuina.DataSource = bindingSource1;  // grid recebe o bindingSource1 
            btGerarQuina.Enabled = false;
            
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            lista.Clear();
            bindingSource1.DataSource = lista.ToList();
            btGerarQuina.Enabled = true;
            lbImpar.Text = "ÍMPARES: ";
            lbPar.Text = "PARES : ";
            lbAnalise.Text = "ANÁLISE: ";
        }




        private void gridNumerosQuina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
