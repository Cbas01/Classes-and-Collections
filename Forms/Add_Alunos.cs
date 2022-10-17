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
    public partial class Add_Alunos : Form
    {
        public C_Alunos turma = Program.turma;
        FormMain main = new FormMain();
        public Add_Alunos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            if (aluno.VerifIdade(dtpNasc.Value) == false)
            {
                MessageBox.Show("Idade Inválida");
            }


            else if (turma.VerifNro(Convert.ToInt32(txtNum.Text)) == false)
            {
                MessageBox.Show("O numero de aluno indicado já foi utilizado");
                txtNum.Clear();
            }

            else if (txtNome.TextLength == 0 || txtNum.TextLength == 0)
                MessageBox.Show("Preencha todos os campos");

            else
            {
                turma.Adicionar(aluno);
                aluno.num = Convert.ToInt32(txtNum.Text);
                aluno.nome = txtNome.Text;
                aluno.dob = dtpNasc.Value;
                this.Hide();
                main.Show();
            }           
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Add_Alunos_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain main = new FormMain();
        }
    }
}
