using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_Hackathon
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        int IbuprofenoCant = 30;
        int ParacetamolCant = 30;
        int PrecioIbu = 90;
        int PrecioPara = 60;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Form Ventana = new VentanaING (ParacetamolCant , IbuprofenoCant, PrecioIbu , PrecioPara);
            Ventana.ShowDialog();
        
        }
    }

  
}

