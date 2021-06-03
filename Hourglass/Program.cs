using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass
{
    class Program
    {
        public static class Display
        {
            public static List<string> FrameChar { get; set; } = new List<string>();
            public static StringBuilder FrameString { get; set; } = new StringBuilder();
            public static StringBuilder DisplayFrame { get; set; } = new StringBuilder();
            public static Random Random { get; set; } = new Random();
            public static ConsoleColor Color { get; set; } = ConsoleColor.Yellow;
            public static int Offset { get; set; } = 0;
            public static int Width { get; set; } = 0;
        }

        static void Main(string[] args)
        {
            //Pull in the Board
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.SetWindowSize(60, 40);
            }

            //Start Thred to Read Keypress
            Task.Factory.StartNew(() => Key.Press());

            Console.CursorVisible = false;
            Console.Clear();
            Frame.SetFrame();
            Display.FrameChar.AddRange(Display.FrameString.ToString().Select(Chars => Chars.ToString()));

            //Set the Values for Movement Calculations
            string[] Lines = Display.FrameString.ToString().Split((Char)10);
            Display.Width = Lines[0].Length + 1;
            int Time = 2700;
            Time = (Time * 1000) / (Display.FrameString.ToString().Split('*').Length -1);

            do
            {
                Console.ForegroundColor = Display.Color;

                foreach (int i in Enumerable.Range(0, Display.FrameChar.Count).OrderBy(x => Display.Random.Next()))
                    {

                    int Check = Display.Random.Next(0, 2);
                    if (Check == 0){Check = -1;}else{Check = 1;}

                    if (((i + Display.Width + Display.Offset - 1) > 0) && ((i + Display.Width + Display.Offset + 1) < Display.FrameChar.Count))
                    {
                        if (Display.FrameChar[i] == "*")
                        {
                            Display.FrameChar[i] = " ";

                            if (Display.FrameChar[i + (Display.Width + Display.Offset)] == " ")
                            {
                                Display.FrameChar[i + (Display.Width + Display.Offset)] = "*";
                            }
                            else if (Display.FrameChar[i + (Display.Width + Display.Offset) + Check] == " ")
                            {
                                Display.FrameChar[i + (Display.Width + Display.Offset) + Check] = "*";
                            }
                            else if (Display.FrameChar[i + (Display.Width + Display.Offset) + (Check * -1)] == " ")
                            {
                                Display.FrameChar[i + (Display.Width + Display.Offset) + (Check * -1)] = "*";
                            }
                            else
                            {
                                Display.FrameChar[i] = "*";
                            }
                        }
                    }

                }

                //Update Display
                Display.DisplayFrame.Clear();
                Display.FrameChar.ForEach(Item => Display.DisplayFrame.Append(Item));
                //Display.DisplayFrame.Append(System.Environment.NewLine);

                //Write Display to Console
                Console.SetCursorPosition(0, 0);
                Console.Write(Display.DisplayFrame);
                System.Threading.Thread.Sleep(Time);

            } while (true);
        }
    }
}
