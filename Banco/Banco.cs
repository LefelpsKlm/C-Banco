using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Banco : Form
    {
        Cliente cliente;

        public Banco()
        {
            InitializeComponent();
            cliente = new Cliente();
        }

        private void Banco_Load(object sender, EventArgs e)
        {

        }

        private void aRQUIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(textBoxDeposito.Text);
                cliente.Creditar(valor);
                textBoxDeposito.Clear();
                MessageBox.Show("Deu serto pae. 😎");
                labelSaldoValor.Text = cliente.saldo.ToString("0.00");
            }
            catch
            {

            }
        }

        private void buttonSacar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBoxSacar.Text);
            cliente.Debitar(valor);
            if (valor > 0)
            {
                MessageBox.Show("Deu serto pae. 😎");
                labelSaldoValor.Text = cliente.saldo.ToString();
                textBoxSacar.Clear();
            }
            else
            {
                MessageBox.Show("Infelizmente ocorreu um erro, tente novamente.");
                textBoxSacar.Clear();
            }
        }

        private void buttonClique_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você sabeu mais um pouco. Parabéns!");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}