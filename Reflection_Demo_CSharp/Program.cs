

namespace Reflection_Demo_CSharp
{
    using System;
    

    internal class Program
    {
        public static void Main(string[] args)
        {

             ICommandInterpreter command= new CommandInterpeter();

             IEngine engine=new Engine();

             engine.Run();

        }
    }
}