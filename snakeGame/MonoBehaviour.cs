using System;
using Raylib_cs;
using System.Numerics;

namespace snakeGame
{
    public class MonoBehaviour
    {
        protected int squareSize = 31;
        public int ScreenHeight;
        public int screenWidth;

        public MonoBehaviour(){
            screenWidth = squareSize*30;
            ScreenHeight = squareSize*20 ;
        }

        


    }
}