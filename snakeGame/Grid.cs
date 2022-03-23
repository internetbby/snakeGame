using System;
using Raylib_cs;
using System.Numerics;

namespace snakeGame
{
    public class Grid : MonoBehaviour
    {


        protected Vector2 numberOfCells = new Vector2();

        private Snake snake = new Snake();

        private Food fruit = new Food();

        public Grid()
        {
            numberOfCells.X = screenWidth / squareSize;
            numberOfCells.Y = ScreenHeight / squareSize;

        }

        /*public bool CollissionCheck()
        {
            bool collissionX = snake.position.X + snake.size.X >= fruit.position.X && fruit.position.X + fruit.size.X >= snake.position.X;
            bool collissionY = snake.position.Y + snake.size.Y >= fruit.position.Y && fruit.position.Y + fruit.size.Y >= snake.position.Y;



            return collissionY && collissionX;
        }
*/ //Add dis in interactable class


        public void Draw()
        {
            for (int i = 0; i < numberOfCells.Y; i++)
            {
                // Vertical
                Raylib.DrawLine(0, i * squareSize, screenWidth, i * squareSize, Color.LIGHTGRAY);

            }

            for (int p = 0; p < numberOfCells.X; p++)
            {
                Raylib.DrawLine(p * squareSize, 0, p * squareSize, ScreenHeight, Color.LIGHTGRAY);

            }
        }

        public Vector2 GetScreenCoordsOfGrid(int x, int y)
        {
            return new Vector2(x * squareSize, y * squareSize);
        }
    }
}