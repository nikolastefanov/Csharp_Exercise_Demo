

using Reflection_Demo_CSharp.Core.Contracts;

namespace Reflection_Demo_CSharp.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
         {
            this.commandInterpreter=commandInterpreter;
         }
    
        public void Run()
        {
            while(true)
            {
                string input = Console.ReadLine();

                //pas => CommangInput

                string result = this.commandInterpreter.Read(input);

                Console.WriteLine(result);
            }

        }
    }
}
