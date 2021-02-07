using System.Runtime.InteropServices;

namespace ImGuiNET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector2i
    {
        public Vector2i(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X;
        public int Y;
    }
}