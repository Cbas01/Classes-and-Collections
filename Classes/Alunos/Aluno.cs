using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos_e_Notas
{
    public class Aluno
    {
        public int num { get; set; }
        public string nome { get; set; }
        public DateTime dob { get; set; }
        public C_Notas notas= new C_Notas();

        public bool VerifIdade(DateTime birthDate)
        {
            int anos = DateTime.Now.Year - birthDate.Year;
            
            if (DateTime.Now.Month < birthDate.Month || (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day))
            {
                anos--;
            }

            if (anos >= 6 && anos <= 25)
                return true;

            else
                return false;

        }

        public bool VerifNotaExist(Nota nota )
        {
            foreach (Nota n in notas)
            {
                if (n.disc == nota.disc && n.modulo == nota.modulo)
                {
                    return true;
                }                
            }

            return false;
        }

    }
}
