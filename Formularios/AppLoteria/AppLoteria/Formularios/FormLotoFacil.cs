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
    public partial class FormLotoFacil : System.Windows.Forms.Form
    {
        List<NumeroDasSorte> lista= new List<NumeroDasSorte>();
        List<NumeroDasSorte> listaOrdenadaLotofacio= new List<NumeroDasSorte>();

        public FormLotoFacil()
        {
            InitializeComponent();
            gridNumeros.DataSource = bindingSource1;


        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            int numeroTemp = 0;
            int contador = 0 ;
            Random rand = new Random();
            
            while (contador < 15)
            {
                numeroTemp = rand.Next(1,26);
                NumeroDasSorte numero = new NumeroDasSorte();
                if(lista.Count(n=> n.Numero == numeroTemp) == 0)
                {
                    numero.Numero = numeroTemp; // objeto recebe numero
                    lista.Add(numero);         //  Adiciona objeto na lista
                    contador++;

                }


            }
            bindingSource1.DataSource= lista.OrderBy(n=>n.Numero).ToList();

            //for (int i = 1; i < 26; i++)
            //{
            //   bindingSource1.DataSource = listaOrdenadaLotofacio.AddRange(n.NumOrdem).ToList();
            //}
            

            gridNumeros.DataSource = bindingSource1;  // grid recebe o bindingSource1 
            btGerar.Enabled = false;
            AnalizarJogo();


        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            lista.Clear();
            bindingSource1.DataSource = lista.ToList();
            btGerar.Enabled = true;
            lbImpar.Text = "ÍMPARES: ";
            lbPar.Text = "PARES : ";
            lbAnalise.Text = "ANÁLISE: ";
            
        }
        public void AnalizarJogo()
        {
            int par = lista.Count(n => n.Tipo() == "par");
            int impar= lista.Count(n => n.Tipo() == "impar");
            if (impar == 8)
            {
                lbAnalise.Text = " ANÁLISE: ÓTIMO JOGO";
                lbAnalise.ForeColor = Color.Green;
            }
            if (par == 8)
            {
                lbAnalise.Text = " ANÁLISE: BOM JOGO";
                lbAnalise.ForeColor = Color.Green;
            }
            if (impar == 9)
            {
                lbAnalise.Text = " ANÁLISE: JOGO REGULAR";
                lbAnalise.ForeColor = Color.Orange;
            }
            if(par<6|| impar < 7)
            {
                lbAnalise.Text = " ANÁLISE: JOGO RUIM";
                lbAnalise.ForeColor = Color.Red;
            }
            lbPar.Text = "PARES : "+ par.ToString();
            lbImpar.Text ="IMPARES : "  + impar.ToString();
        }


        private void FormLotoFacil_Load(object sender, EventArgs e)
        {

        }

        private void gridNumeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
