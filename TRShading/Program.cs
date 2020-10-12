using OpenTK.Windowing.Desktop;
using System;

namespace TRShading
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWindowSettings gws = new GameWindowSettings();
            NativeWindowSettings nws = new NativeWindowSettings();
            nws.Size = new OpenTK.Mathematics.Vector2i(1000, 1000);
            Game gameWindows = new Game(gws, nws);

            gameWindows.Run();
        }
    }
}
