using System;
using System.Reflection;

namespace ExceptionDriven.ConsoleApp
{
    public static class InvocationHandler
    {
        public static void HandleMethodInvocation(MethodInvocation invocation)
        {
            try
            {
                Type classType = null;
                if (invocation.Target == null)
                {
                    var className = invocation.ClassName;
                    classType = Type.GetType(className);
                }
                var classInstance = invocation.Target ?? Activator.CreateInstance(classType);
                classInstance.GetType().GetMethod(invocation.MethodName)
                    .Invoke(classInstance, invocation.Parameters);
            }
            catch (TargetInvocationException e)
            {
                if (e.InnerException is MethodInvocation nextMessage)
                {
                    HandleMethodInvocation(nextMessage);
                }
            }
        }
    }
}