using System;
using Raylib_cs;
using System.Numerics;

namespace snakeGame
{
    public class MonoBehaviour
    {
        protected int squareSize = 31;
        public int ScreenHeight;

        protected static int originalFactorOfScreenWidth = 30; 
        protected static int originalFactorOfScreenHeight = 20; 
        public int screenWidth;

        public MonoBehaviour(){
            screenWidth = squareSize* originalFactorOfScreenWidth;
            ScreenHeight = squareSize*originalFactorOfScreenHeight ;
        }

        


    }
}