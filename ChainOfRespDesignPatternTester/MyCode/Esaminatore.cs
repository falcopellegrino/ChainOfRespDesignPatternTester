using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    abstract class Esaminatore
    {
        protected Esaminatore esaminatoreSuperiore;

        public void setEsaminatoreSuperiore(Esaminatore esaminatoreSuperiore)
        {
            this.esaminatoreSuperiore = esaminatoreSuperiore;
        }

        public abstract void EffettuaEsameAlloStudente(Esame esame);
    }
}
