using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ersatzteile
{
    public class Teile
    {
        public static int e_id_last;//globale variable fuer uberall

        public int e_id;
        public string teilename;
        public byte[] teilecaddatei;
        public byte[] teilebild;
        public byte[] teilebildausrichtung;
        public double teilevolume;
        public double teileproduktionszeit;
        public string teilekonfiguration;

        public Teile()
        {
            this.e_id=99;
            this.teilename="geschafft";
            this.teilevolume=5.5;
            this.teileproduktionszeit=5.1;
            this.teilekonfiguration = "leer";
        }
    }
}
