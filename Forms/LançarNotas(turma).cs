using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alunos_e_Notas
{
    public partial class LançarNotas_turma_ : Form
    {
        public C_Alunos turma = Program.turma;
        public Nota nota = new Nota();
        FormMain main = new FormMain();
        int idx = 0;

        public LançarNotas_turma_()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(cbbDiscip.SelectedIndex == -1 || txtModulo.TextLength ==0 )
            {
                MessageBox.Show("Preencha os campos ativos");
                nota.disc = (discip)cbbDiscip.SelectedIndex;
                
            }

            else if (nota.VerifModulo(Convert.ToInt32(txtModulo.Text)) == false)
                MessageBox.Show("Modulo Impossivel");

            else
            {
                nota.disc = (discip)cbbDiscip.SelectedIndex;
                nota.modulo = Convert.ToInt32(txtModulo.Text); 
                cbbDiscip.Enabled = false;
                txtModulo.Enabled = false;

                txtNota.Enabled = true;
                btnLaunch.Enabled = true;

                lblNome.Text = "Nome: " + turma[idx].nome;
                lblNro.Text = "Nro: " + turma[idx].num;
            }
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
                       
            if (txtNota.TextLength == 0)
                MessageBox.Show("Escreva uma nota");

            else if (nota.VerifNota(Convert.ToDecimal(txtNota.Text)) == false)
                MessageBox.Show("Nota Impossivel");

            else if (idx == turma.Count - 1)
            {
                MessageBox.Show("Chegou ao fim dos alunos");
                this.Close();
                main.Show();
            }

            else
            {
                decimal n = Convert.ToDecimal(txtNota.Text);

                if (n <= 9)
                    n = -1;
                nota.nota = n;
                turma[idx].notas.Adicionar(nota);
                idx++;
                txtNota.Clear();               
            }

            lblNome.Text = "Nome: " + turma[idx].nome;
            lblNro.Text = "Nro: " + turma[idx].num;

        }

        private void LançarNotas_turma__FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain main = new FormMain();
        }

        private void txtModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
