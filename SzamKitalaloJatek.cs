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

            Console.WriteLine("VersenyIndul");
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
                
                int tipp = versenyzok[i].KovetkezoTipp();               
                Console.WriteLine($"{versenyzok[i]} tippje: {tipp}");

                if (cel == tipp)
                {
                    vanNyertes = true;
                    versenyzok[i].Nyert();
                }
                else
                {
                    //mod1
                    if (versenyzok[i] is IOkosTippelo)
                    {
                        IOkosTippelo aktualisJatekos = versenyzok[i] as IOkosTippelo;
                        if (tipp < cel)
                        {
                            aktualisJatekos.Kisebb();
                        }
                        else
                        {
                            aktualisJatekos.Nagyobb();
                        }
                    }

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

        public void Statisztika(int korokSzama)
        {
            for (int i = 0; i < korokSzama; i++)
            {
                Jatek();
            }

            for (int i = 0; i < versenyzok.Length; i++) //versenyzoket nezi
            {
                if (versenyzok[i] is IStatisztikatSzolgaltat)
                {
                    GepiJatekos aktualisJatekos = versenyzok[i] as GepiJatekos;
                    Console.WriteLine($"{i+1}. játékos ({versenyzok[i]}), NY: {aktualisJatekos.HanyszorNyert}\t V: {aktualisJatekos.HanyszorVesztett}");
                }
            }
        }
    }
}
