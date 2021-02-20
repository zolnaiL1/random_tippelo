using System;
using System.Collections.Generic;
using System.Text;

namespace Interfesz
{
    class BejaroTippelo : GepiJatekos
    {
        int aktualis;

        public override void JatekIndul(int alsoHatar, int felsoHatar)
        {
            aktualis = alsoHatar;
        }

        public override int KovetkezoTipp()
        {
            //aktualis++;
            return ++aktualis;
        }
    }
}
