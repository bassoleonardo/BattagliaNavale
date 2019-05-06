using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattagliaNavale
{
    class nave
    {
        public int grandezza; public int posl;
        public string nome; public int posh;
        public nave()
        {
            grandezza = 0; posh = 0;
            nome = ""; posl = 0;
        }
        public nave(int pos, int grandezza, string[] nominave)
        {
            nome = nominave[pos];
            this.grandezza = grandezza;
        }
        public void Posizionamento(int posh, int posl)
        {
            this.posh = posh;
            this.posl = posl;
        }
    }
}
