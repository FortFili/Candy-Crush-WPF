using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy_Crush
{
    internal class Caramella
    {
        private String coloreCaramella;
        private bool bloccata;
        private int punteggio;


        void setColoreCaramella(String colore)
        {
            this.coloreCaramella = colore;
        }

        void setBloccata(bool bloccata)
        {
            this.bloccata = bloccata;
        }

        void setPunteggio(int punteggio)
        {
            this.punteggio = punteggio;
        }

        bool getIsBloccata()
        {
            return bloccata;
        }
        int getPunteggio()
        {
            return punteggio;
        }
        String getColoreCaramella()
        {
            return this.coloreCaramella;
        }

    }
}
