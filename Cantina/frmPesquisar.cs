using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked)
            {
                if (!txtDescricao.Text.Equals(""))
                {
                    ltbPesquisar.Items.Clear();
                    ltbPesquisar.Items.Add(txtDescricao.Text);
                }
                else
                {
                    MessageBox.Show("Favor inserir valores válidos!");
                    txtDescricao.Focus();
                }
            }
            if (rdbNome.Checked)
            {
                if (!txtDescricao.Text.Equals(""))
                {
                    ltbPesquisar.Items.Clear();
                    ltbPesquisar.Items.Add(txtDescricao.Text);
                }
                else
                {
                    MessageBox.Show("Favor inserir valores válidos!");
                    txtDescricao.Focus();
                }
            }
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
            btnPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
            btnPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
        }


        public void limparCampos()
        {
            txtDescricao.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            ltbPesquisar.Items.Clear();
            txtDescricao.Enabled = false;
            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
