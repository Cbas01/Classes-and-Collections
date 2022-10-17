using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Alunos_e_Notas
{
    public class C_Notas : Collection<Nota>
    {
        public void Adicionar(Nota nota)
        {
            base.Add(nota);
        }

        public void Inserir(int idx, Nota nota)
        {
            base.InsertItem(idx, nota);
        }

        public void Remover(Nota nota)
        {
            base.Remove(nota);
        }

        public void Remover(int idx)
        {
            base.RemoveAt(idx);
        }

        public void Copiar(C_Notas notas)
        {
            int idx; 
            for(idx = 0 ; idx < this.Count ; idx++)
            {
                notas[idx] = this[idx];
            }
        }
    }
}
