using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'ConcreteHandler4' class
    /// </summary>
    class ProfessoreUniversitario : Esaminatore
    {
        public override void EffettuaEsameAlloStudente(Esame esame)
        {
            if (esame.TipoDiStudente <= TipoDiStudente.StudenteUniversitario)
            {
                Console.WriteLine("\n{0} sta effetuando l'esame a {1}", this.GetType().Name, esame.NomeDelloStudente);
            }
        }
    }
}
