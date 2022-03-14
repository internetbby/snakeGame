using System;
using Raylib_cs;
using System.Numerics;

namespace snakeGame
{
    public class Grid : MonoBehaviour
    {


        protected Vector2 numberOfCells = new Vector2();


        public Grid()
        {
            numberOfCells.X = screenWidth / squareSize;
            numberOfCells.Y = ScreenHeight / squareSize;

        }

        public void Draw()
        {
            for (int i = 0; i < numberOfCells.Y; i++)
            {
                // Vertical
                Raylib.DrawLine(0, i*squareSize, screenWidth, i*squareSize, Color.LIGHTGRAY);  

            }

            for (int i = 0; i < numberOfCells.X; i++)
            {
             

            }
        }
    }
}