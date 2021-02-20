using System;
using System.Collections.Generic;
using System.Text;

namespace Interfesz
{
    class SzamKitalaloJatekKaszino //: SzamKitalaloJatek
    {
        protected int kaszinoNyert;
        protected int kaszinoVeszitett;
        protected int korokSzama;

        public SzamKitalaloJatekKaszino(int kaszinoNyert, int kaszinoVeszitett, int korokSzama) //: base (alsoHatar, felsoHatar)
        {
            this.kaszinoNyert = kaszinoNyert;
            this.kaszinoVeszitett = kaszinoVeszitett;
            this.korokSzama = korokSzama;
        }

        //public override void Jatek()
        //{ 
        
        //}
    }
}
