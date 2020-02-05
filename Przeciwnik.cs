using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Samochody
{
    class Przeciwnik
    {
        public int pas;
        public int x;
        public int y;
        public int szerokosc;
        public int wysokosc;

    public Przeciwnik(int szerokosc_okna, int wysokosc_okna, int y)
    {
        wysokosc = wysokosc_okna / 10;
        szerokosc = szerokosc_okna / 10;
        this.y = y;
        Random r = new Random();
        pas = r.Next(0, 4);
        int szerokosc_pasa = szerokosc_okna / 4;
        x = (szerokosc_pasa * (szerokosc_pasa)) + (szerokosc_pasa / 2) - (szerokosc / 2);
    }
    public void rysuj(Graphics g, Brush b)
    {
        g.FillRectangle(b, x, y, szerokosc, wysokosc);
    }
    public void przesun()
    {
        y = y + 10;
        if (y>wysokosc *10)
        {
            y = 0;
            Random r = new Random();
            pas = r.Next(0, 4);
            int szerokosc_pasa = (szerokosc * 10) / 4;
            x = (pas * (szerokosc_pasa)) + (szerokosc_pasa / 2) - (szerokosc / 2);
        }
    }
    public bool kolizja (int x_auto)
    {
        if (x_auto == x)
        {
            if (y+ wysokosc> wysokosc *9)
            {
                return true;
            }   
        }
            return false;
        }
        

    }

}
