using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilties.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAtributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>(true).ToList();
            var methodAttributes = type?.GetMethod(method.Name)?.GetCustomAttributes<MethodInterceptionBaseAttribute>(true);

            classAtributes.AddRange(methodAttributes);

            return classAtributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}
