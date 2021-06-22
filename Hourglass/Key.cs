using System;
using System.Collections.Generic;

using static Hourglass.Program;

namespace Hourglass
{
    class Key
    {
        /// <summary>
        /// Keys that change the color when pressed
        /// </summary>
        private static Dictionary<ConsoleKey, ConsoleColor> colorKeys = new()
        {
            { ConsoleKey.R, ConsoleColor.Red },
            { ConsoleKey.G, ConsoleColor.Green },
            { ConsoleKey.B, ConsoleColor.Blue },
            { ConsoleKey.C, ConsoleColor.Cyan },
            { ConsoleKey.M, ConsoleColor.Magenta },
            { ConsoleKey.Y, ConsoleColor.Yellow }
        };

        public static void Press()
        {
            do
            {
                var Key = Console.ReadKey().Key;

                switch (Key)
                {

                    case ConsoleKey.Delete:

                        Reset.Now();
                        break;

                    case ConsoleKey.Q:
                        Environment.Exit(-1);
                        break;

                    default:
                        if (colorKeys.ContainsKey(Key))
                        {
                            ConsoleColor color = colorKeys[Key];
                            Display.Color = Display.Color == color ? ConsoleColor.White : color;
                        }
                        break;
                }

            } while (true);
        }
    }
}
