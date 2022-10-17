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
    public partial class FormMain : Form
    {
        public C_Alunos turma = Program.turma;
        public C_Notas notas = new C_Notas();
        public FormMain()
        {
            InitializeComponent();
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Alunos add = new Add_Alunos();
            add.Show();
            this.Hide();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int l = 0;
            lstvAlunos.Items.Clear();

            foreach(Aluno a in turma)
            {
                if (a.notas.Count() != 0)
                {
                    foreach (Nota n in a.notas)
                    {
                        lstvAlunos.Items.Add(a.num.ToString());
                        lstvAlunos.Items[l].SubItems.Add(n.disc.ToString());
                        lstvAlunos.Items[l].SubItems.Add(n.modulo.ToString());

                        if (n.nota == -1)
                            lstvAlunos.Items[l].SubItems.Add("Modulo em atraso");

                        else
                            lstvAlunos.Items[l].SubItems.Add(n.nota.ToString());

                        l++;
                    }
                }
            }
            


            /*foreach (Aluno a in turma)
            {
               
                if (a.notas.Count != 0)
                {
                    a.notas.Copiar(notas);
                    string num = Convert.ToString(a.num);
                    string nome = a.nome;

                    foreach (Nota n in notas)
                    {
                        string disc = Convert.ToString(n.disc);
                        string mod = Convert.ToString(n.modulo);
                        string nota = Convert.ToString(n.nota);

                        string[] row = { num, nome, disc, mod, nota };
                        var listViewItem = new ListViewItem(row);
                        lstvAlunos.Items.Add(listViewItem);
                    }
                }        

            }*/
        }

        private void lançarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LançarNotas notas1 = new LançarNotas();
            notas1.Show();
            this.Hide();
        }

        private void lançarNotatodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LançarNotas_turma_ notasTurma = new LançarNotas_turma_();
            notasTurma.Show();
            this.Hide();
        }

     
    }
}
