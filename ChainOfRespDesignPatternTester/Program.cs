using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Structural = ChainOfRespDesignPatternTester.StructuralCode;
using Real = ChainOfRespDesignPatternTester.RealWorldCode;

namespace ChainOfRespDesignPatternTester
{
    // Chain of Responsibility

    // Definition
    // Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.
    // Chain the receiving objects and pass the request along the chain until an object handles it. 

    // Participants
    // The classes and objects participating in this pattern are:
    //  - Handler (Approver)
    //      --> defines an interface for handling the requests
    //      --> (optional) implements the successor link
    //  - ConcreteHandler (Director, VicePresident, President)
    //      --> handles requests it is responsible for
    //      --> can access its successor
    //      --> if the ConcreteHandler can handle the request, it does so; otherwise it forwards the request to its successor
    //  - Client (ChainApp)
    //      --> initiates the request to a ConcreteHandler object on the chain

    class Program
    {
        static void Main()
        {
            #region Structural code in C#
            // Structural code in C#
            // This structural code demonstrates the Chain of Responsibility pattern in which several linked objects (the Chain)
            // are offered the opportunity to respond to a request or hand it off to the object next in line.

            // Setup chain of responsibility
            Structural.Handler h1 = new Structural.ConcreteHandler1();
            Structural.Handler h2 = new Structural.ConcreteHandler2();
            Structural.Handler h3 = new Structural.ConcreteHandler3();

            h1.setSuccessor(h2);
            h2.setSuccessor(h3);

            // Generate requests
            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach(int request in requests){
                h1.HandleRequest(request);
            }

            // Wait for user
            Console.ReadKey();
            #endregion

            #region Real-world code in C#
            // Real-world code in C#
            // This real-world code demonstrates the Chain of Responsibility pattern in which several linked managers
            // and executives can respond to a purchase request or hand it off to a superior.
            // Each position has can have its own set of rules which orders they can approve. 

            // Setup chain of responsibility
            Real.Approver larry = new Real.Director();
            Real.Approver sam = new Real.VicePresident();
            Real.Approver tammy = new Real.President();

            larry.setSuccessor(sam);
            sam.setSuccessor(tammy);

            // Generate and process purchase requests
            Real.Purchase p = new Real.Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(p);

            p = new Real.Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Real.Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);

            // Wait for user
            Console.ReadKey();
            #endregion
        }
    }
}
