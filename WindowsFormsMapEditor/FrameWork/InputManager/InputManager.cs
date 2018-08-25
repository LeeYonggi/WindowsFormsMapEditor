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
        public Point GetStreamPoint(StreamReader streamReader, ref string tileName)
        {
            Point point = new Point(0, 0);
            int x = 0;
            int y = 0;

            string line = streamReader.ReadLine();
            for(int i = 0; i < line.Length; i++)
            {
                if(string.Compare(line[i].ToString(), "X") == 0)
                {
                    string tempPoint = "";
                    for(int j = i + 2; ; j++)
                    {
                        if (string.Compare(line[j].ToString(), ",") == 0)
                            break;
                        else
                            tempPoint = tempPoint + line[j];
                    }
                    Int32.TryParse(tempPoint, out x);
                    point.X = x;
                }
                else if (string.Compare(line[i].ToString(), "Y") == 0)
                {
                    string tempPoint = "";
                    for (int j = i + 2; ; j++)
                    {
                        if (string.Compare(line[j].ToString(), "}") == 0)
                            break;
                        else
                            tempPoint = tempPoint + line[j];
                    }
                    Int32.TryParse(tempPoint, out y);
                    point.Y = y;
                }
                if (string.Compare(line[i].ToString(), "/") == 0) break;
            }
            return point;
        }
    }
}