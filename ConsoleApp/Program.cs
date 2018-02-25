using System.Linq;
using System.Reflection;

namespace ExceptionDriven.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new MethodInvocation("ExceptionDriven.ConsoleApp.Worker", "Greet");
            }
            catch (MethodInvocation invocation)
            {
                InvocationHandler.HandleMethodInvocation(invocation);
            }
        }
    }
}
