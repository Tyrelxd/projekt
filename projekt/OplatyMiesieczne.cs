using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class OplatyMiesieczne : Zakupy
    {
        public string Ilepowtorzen;

       override public string Wypisz()
        {
            string x;
            x = "Nazwa: " + this.nazwa + ", koszt: "
                + this.koszt + "ile powtorzen:" + this.Ilepowtorzen;

            return x;
        }

    }
}
