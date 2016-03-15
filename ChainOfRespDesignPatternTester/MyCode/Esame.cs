using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespDesignPatternTester.MyCode
{
    /// <summary>
    /// Class holding request details
    /// </summary>
    class Esame
    {
        private TipoDiStudente _tipoDiStudente;
        private string _nomeDelloStudente;

        // Constructor
        public Esame(TipoDiStudente tipoDiStudente, string nomeDelloStudente)
        {
            this._tipoDiStudente = tipoDiStudente;
            this._nomeDelloStudente = nomeDelloStudente;
        }

        public TipoDiStudente TipoDiStudente
        {
            get { return _tipoDiStudente; }
            set { _tipoDiStudente = value; }
        }
        public string NomeDelloStudente
        {
            get { return _nomeDelloStudente; }
            set { _nomeDelloStudente = value; }
        }
    }
}
