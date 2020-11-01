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
    public partial class VentanaING : Form
    {
        DataTable Tabla = new DataTable();

        Validacion Control = new Validacion();

        int IbuprofenoCant = 30;
        int ParacetamolCant = 30;
        int PrecioIbu = 90;
        int PrecioPara = 60;
        DateTime LotePara = new DateTime(2021, 6, 15);
        DateTime LoteIbu = new DateTime(2021, 9, 20);
        public VentanaING( int ParacetamolCant , int IbuprofenoCant , int PrecioPara , int PrecioIbu)
        {
            this.ParacetamolCant = ParacetamolCant;
            this.IbuprofenoCant = IbuprofenoCant;
            this.PrecioIbu = PrecioIbu;
            this.PrecioPara = PrecioPara;

            
           
            InitializeComponent();
        }

        

       


        private void VentanaING_Load(object sender, EventArgs e)
        {

            
            

            Tabla.TableName = "Ventas";
            Tabla.Columns.Add("ID Producto" , typeof(string));
            Tabla.Columns.Add("Cantidad Vendida", typeof(int));
            Tabla.Columns.Add("Precio Unitario", typeof(int));
            Tabla.Columns.Add("Precio Total", typeof(int));
            Tabla.Columns.Add("Stock Actual", typeof(int));
            Tabla.Columns.Add("Vencimiento", typeof(DateTime));
            DGVventa.DataSource = Tabla;
        }


        private void ActivarBtn ()
        {
            btnComprar.Enabled = true;
        }
        
       

        private void txtCompra_KeyPress(object sender, KeyPressEventArgs e)
      {
            Control.SoloNumeros(e);
            ActivarBtn();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
           

            if (ParacetamolCant >= System.Convert.ToInt32(txtCompra.Text) || ParacetamolCant < System.Convert.ToInt32(txtCompra.Text))
            {
                lblTit.Visible = false;
                if (cmbBox1.SelectedIndex == 1 && ParacetamolCant > 0 && ParacetamolCant >= System.Convert.ToInt32(txtCompra.Text))
                {
                    ParacetamolCant = ParacetamolCant - System.Convert.ToInt32(txtCompra.Text);
                   
                    
                    Tabla.Rows.Add();
                    Tabla.Rows[Tabla.Rows.Count - 1]["ID Producto"] = cmbBox1.SelectedItem;
                    Tabla.Rows[Tabla.Rows.Count - 1]["Cantidad Vendida"] = System.Convert.ToInt32(txtCompra.Text);
                    Tabla.Rows[Tabla.Rows.Count - 1]["Precio Unitario"] = PrecioPara;
                    Tabla.Rows[Tabla.Rows.Count - 1]["Precio Total"] =  PrecioPara * System.Convert.ToInt32(txtCompra.Text);
                    Tabla.Rows[Tabla.Rows.Count - 1]["Stock Actual"] = ParacetamolCant ;
                    Tabla.Rows[Tabla.Rows.Count - 1]["Vencimiento"] = LotePara;
                }
                else if (cmbBox1.SelectedIndex == 1 && ParacetamolCant < System.Convert.ToInt32(txtCompra.Text))
                {
                    lblTit.Visible = true;
                    lblTit.Text = "El numero de venta ingresado supera al Stock , intente de nuevo con un valor menor";
                }

            }
            if (IbuprofenoCant >= System.Convert.ToInt32(txtCompra.Text) || IbuprofenoCant < System.Convert.ToInt32(txtCompra.Text))
            {
                if (cmbBox1.SelectedIndex == 0 && IbuprofenoCant > 0 && IbuprofenoCant >= System.Convert.ToInt32(txtCompra.Text))
                {
                    IbuprofenoCant = IbuprofenoCant - System.Convert.ToInt32(txtCompra.Text);
                    
                    Tabla.Rows.Add();
                    Tabla.Rows[Tabla.Rows.Count - 1]["ID Producto"] = cmbBox1.SelectedItem;
                    Tabla.Rows[Tabla.Rows.Count - 1]["Cantidad Vendida"] = System.Convert.ToInt32(txtCompra.Text);
                    Tabla.Rows[Tabla.Rows.Count - 1]["Precio Unitario"] = PrecioIbu;
                    Tabla.Rows[Tabla.Rows.Count - 1]["Precio Total"] = PrecioIbu * System.Convert.ToInt32(txtCompra.Text);
                    Tabla.Rows[Tabla.Rows.Count - 1]["Stock Actual"] = IbuprofenoCant  ;
                    Tabla.Rows[Tabla.Rows.Count - 1]["Vencimiento"] = LoteIbu ;

                }
                else if (cmbBox1.SelectedIndex == 0 && IbuprofenoCant < System.Convert.ToInt32(txtCompra.Text))
                {
                    lblTit.Visible = true;
                    lblTit.Text = "El numero de venta ingresado supera al Stock , intente de nuevo con un valor menor";
                }
            }
                                                                   
           
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
          //  Tabla.WriteXml
        }


        //private void cmbBox1_SelectedIndexChanged(object sender, EventArgs e)

    }

    
}
