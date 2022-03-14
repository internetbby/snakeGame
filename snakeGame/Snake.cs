using System;
using Raylib_cs;
using System.Numerics;
using System.Timers;

namespace snakeGame
{
    public class Snake : Timer
    {
        private int snakeLength = 200;
        private Vector2 position = new Vector2();

        private int speed;

        private string movementCall = "UP";
        private Vector2 size = new Vector2();



        private Color snakeColour = Color.BLUE;

        public Snake()
        {
            position.X = screenWidth / 2;
            position.Y = ScreenHeight / 2;

            size.Y = squareSize;
            size.X = size.Y;

        }


        public override void OnTimedEvent(object source, ElapsedEventArgs e) //ONTIMEDEVENT SNAKE DO THIS
        {
            if(movementCall == "LEFT"){
                position.X =  position.X - squareSize; 
            }
            if(movementCall == "RIGHT"){
                position.X =  position.X + squareSize; 
            }
            if(movementCall == "UP"){
                position.Y =  position.Y - squareSize; 
            }
            if(movementCall == "DOWN"){
                position.Y =  position.Y + squareSize; 
            }

        }


        public void movementControls()  //CHANGE THE INTERNAL MOVEMENT OF SNAKE
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_A))
            {
                movementCall = "LEFT";
            }
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_D))
            {
                movementCall = "RIGHT";
            }
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_W))
            {
                movementCall = "UP";
            }
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_S))
            {
                movementCall = "DOWN";
            }
            

        }

        public void SetLength(int length)
        {
            snakeLength = length;
        }


        public void Draw()
        {
            movementControls();
            Raylib.DrawRectangleV(position, size, snakeColour);
        }
    }

}