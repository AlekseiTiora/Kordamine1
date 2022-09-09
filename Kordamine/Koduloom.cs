using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    abstract class Koduloom
    {
        public string nimi;
        public string varv;
        
        public enum sugu { isane,emane};
        public sugu loomaSugu;
        public double kaal;
        public int vanus;
        public bool elav; //kui true, siis elav; kui false siis on surnud

        public Koduloom(string nimi, string varv, sugu loomaSugu, double kaal =0.0, int vanus= 0, bool elav = false)
        {
            this.nimi = nimi;
            this.varv = varv;
            this.loomaSugu = loomaSugu;
            this.kaal = kaal;
            this.vanus = vanus;
            this.elav = elav;
        }

        public Koduloom(string nimi)
        {
            this.nimi = nimi;
        }
        public Koduloom() { }
        public abstract string print_Info();
        public abstract void print_Haal();
    }
}
