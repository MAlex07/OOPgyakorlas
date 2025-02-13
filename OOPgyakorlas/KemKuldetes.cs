using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyakorlas
{
    internal class KemKuldetes
    {
        private string kodenev;
        private string orszag;
        private int veszelySzint;
        private int sikerEsely;

        public string Kodenev { get => kodenev; set => kodenev = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public int VeszelySzint { get => veszelySzint; set => veszelySzint = value; }
        public int SikerEsely { get => sikerEsely; set => sikerEsely = value; }

        public KemKuldetes(string kodenev, string orszag, int veszelySzint, int skerEsely)
        {
            this.kodenev = kodenev;
            this.orszag = orszag;
            this.veszelySzint = veszelySzint;
            this.sikerEsely = sikerEsely;
        }
        public KemKuldetes(string kodenev, string orszag)
        {
            this.kodenev = kodenev;
            this.orszag = orszag;
            this.veszelySzint = 5;
            this.sikerEsely = 50;
        }

        public void KuldetesInditasa()
        {
            Console.WriteLine("A küldetés elkezdőtött!");
        }

        public void VeszelySzintNovelese(int mennyiseg)
        {
            veszelySzint += mennyiseg;
        }

        public void SikerEselyNovelese(int szazalek)
        {
            sikerEsely += szazalek;
        }

        public override string? ToString()
        {
            return $"A küldetés kódneve: {kodenev} - helyszíne: {orszag} / Veszélyessége: {veszelySzint} - Siker esélye: {sikerEsely}%";
        }
    }
}
