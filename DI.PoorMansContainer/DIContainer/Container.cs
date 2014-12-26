using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.PoorMansContainer.DIContainer
{
    class Container
    {
        private readonly List<ContainerItem> _registrations;
 
        public Container()
        {
            _registrations = new List<ContainerItem>();
        }

        public void Register<T, T1>()
            where T1 : class, new()
        {
            var abstractionType = typeof (T);
            var concreteType = typeof (T1);

            Register(abstractionType, concreteType);
        }

        public void Register(Type abstractionType, Type concreteType)
        {
            if (!abstractionType.IsInterface)
            {
                throw new ApplicationException("First generic argument must be of type interface");
            }

            _registrations.Add(new ContainerItem { AbstractionType = abstractionType, ConcreteType = concreteType });
        }

        public T Resolve<T>() where T : class
        {
            var type = typeof (T);

            return (T) GetConcreteType(type);
        }

        private object GetConcreteType(Type typeToResolve)
        {
            var containerItem = _registrations.FirstOrDefault(item => item.AbstractionType == typeToResolve);

            return null != containerItem ? GetTypeInstance(containerItem.ConcreteType) : GetTypeInstance(typeToResolve);
        }

        private object GetTypeInstance(Type typeToResolve)
        {
            object instance = null;

            var constructors = typeToResolve.GetConstructors();

            if (constructors.Length > 0)
            {
                var constructor = constructors[0];
                
                var constructorArguments = new List<object>();
                var parameters = constructor.GetParameters();

                foreach (var parameterInfo in parameters)
                {
                    object parameterInstance = null;

                    if (parameterInfo.ParameterType.IsInterface)
                    {
                        // Recursion happen here
                        parameterInstance = GetConcreteType(parameterInfo.ParameterType);
                    }

                    constructorArguments.Add(parameterInstance);
                }

                instance = Activator.CreateInstance(typeToResolve, constructorArguments.ToArray());
            }

            return instance;
        }
    }
}
