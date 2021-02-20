using System;

namespace Interfesz
{
    class Program
    {
        public static void Teszt()
        {
            SzamKitalaloJatek teszt = new SzamKitalaloJatek(10, 20);
            VeletlenTippelo veletlen = new VeletlenTippelo();
            BejaroTippelo bejaro = new BejaroTippelo();
            LogaritmikusKereso log = new LogaritmikusKereso();            
            
            teszt.VersenyzoFelvetele(veletlen);
            teszt.VersenyzoFelvetele(bejaro);
            teszt.VersenyzoFelvetele(log);
            
            teszt.Statisztika(1000);

        }
        static void Main(string[] args)
        {
            Teszt();
            //asdasda
        }
    }
}
