using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos_e_Notas
{
    public enum discip
        {
            PT,
            ING,
            TIC,
            EF,
            AI,
            FQ,
            MAT,
            PSI,
            SO,
            AC,
            RC,
        }

    public class Nota
    {
        

        public discip disc { get; set; }
        public int modulo {get; set ; }
        public decimal nota { get; set; }

        public bool VerifModulo(int m)
        {
            if (m > 1 && m < 24)
                return true;
            else
                return false;
            
        }

        public bool VerifNota (decimal n)
        {
            if ((n >= 0 && n <= 20))
                return true;
            else
                return false;
            
        }

    }
}

