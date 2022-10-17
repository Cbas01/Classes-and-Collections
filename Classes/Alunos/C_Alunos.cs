using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Alunos_e_Notas
{
    public class C_Alunos : Collection<Aluno>
    {
        public void Adicionar(Aluno aluno)
        {
            base.Add(aluno);
        }

        public void Inserir(int idx, Aluno aluno)
        {
            base.InsertItem(idx, aluno);
        }

        public void Remover(Aluno aluno)
        {
            base.Remove(aluno);
        }

        public void RemoverEm(int idx)
        {
            base.RemoveAt(idx);
        }

        public bool VerifNro(int nro)
        {
            foreach (Aluno a in this)
            {
                if (nro == a.num)
                    return false;                                 
            }

            return true;
        }
    }
}
