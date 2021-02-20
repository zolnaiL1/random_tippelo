using System;
using System.Collections.Generic;
using System.Text;

namespace Interfesz
{
    class EmberiJatekos : IOkosTippelo
    {
        public void JatekIndul(int alsoHatar, int felsoHatar)
        {
            Console.WriteLine($"Kezdődik a határ a megadott határokkal: {alsoHatar},{felsoHatar}");
        }

        public void Kisebb()
        {
            Console.WriteLine("Az előző tippnél kisebb a keresett szám");
        }

        public int KovetkezoTipp()
        {           
            Console.WriteLine("Add meg a következő tippet: ");
            
            int kovetkezoTipp1;
            kovetkezoTipp1 = int.Parse(Console.ReadLine());

            return kovetkezoTipp1;
        }

        public void Nagyobb()
        {
            Console.WriteLine("Az előző tippnél nagyobb a keresett szám");
        }

        public void Nyert()
        {
            Console.WriteLine("Nyertél! :)");
        }

        public void Veszitett()
        {
            Console.WriteLine("Veszítettél! :(");
        }
    }
}
