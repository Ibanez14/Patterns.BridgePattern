using BridgePattern.ConceptualExample.Models;
using BridgePattern.ConceptualExample.Models.Implementations;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Abstraction abstraction = new Abstraction(new ConcreteImplementation1());
            client.Code(abstraction);

            abstraction = new ExtendedAbstraction(new ConcreteImplementation2());
            client.Code(abstraction);

            abstraction = new ExtendedAbstraction(new ConcreteImplementation1());
            client.Code(abstraction);

            Console.Read();
        }
    }
}
