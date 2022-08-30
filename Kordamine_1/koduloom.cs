using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_1
{
    public abstract class koduloom
    {
        public string nimi;
        public string varv;
        public char sugu;
        public double kaal;
        public int vanus;
        public bool elav; //kui true, siis elav; kui false, siis on surnud

        public koduloom()
        { }

        public koduloom(string nimi = "---", string varv = "---", char sugu='-', double kaal=0.0, int vanus=0, bool elav=false)
        {
            this.nimi = nimi;
            this.varv = varv;
            this.sugu = sugu;
            this.kaal = kaal;
            this.vanus = vanus;
            this.elav = elav;
        }
        public koduloom(koduloom loom) // kloonimiseks
        {
            this.nimi = loom.nimi;
            this.varv = loom.varv;
            this.sugu = loom.sugu;
            this.kaal = loom.kaal;
            this.vanus = loom.vanus;
            this.elav = loom.elav;
        }
        public abstract void print_Info();
        //{
            //string sugu_text = "";
            //if (sugu == 'I')
            //{
            //    sugu_text = "Isane";
            //}
            //else if (sugu == 'E')
            //{
            //    sugu_text = "Emane";
            //}
            //if (elav==true)
            //{
            //    Console.WriteLine("Kass on elav :)");

            //}
            //else if (elav==false)
            //{
            //    Console.WriteLine("Kass on surnud :(");
            //}

            //Console.WriteLine("{1} {2} ta on {3} ja tema kaal on {4} ja ta on {5} aastat vana",elav,varv,nimi,sugu_text,kaal,vanus);
        //}
        public void muuda_Nimi(string uusNimi) { nimi = uusNimi; }
        public void muuda_varv(string uusVarv) { varv = uusVarv; }
        public void muuda_kaal(double uusKaal) { kaal = uusKaal; }
    }   
}
