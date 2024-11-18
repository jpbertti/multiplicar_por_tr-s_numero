using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiplicar_por_três_numero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtNumero.Focus();
            lsbResultado.Items.Clear();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lsbResultado.Items.Clear();

            int valor = int.Parse(txtNumero.Text);

           
            while (valor <= 100)
            {
                lsbResultado.Items.Add (valor);
                valor *=3;
            }
        }
    }
}
