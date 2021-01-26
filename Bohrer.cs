using System;
using System.Collections.Generic;
using System.Text;

namespace Werkzeug
{
    class Bohrer
    {
        private double _groesse;

        public Bohrer()
        {
            this.Groesse = _groesse;
        }
        public Bohrer(double groesse)
        {
            _groesse = groesse;
        }

        public double Groesse { get => _groesse; set => _groesse = value; }




    }
}
