using System;
using System.Collections.Generic;
using System.Text;

namespace Interfesz
{
    abstract class GepiJatekos : ITippelo//, IStatisztikatSzolgaltat
    {
        protected int alsoHatar;
        protected int felsoHatar;

        int nyertDB;
        int veszitettDB;

        

        public virtual void JatekIndul(int alsoHatar, int felsoHatar)
        {
            this.alsoHatar = alsoHatar;
            this.felsoHatar = felsoHatar;
        }

        public abstract int KovetkezoTipp();

        public void Nyert()
        {
            nyertDB++;
        }

        public void Veszitett()
        {
            veszitettDB++;
        }

       // public int HanyszorNyert { get { return nyertDB; } }

       // public int HanyszorVesztett { get { return veszitettDB; } }

    }
}
