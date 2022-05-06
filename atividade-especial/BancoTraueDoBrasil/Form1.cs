using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoTraueDoBrasil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(textSaque.Text);
            lbResultado.Text = CaixaEletronico.CalcularSaque(valor);
            lbResultado.Visible = true;
        }
    }
}
