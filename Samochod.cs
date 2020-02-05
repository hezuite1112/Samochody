using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Samochody
{
    class Samochod
  {
        public int pas;
        public int x;
        public int szerokosc;
        public int wysokosc;
    
        public Samochod(int szerokosc_okna, int wysokosc_okna)
         {
        wysokosc = wysokosc_okna / 10;
        szerokosc = szerokosc_okna / 10;
        Random r = new Random();
        pas = r.Next(0, 4);
        int szerokosc_pasa = szerokosc_okna / 4;
        x =(pas * (szerokosc_pasa)) + (szerokosc_pasa / 2) - (szerokosc / 2);
         }
        public void rysuj(Graphics g, Brush b)
         {
        g.FillRectangle(b, x, wysokosc * 9, szerokosc, wysokosc);
         }
         public void przesun(string strona)
         {
        if (strona =="prawa")
        {
            if (pas< 3)
            {
                pas = pas + 1;
            }
        }
        else
        {
            if (pas >0)
            {
                pas = pas - 1;

            }
        }
        int szerokosc_pasa = (szerokosc * 10) / 4;
        x = (pas * (szerokosc_pasa)) + (szerokosc_pasa / 2) - (szerokosc / 2);
         }
   }
}
