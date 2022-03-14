using System;
using System.Timers;
using System.Numerics;
using Raylib_cs;

namespace snakeGame
{
    public class Food : Timer
    {
        private Random generator = new Random();
        private int r;

        private Vector2 size = new Vector2();

        private Vector2 position = new Vector2();


        public Food()
        {
            size.Y = squareSize;
            size.X = squareSize;

            position.X = 30 / squareSize;
            position.Y = 20 / squareSize;
        }

        public override void OnTimedEvent(object source, ElapsedEventArgs e) //ONTIMEDEVENT SNAKE DO THIS
        {
            System.Console.WriteLine("time");
        }


        public void Draw()
        {
            Raylib.DrawRectangleV(position, size, Color.BLACK);
        }
    }
}