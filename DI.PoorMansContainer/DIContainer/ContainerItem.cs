using System;

namespace DI.PoorMansContainer.DIContainer
{
    class ContainerItem
    {
        public Type ConcreteType { get; set; }

        public Type AbstractionType { get; set; }
    }
}
