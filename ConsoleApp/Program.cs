namespace ExceptionDriven.ConsoleApp
{
    class Program
    {
        static void Main()
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
