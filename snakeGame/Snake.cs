using System;
using Raylib_cs;
using System.Numerics;
using System.Timers;
using System.Collections.Generic;


namespace snakeGame
{
    public class Snake : InteractableObject
    {

        private static string movementCall = "UP";
        private Color snakeColour = Color.BLUE;

        private Food fruit;
        private List<Rectangle> snakeLength = new List<Rectangle>();

        private bool isOutside = false; 



        public Snake()
        {

            snakeLength.Add(rectangle);
            rectangle.x = screenWidth / 2;
            rectangle.y = ScreenHeight / 2;

            rectangle.width = squareSize;
            rectangle.height = squareSize;
        }

        public void SetFood(Food f)
        {
            fruit = f;
        }



        public override void OnTimedEvent(object source, ElapsedEventArgs e) //ONTIMEDEVENT SNAKE DO THIS
        {
            if (movementCall == "LEFT")
            {
                rectangle.x = rectangle.x - squareSize;
            }
            if (movementCall == "RIGHT")
            {
                rectangle.x = rectangle.x + squareSize;
            }
            if (movementCall == "UP")
            {
                rectangle.y = rectangle.y - squareSize;
            }
            if (movementCall == "DOWN")
            {
                rectangle.y = rectangle.y + squareSize;
            }

            MakeSnakeLonger();


        }


        public bool isOutsideOfLvl(){
            if(rectangle.x < 0 || rectangle.x > screenWidth || rectangle.y < 0 || rectangle.y > ScreenHeight  ){
                return this.isOutside = true; 
            }
            else{
                return this.isOutside = false; 
            }
        }

        public void MakeSnakeLonger()
        {
            if (CollissionCheck(fruit) == true)
            {

                snakeLength.Add(new Rectangle(100,100,squareSize,squareSize)); 

                System.Console.WriteLine(snakeLength.Count);
                
            }

        }


        private static void MovementControls()  //CHANGE THE INTERNAL MOVEMENT OF SNAKE
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

        public void Draw()
        {
            MovementControls();

            for (int i = 0; i < snakeLength.Count; i++)
            {
                Raylib.DrawRectangleRec(rectangle, snakeColour);
                
            }

        }
    }

}