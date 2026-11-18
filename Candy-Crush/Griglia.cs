using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy_Crush
{
    internal class Griglia
    {
        private int righe;
        private int colonne;
        private string coloreRandom;
        private Caramella[,] caramelle; //dichiarazione matrice di caramelle 
        private Random random = new Random();
        private String[] colori = { "rossa", "verde", "viola", "gialla", "blu", "arancione" }; //array che contiene i colori 
        public Griglia(int righe, int colonne)
        {
            caramelle = new Caramella[righe, colonne];   //crea una matrice che contiene tot righe e colonne
        }
        public void generaGriglia()
        {
            int numero = random.Next(0, colori.Length); //estrae un colore casuale dal primo all'ultimo del vettore
            coloreRandom = colori[numero]; //

            for(int i = righe)
        }
    }
}
