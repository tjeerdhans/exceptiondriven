# Exception Driven Development

This is Hello World, run by exception. 

In other words, it throws exceptions around in order to invoke methods. I know, it's exceptionally crazy.

## How to


To invoke a method, throw a `MethodInvocation`, containing the target class, method and (optional) parameters, e.g.:

`throw new MethodInvocation("ExceptionDriven.ConsoleApp.Worker", "Greet");`

If you'd like to use an instance as the target class, then supply that one:

`throw new MethodInvocation(this, "SayHello", name);`

Don't expect the called method to return to the location you threw it from. **That's not how Exception Driven Development rolls**. 
