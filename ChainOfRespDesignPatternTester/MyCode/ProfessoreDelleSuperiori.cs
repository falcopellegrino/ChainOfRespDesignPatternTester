using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'ConcreteHandler2' class
    /// </summary>
    class ProfessoreDelleSuperiori : Esaminatore
    {
        public override void EffettuaEsameAlloStudente(Esame esame)
        {
            if (esame.TipoDiStudente <= TipoDiStudente.StudenteDelleScuoleMedieSuperiori)
            {
                Console.WriteLine("\n{0} sta effettuando l'esame a {1}", this.GetType().Name, esame.NomeDelloStudente);
            }
            else if (esaminatoreSuperiore != null)
            {
                Console.WriteLine("\nQuesto esame non è per {0}. Sono solo un {1}. Vediamo se se ne può occupare {2}."
                       , TipoDiStudente.StudenteDelleScuoleMedieSuperiori.ToString()
                       , this.GetType().Name
                       , this.esaminatoreSuperiore.GetType().Name
                );
                esaminatoreSuperiore.EffettuaEsameAlloStudente(esame);
            }
        }
    }
}
