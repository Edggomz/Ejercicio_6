using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejecicio_6
{
    public partial class frmPerimetro : Form
    {   double lado, perimetro;

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLado.Text, out lado))
            {
                perimetro = 4 * lado;
                txtPerimetro.Text = perimetro.ToString("N2");
            }
            else
            {
                txtPerimetro.Text = "Entrada inválida";
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtLado.Clear();
            txtPerimetro.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public frmPerimetro()
        {
            InitializeComponent();
        }
        
        

    }
}
