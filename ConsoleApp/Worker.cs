using System;

namespace ExceptionDriven.ConsoleApp
{
    public class Worker
    {
        public void Greet()
        {
            Console.WriteLine("Name?");
            var name = Console.ReadLine();
            throw new MethodInvocation(this, "SayHello", name);
        }

        public void SayHello(string text)
        {
            Console.WriteLine($"Hello World, {text}!");
            Console.ReadKey();
        }
    }
}