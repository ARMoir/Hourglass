using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Hourglass.Program;

namespace Hourglass
{
    class Key
    {
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

                    case ConsoleKey.R:
                        if (Display.Color != ConsoleColor.Red)
                        {
                            Display.Color = ConsoleColor.Red;
                        }
                        else
                        {
                            Display.Color = ConsoleColor.White;
                        }
                        break;

                    case ConsoleKey.G:
                        if (Display.Color != ConsoleColor.Green)
                        {
                            Display.Color = ConsoleColor.Green;
                        }
                        else
                        {
                            Display.Color = ConsoleColor.White;
                        }
                        break;

                    case ConsoleKey.B:
                        if (Display.Color != ConsoleColor.Blue)
                        {
                            Display.Color = ConsoleColor.Blue;
                        }
                        else
                        {
                            Display.Color = ConsoleColor.White;
                        }
                        break;

                    case ConsoleKey.C:
                        if (Display.Color != ConsoleColor.Cyan)
                        {
                            Display.Color = ConsoleColor.Cyan;
                        }
                        else
                        {
                            Display.Color = ConsoleColor.White;
                        }
                        break;

                    case ConsoleKey.M:
                        if (Display.Color != ConsoleColor.Magenta)
                        {
                            Display.Color = ConsoleColor.Magenta;
                        }
                        else
                        {
                            Display.Color = ConsoleColor.White;
                        }
                        break;

                    case ConsoleKey.Y:
                        if (Display.Color != ConsoleColor.Yellow)
                        {
                            Display.Color = ConsoleColor.Yellow;
                        }
                        else
                        {
                            Display.Color = ConsoleColor.White;
                        }
                        break;
                }

            } while (true);
        }
    }
}
