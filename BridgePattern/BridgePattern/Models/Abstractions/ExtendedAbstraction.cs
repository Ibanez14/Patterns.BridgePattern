namespace BridgePattern.ConceptualExample.Models
{
    // Можно расширить Абстракцию без изменения классов Реализации.
    public class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation)
            :base(implementation) { }

        public override string Operation() 
            => $"Extended Abstraction with {_implementation.Foo()}";
    }

}
