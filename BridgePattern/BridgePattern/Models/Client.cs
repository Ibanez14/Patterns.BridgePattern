using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.ConceptualExample.Models
{
    public class Client
    {
        public void Code(Abstraction abstraction) =>

            Console.WriteLine(abstraction.Operation());
    }
}
