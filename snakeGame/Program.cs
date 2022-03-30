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
            Food food = new Food();
            snake.SetFood(food);
            food.SetSnake(snake);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.WHITE);
                snake.CollissionCheck(food);
                food.CollissionCheck(snake);

                snake.Draw();
                grid.Draw();
                food.Draw();
               

                Raylib.EndDrawing();
            }
        }
    }
}
