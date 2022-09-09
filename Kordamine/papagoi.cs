using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Papagoi : Koduloom
    {
        public enum tougP { Jaco, Ara, Kakaduu, kakariki, kea };
        public tougP TougPapagoi;

        public Papagoi(tougP TougPapagoi, string nimi, string varv, sugu loomaSugu, double kaal, int vanus, bool elav) : base(nimi, varv, loomaSugu, kaal, vanus, elav)
        {
            this.TougPapagoi = TougPapagoi;
        }

        public Papagoi(string nimi, string varv)
        {
            this.nimi = nimi;
            this.varv = varv;

        }

        public Papagoi(Papagoi papagoi) //kloonimiseks
        {
            this.nimi = papagoi.nimi;
            this.TougPapagoi = papagoi.TougPapagoi;
            this.varv = papagoi.varv;
            this.loomaSugu = papagoi.loomaSugu;
            this.kaal = papagoi.kaal;
            this.vanus = papagoi.vanus;
            this.elav = papagoi.elav;
        }
        
        public Papagoi(string nimi)
        {
            this.nimi=nimi;
        }

        public override void print_Haal()
        {
            Console.WriteLine("kar kar");
        }

        public override string print_Info()
        {
            string text = $"Tõug on{TougPapagoi}, Tema nimi {nimi}, Värv on{varv}, papagoi sugu on{loomaSugu}, kaal on{kaal} ja tema vanus on{vanus}";

            return text;
        }
        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
        public void muudaVarv(string Varv) { varv = Varv; }
        public void muudaKaal(double Kaal) { kaal = Kaal; }
        public void muudaVanus(int Vanus) { vanus = Vanus; }
    }
}
