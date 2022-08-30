using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_1
{
    public class Koduloom2 : koduloom
    {
        public string toug;

        public Koduloom2(string nimi,string varv, char sugu, double kaal,int vanus,bool elav, string toug) :base(nimi,varv,sugu,kaal,vanus,elav)
        { 
            this.toug = toug;
        }

        public override void print_Info()
        {
            string sugu_text = "";
            if (sugu == 'I')
            {
                sugu_text = "Isane";
            }
            else if (sugu == 'E')
            {
                sugu_text = "Emane";
            }
            if (elav == true)
            {
                Console.WriteLine("Koer on elav :)");

            }
            else if (elav == false)
            {
                Console.WriteLine("Koer on surnud :(");
            }

            Console.WriteLine($"{varv} {nimi} ta on {sugu_text} ja tema kaal on {kaal}. Ta on {vanus} aastat vana ja ta on {toug}", elav, varv, nimi, sugu_text, kaal, vanus, toug);
        }
    }
}
