using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayÜbungen
{
    public class Auto
    {
        // Felder (Fields)
        int raeder;
        double hoechstgeschwindigkeit;
        //double aktuelleGeschwindigkeit;


        // Eigenschaften (Properties)
        public int Raeder
        {
            get { return raeder; }
        }

        //public double AktuelleGeschwindigkeit
        //{
        //    set { aktuelleGeschwindigkeit = value; }
        //    get { return aktuelleGeschwindigkeit; }
        //}

        public double AktuelleGeschwindigkeit
        {
            set;
            get;
        }

        // Konstruktor
        public Auto()
        {
            raeder = 4;
            hoechstgeschwindigkeit = 100;
            AktuelleGeschwindigkeit = 0;
        }


        // Methoden (Methods)
        //public void SetReader(int raeder)
        //{
        //    this.raeder = raeder;
        //}

        //public int GetReader()
        //{
        //    return this.raeder;
        //}

        public void Beschleunigen(double wert)
        {
            AktuelleGeschwindigkeit += wert;
            Console.WriteLine($"Auto beschleunigt um {wert} Km/h. Auto fährt jetzt {AktuelleGeschwindigkeit} Km/h");
            //aktuelleGeschwindigkeit = aktuelleGeschwindigkeit + wert;
        }
    }
}
