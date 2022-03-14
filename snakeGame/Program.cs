using System;
using Raylib_cs;
namespace snakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
           MonoBehaviour mono = new MonoBehaviour();


            Raylib.InitWindow(mono.screenWidth, mono.ScreenHeight, "snake game");


            Snake snake = new Snake();
            Grid grid = new Grid();
            snake.SetLength(0);


            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.WHITE);

                snake.Draw();
                grid.Draw();

                Raylib.EndDrawing();
            }
        }
    }
}
