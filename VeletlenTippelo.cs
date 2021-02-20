using System;
using System.Collections.Generic;
using System.Text;

namespace Interfesz
{
    class VeletlenTippelo : GepiJatekos
    {
        public static Random r = new Random();

        public override int KovetkezoTipp()
        {           
            return r.Next(alsoHatar, felsoHatar);
        }
    }
}
