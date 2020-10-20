using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsutarCeps
{
    public partial class FRMconsultar_cep : Form
    {
        public FRMconsultar_cep()
        {
            InitializeComponent();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txCep.Text))
            {
                using (var ws = new WScorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(txCep.Text.Trim());
                        txEstado.Text = endereco.uf;
                        txCidade.Text = endereco.cidade;
                        txBairro.Text = endereco.bairro;
                        txRua.Text = endereco.end;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP valido", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txCep.Text = String.Empty;
            txCidade.Text = String.Empty;
            txEstado.Text = String.Empty;
            txBairro.Text = String.Empty;
            txRua.Text = String.Empty;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
