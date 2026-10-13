using System;
using System.Runtime.CompilerServices;

namespace Zork
{
    enum Commands
    {
        QUIT,
        LOOK,
        NORTH,
        SOUTH,
        EAST,
        WEST,
        UNKNOWN
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            string inputString = Console.ReadLine();
            //inputString = inputString.ToUpper();
            Commands command = ToCommand(inputString.Trim().ToUpper());
            Console.WriteLine(command);
            //if (inputString == "QUIT")
            //{
            //    Console.WriteLine("Thank you for playing.");
            //}
            //else if (inputString == "LOOK")
            //{
            //    Console.WriteLine("This is an open field west of a white house, with a boarded front door.\nA rubber mat saying 'Welcome to Zork!' lies by the door.");
            //}
            //else
            //{
            //    Console.WriteLine("Unrecognized command.");
            //}

        }
        private static Commands ToCommand(string commandString)
        {
            return Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
            //Commands command;

            //if (commandString == "QUIT")
            //{
            //    command = Commands.QUIT;
            //}
            //else if (commandString == "LOOK")
            //{
            //    command = Commands.LOOK;
            //}
            //else if (commandString == "NORTH")
            //{
            //    command = Commands.NORTH;
            //}
            //else if (commandString == "SOUTH")
            //{
            //    command = Commands.SOUTH;
            //}
            //else if (commandString == "EAST")
            //{
            //    command = Commands.EAST;
            //}
            //else if (commandString == "WEST")
            //{
            //    command = Commands.WEST;
            //}
            //else
            //{
            //    command = Commands.UNKNOWN;
            //}

            //return command;
        }

    }
}