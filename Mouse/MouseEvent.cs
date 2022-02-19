using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace AFK.Mouse
{
    public partial class MouseOperations
    {

        [Flags]
        public enum MouseEventFlags
        {
            LeftDown = 0x00000002,
            LeftUp = 0x00000004,
            MiddleDown = 0x00000020,
            MiddleUp = 0x00000040,
            Move = 0x00000001,
            Absolute = 0x00008000,
            RightDown = 0x00000008,
            RightUp = 0x00000010
        }

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out MousePoint lpMousePoint);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);




        public void ClickMouseLeftButton(Point globalLocation)
        {
            Point currLocation = Cursor.Position;

            Cursor.Position = globalLocation;

            mouse_event(Convert.ToInt32(MouseEventFlags.LeftDown) | Convert.ToInt32(MouseEventFlags.LeftUp),
                globalLocation.X, globalLocation.Y, 0, 0);

            Cursor.Position = currLocation;
        }

        public void ClickControl(Control target, Point localLocation)
        {
            ClickMouseLeftButton(target.PointToScreen(localLocation));
        }

        public void ClickControl(Control target)
        {
            ClickControl(target, new Point(target.Width / 2, target.Height / 2));
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MousePoint
        {
            public int X;
            public int Y;

            public MousePoint(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}

