using System;
using Raylib_cs;
using System.Numerics; 

namespace snakeGame
{
    public class Snake : MonoBehaviour
    {
        private int snakeLength = 200;
        private  Vector2 position = new Vector2();

        private int speed;

        
        private  Vector2 size = new Vector2();



        private Color snakeColour = Color.BLUE; 

        public Snake(){
            position.X = screenWidth/2;
            position.Y = ScreenHeight/2;

            size.Y = squareSize; 
            size.X = size.Y; 
        }

        public void movementControls(){
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_A)){
                position.X = position.X-squareSize;
            }
        }

        public void SetLength(int length)
        {
            snakeLength = length;
        }


        public void Draw(){

            movementControls();
            Raylib.DrawRectangleV(position, size, snakeColour);   
        }
    }

}