using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;

namespace ConsultaCEP
{
    public partial class frmCep : Form
    {
        public frmCep()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCep.Text))
                MessageBox.Show("O campo Cep esta vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                CorreiosApi correiosApi = new CorreiosApi();
                var retorno = correiosApi.consultaCEP(txtCep.Text);

                if (retorno is null)
                {
                    MessageBox.Show("Cep não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                lblEstadoRes.Text = retorno.uf; ;
                lblCidadeRes.Text = retorno.cidade;
                lblEnderecoRes.Text = retorno.end;
                lblComplementoRes.Text = retorno.complemento;
                lblBairroRes.Text = retorno.bairro;
                lblUnidadePostRes.Text = retorno.id.ToString();
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblComplementoRes.Text = "__________";
            lblBairroRes.Text = "__________";
            lblCidadeRes.Text = "__________";
            lblComplementoRes.Text = "__________";
            lblEnderecoRes.Text = "__________";
            lblEstadoRes.Text = "__________";
            lblUnidadePostRes.Text = "__________";
            txtCep.Text = "";


        }
    }
}
