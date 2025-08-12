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
    public partial class FormMegaSena : System.Windows.Forms.Form
    {
        List<NumeroDasSorte> lista = new List<NumeroDasSorte>();
        public FormMegaSena()
        {
            InitializeComponent();
            gridNumeros.DataSource = bindingSource1;
        }

        private void FormMegaSena_Load(object sender, EventArgs e)
        {

        }
    }
}
