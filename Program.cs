using System;

namespace Interfesz
{
    class Program
    {
        public static void Teszt1()
        {
            SzamKitalaloJatek teszt1 = new SzamKitalaloJatek(10, 20);
            VeletlenTippelo veletlen = new VeletlenTippelo();
            BejaroTippelo bejaro = new BejaroTippelo();

            teszt1.VersenyzoFelvetele(veletlen);
            teszt1.VersenyzoFelvetele(bejaro);
            teszt1.Jatek();

        }
        static void Main(string[] args)
        {
            Teszt1();
            //asdasda
        }
    }
}
