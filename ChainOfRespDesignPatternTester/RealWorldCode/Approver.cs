using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespDesignPatternTester.RealWorldCode
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    abstract class Approver
    {
        protected Approver successor;

        public void setSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
