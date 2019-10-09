using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.ConceptualExample.Models.Implementations
{
    public class ConcreteImplementation1 : IImplementation
    {
        public string Foo()
            => "Concrete ONE!";
    }

    public class ConcreteImplementation2 : IImplementation
    {
        public string Foo()
            => "Concrete TWO!";
    }
}
