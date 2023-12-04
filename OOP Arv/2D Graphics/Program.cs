using Raylib_cs;

namespace _2D_Graphics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Raylib.InitWindow(800, 800, "Raylib");
        Raylib.SetTargetFPS(60);
        
        // Color creation
        Color Pink = new Color(223, 131, 124, 255);
        
        
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);


            Raylib.EndDrawing();
        }
    }
}
