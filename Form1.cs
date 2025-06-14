using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_el_cambio_según_una_compra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblError.Text = "";
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            double dinero, costo, cambio;
            if (string.IsNullOrEmpty(txtDinero.Text)||string.IsNullOrEmpty(txtCosto.Text))
            {
                lblError.Text = "Existe un campo vacio\n por favor ingresa un dato numerico";
            }
            else 
            { 
            costo=double.Parse(txtCosto.Text);
                dinero=double.Parse(txtDinero.Text);
                if (costo<=0||dinero<=0)
                {
                    lblError.Text = "Error \ningrese un dato numerico valido";
                    txtCambio.Text = "";
                }
                else 
                {
                    cambio = dinero-costo;
                    txtCambio.Text = cambio.ToString("N2");
                    lblError.Text=string.Empty;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCambio.Text=string.Empty;
            txtCosto.Text=string.Empty;
           txtDinero.Text=string.Empty;
            lblError.Text=string.Empty;
        }
    }
}
