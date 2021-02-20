using System;
using System.Collections.Generic;
using System.Text;

namespace Interfesz
{
    class LogaritmikusKereso : GepiJatekos, IOkosTippelo
    {
        public override int KovetkezoTipp()
        {
            return (alsoHatar+felsoHatar)/2;
        }

        public void Kisebb()
        {
            felsoHatar -= 1;
        }

        public void Nagyobb()
        {
            alsoHatar += 1;
        }
    }
}
