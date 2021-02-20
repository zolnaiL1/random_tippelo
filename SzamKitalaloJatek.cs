using System;
using System.Collections.Generic;
using System.Text;

namespace Interfesz
{
    class SzamKitalaloJatek
    {
        static Random r = new Random();

        int MAX_VERSENYZO = 5;
        public ITippelo[] versenyzok;
        int versenyzoN;
        int alsoHatar;
        int felsoHatar;

        int cel;

        public SzamKitalaloJatek(int alsoHatar, int felsoHatar)
        {
            this.alsoHatar = alsoHatar;
            this.felsoHatar = felsoHatar;

            versenyzoN = 0;
            versenyzok = new ITippelo[versenyzoN];
        }

        public void VersenyzoFelvetele(ITippelo jatekos)
        {
            if (MAX_VERSENYZO > versenyzok.Length)
            {
                versenyzoN++;
                ITippelo[] bovitettVersenyzok = new ITippelo[versenyzoN];

                //Console.WriteLine(bovitettVersenyzok.Length);

                for (int i = 0; i < versenyzok.Length; i++)
                {
                    
                    bovitettVersenyzok[i] = versenyzok[i];                   
                }

                bovitettVersenyzok[versenyzoN-1] = jatekos;
                versenyzok = bovitettVersenyzok;
            }
        }
        public void VersenyIndul(int alsoHatar, int felsoHatar)
        {
            this.cel = r.Next(alsoHatar, felsoHatar);

            Console.WriteLine($"cel: {cel}");

            for (int i = 0; i < versenyzok.Length; i++)
            {
                versenyzok[i].JatekIndul(alsoHatar, felsoHatar);
            }
        }

        public bool MindenkiTippel()
        {
            bool vanNyertes = false;
            Console.WriteLine("Mindenki Tippel");
            for (int i = 0; i < versenyzok.Length; i++)
            {
                //versenyzok[i].KovetkezoTipp();

                int teszt1 = versenyzok[i].KovetkezoTipp();               
                Console.WriteLine($"{versenyzok[i]} tipp: {teszt1}");

                if (cel == teszt1)
                {
                    vanNyertes = true;
                    versenyzok[i].Nyert();
                }
                else
                {
                    versenyzok[i].Veszitett();
                }
            }

            if (vanNyertes == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Jatek()
        {
            VersenyIndul(alsoHatar, felsoHatar);

            bool vanNyertes = MindenkiTippel();

            while (!vanNyertes)
            {              
                
                vanNyertes = MindenkiTippel();
            }
        }
    }
}
