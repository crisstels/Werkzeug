using System;
using System.Collections.Generic;
using System.Text;

namespace Werkzeug
{
    class Bohrmaschine
    {
        #region Attribute
        private int _groesse;
        private string _farbe;
        private Bohrer _bohrer1;
        #endregion

        #region Konstruktor
        public Bohrmaschine()
        {
            this.Groesse = Groesse;
            this.Farbe = Farbe;
            this.Bohrer1 = Bohrer1;
        }
        public Bohrmaschine(int groesse, string farbe, Bohrer bohrer)
        {
            Groesse = groesse;
            Farbe = farbe;
            Bohrer1 = bohrer;
        }
        #endregion

        #region Accessors/ Modifiers
        public int Groesse { get => _groesse; set => _groesse = value; }
        public string Farbe { get => _farbe; set => _farbe = value; }
        public Bohrer Bohrer1 { get => _bohrer1; set => _bohrer1 = value; }

        #region Worker
        public void BohrerEinsetzen()
        {

        }

        public Bohrer BohrerAusgeben()
        {
            Bohrer bohrer = this.Bohrer1;
            this.Bohrer1 = null;
            return bohrer;
        }
        #endregion
    }
}
