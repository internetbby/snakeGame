using System;
using Raylib_cs;

namespace snakeGame
{
    public class Snake : MonoBehaviour
    {
        private int snakeLength = 200;
        private int position;

        private int speed;

        private int size = 30; 



        private Color snakeColour = Color.BLUE; 


        public void SetLength(int length)
        {
            snakeLength = length;
        }

        public void Draw(){
            Raylib.DrawRectangle(4, 4, size, size, snakeColour);   
        }
    }

}