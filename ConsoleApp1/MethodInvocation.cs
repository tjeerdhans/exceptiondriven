using System;

namespace ExceptionDriven.ConsoleApp
{
    public class MethodInvocation : Exception
    {
        public object Target { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }
        public object[] Parameters { get; set; }

        public MethodInvocation(object target, string methodName, params object[] parameters)
        {
            Target = target;
            MethodName = methodName;
            Parameters = parameters;
        }
        public MethodInvocation(string className, string methodName, params object[] parameters)
        {
            ClassName = className;
            MethodName = methodName;
            Parameters = parameters;
        }
    }
}