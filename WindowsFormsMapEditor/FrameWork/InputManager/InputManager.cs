using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using Framework;

namespace Framework
{
    public class InputManager : Singleton<InputManager>
    {
        public Point GetStreamPoint(StreamWriter streamWriter)
        {
            Point point = new Point(0, 0);

            return point;
        }
    }
}