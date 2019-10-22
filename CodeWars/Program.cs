using CodeWars.Commands;
using System;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a command.");
            var command = Console.ReadLine().ToUpper();

            var result = CommandSelector(command);

            Console.WriteLine(result);
            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }

        private static string CommandSelector(string command)
        {
            switch(command)
            {
                case "GETVOWELCOUNT":

                    var stringHandler = new StringHandler();
                    Console.WriteLine("Please type a string.");
                    var str = Console.ReadLine();

                    return stringHandler.GetVowelCount(str).ToString();

                default:

                    return "Command not found.";
            }
        }
    }
}
