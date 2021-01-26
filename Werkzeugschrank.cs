using System;
using System.Collections.Generic;
using System.Text;

namespace Werkzeug
{
    class Werkzeugschrank
    {
        private Bohrer[] _bohrers = new Bohrer[9];

        public Bohrer[] Bohrers { get => _bohrers; set => _bohrers = value; }

        public Werkzeugschrank()
        {
            for(int i =0; i<=9; i++)
            {
                this.Bohrers[i] = new Bohrer();
            }
        }

        public Werkzeugschrank(Bohrer[] bohrers)
        {
            Bohrers = bohrers;
        }

        public void SchrankOeffnen()
        {
            Console.WriteLine("Schrank wird geöffnet");
        }

        public void SchrankSchließen()
        {
            Console.WriteLine("Schrank wird geschlossen");
        }

        public Bohrer BohrmaschineAuswaehlen(double groesse)
        {
            Bohrer temp = new Bohrer();
            SchrankOeffnen();
            for(int i=0; i<Bohrers.Length; i++)
            {
                if(Bohrers[i].Groesse == groesse)
                {
                   temp =  Bohrers[i];
                }
            }
            SchrankSchließen();

            return null;
        }

        public void BohrmaschineZurückLegen(Bohrer bohrer)
        {
            SchrankOeffnen();
            for (int i = 0; i < Bohrers.Length; i++)
            {
                if (Bohrers[i].Groesse == bohrer.Groesse)
                {
                    Bohrers[i] = bohrer;
                }
            }
            SchrankSchließen();
        }
    }
}
