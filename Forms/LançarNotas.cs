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
    public partial class LançarNotas : Form
    {
        public C_Alunos turma = Program.turma;
        public Nota aval = new Nota();
        FormMain main = new FormMain();

        public LançarNotas()
        {
            InitializeComponent();
        }

        private void LançarNotas_Activated(object sender, EventArgs e)
        {
            //adicionar alunos a listbox
            foreach (Aluno aluno in turma)
            {
                string list = aluno.nome + ", " + Convert.ToString(aluno.num);
                lstAlunos.Items.Add(list);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verificar se esta algum aluno seleccionado
            if (lstAlunos.SelectedIndex == -1)
                MessageBox.Show("Seleccione um aluno!");

            else if (txtNota.TextLength == 0 || txtModulo.TextLength == 0 || cbbDiscip.SelectedIndex == -1)
                MessageBox.Show("Preencha todos os campos!");

            else if (aval.VerifNota(Convert.ToDecimal(txtNota.Text)) == false)
                MessageBox.Show("Nota Impossivel");

            else
            {

                //verificar aluno seleccionado
                string selec = lstAlunos.SelectedItem.ToString();
                string subSelec = selec.Substring(selec.IndexOf(",") + 2);
                int nro = Convert.ToInt32(subSelec);
                int mod = Convert.ToInt32(txtModulo.Text);
                int disc = cbbDiscip.SelectedIndex;
                decimal n = Convert.ToDecimal(txtNota.Text);
                aval.disc = (discip)disc;
                aval.modulo = mod;
                if (n <= 9)
                    n = -1;

                aval.nota = n;

                foreach (Aluno a in turma)
                {
                    //encontrou o aluno
                    if (a.num == nro)
                    {
                        if (a.VerifNotaExist(aval) == true)
                        {
                            DialogResult dialogResult = MessageBox.Show("Deseja alterar a nota?", "Alterar", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                                a.notas.Adicionar(aval);
                        }

                        else
                            a.notas.Adicionar(aval);
                    }
                }

                this.Hide();
                main.Show();
            }
           
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

        }

        private void txtModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void LançarNotas_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Show();
        }

        
    }
}
