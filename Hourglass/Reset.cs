using Hourglass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Hourglass.Program;

namespace Hourglass
{
    class Reset
    {
        public static void Now()
        {
            Display.FrameChar.Clear();
            Display.FrameString.Clear();
            Display.DisplayFrame.Clear();          
            Frame.SetFrame();
            Display.FrameChar.AddRange(Display.FrameString.ToString().Select(Chars => Chars.ToString()));
        }
    }
}
