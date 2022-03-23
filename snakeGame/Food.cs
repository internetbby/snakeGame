using System;
using System.Timers;
using System.Numerics;
using Raylib_cs;

namespace snakeGame
{
    public class Food : InteractableObject
    {
        private Random generator = new Random();
        private int r;

        private Snake snake;
        public Food()
        {
            rectangle.width = squareSize;
            rectangle.height = squareSize;


            r = generator.Next(20);

            rectangle.y = r / squareSize;



            r = generator.Next(30);
            rectangle.x = r / squareSize;
        }

        public void SetSnake(Snake s)
        {
            snake = s;
        }

        public override void OnTimedEvent(object source, ElapsedEventArgs e) //ONTIMEDEVENT SNAKE DO THIS
        {
            if (this.CollissionCheck(snake) == true)
            {
                r = generator.Next(20);
                rectangle.y = r * squareSize;

                r = generator.Next(30);
                rectangle.x = r * squareSize;

            }





        }


        public void Draw()
        {
            Raylib.DrawRectangleRec(rectangle, Color.BLACK);
        }
    }
}