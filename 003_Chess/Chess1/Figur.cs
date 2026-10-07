using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    
    class Figur
    {
        public enum Color {WHITE, BLACK };
        Color color= Color.WHITE;
        int Zeile = 1;
        char Spalte = 'A';

        public Figur(Color color, int Zeile, char Spalte)
        {
            this.color = color;
            this.Zeile = Zeile;
            this.Spalte = Spalte;
        }

        public int GetZeile()
        {
            return Zeile;
        }

        public char GetSpalte()
        {
            return Spalte;
        }

        public virtual void MakeRandomMove()
        {
          Console.WriteLine("Nicht implementiert");
        }
    }
}
