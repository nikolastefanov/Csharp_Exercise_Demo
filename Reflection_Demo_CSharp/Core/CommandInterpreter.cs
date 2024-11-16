

namespace Reflection_Demo_CSharp.Core
{
    using Contracts; 

    public class CommandInterpreter:ICommandInterpreter
    {
        public string Read(string args)
        {

        //Hello Gosho

        string[] inputArgs = args.Split(" ",StringSplitOptions.RemoveEmptyEntries);

            string command = inputArgs[0]; //Hello



            return null;
        }
    }
}
