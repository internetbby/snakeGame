using System;
using Raylib_cs;
namespace snakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            MonoBehaviour mono = new MonoBehaviour();


            Raylib.InitWindow(mono.GetScreenWidth(), mono.GetScreenHeight(), "snake game");


            Snake snake = new Snake();
            Grid grid = new Grid();
            Food food = new Food();
            snake.SetFood(food);
            food.SetSnake(snake);

            while (!Raylib.WindowShouldClose())
            {
                if (snake.isOutsideOfLvl() == false)
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
                else if (snake.isOutsideOfLvl() == true)
                {
                    Raylib.BeginDrawing();

                    Raylib.ClearBackground(Color.LIGHTGRAY);
                    Raylib.DrawText("GAME LOST", Raylib.GetScreenWidth()/4, Raylib.GetScreenHeight()/3          , 100, Color.BLACK);

                    Raylib.EndDrawing();
                }
            }

        }
    }
}

