using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Precio_Total_Con_Iva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double subtotal, iva, total;
            subtotal = double.Parse(txtvalorproducto.Text);
            txtsubtotal.Text = Convert.ToString(String.Format("{0:n0}", subtotal));
            iva = subtotal * 0.19;
            txtiva.Text = Convert.ToString(String.Format("{0:n0}", iva));
            total = subtotal + iva;
            txttotal.Text = Convert.ToString(String.Format("{0:n0}", total));
        }

        private void btningresonuevovalor_Click(object sender, EventArgs e)
        {
            txtvalorproducto.Text = String.Empty;
            txtsubtotal.Text = String.Empty;
            txtiva.Text = String.Empty;
            txttotal.Text = String.Empty;
            txtvalorproducto.Focus();
        }

       
    } 
}
