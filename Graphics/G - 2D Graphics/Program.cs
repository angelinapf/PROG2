using Raylib_cs;
using System.Numerics;

namespace G___2D_Graphics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Raylib.InitWindow(512, 480, "Window");
        Raylib.SetTargetFPS(60);



        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            Raylib.EndDrawing();
        }
    }
}
