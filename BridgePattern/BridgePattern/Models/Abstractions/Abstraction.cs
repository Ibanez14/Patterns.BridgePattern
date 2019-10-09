using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.ConceptualExample.Models
{
    public class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            _implementation = implementation;
        }


        public virtual string Operation()
            => $"Base operation with {_implementation.Foo()}";
        
    }

}
