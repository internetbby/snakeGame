using System;
using Raylib_cs;
using System.Numerics;

namespace snakeGame
{
    public class MonoBehaviour
    {
        protected int squareSize = 31;
        protected int ScreenHeight;

        private static int originalFactorOfScreenWidth = 30; 
        private static int originalFactorOfScreenHeight = 20; 
        public int screenWidth;

        public MonoBehaviour(){
            screenWidth = squareSize* originalFactorOfScreenWidth;
            ScreenHeight = squareSize*originalFactorOfScreenHeight ;
        }

        public int GetScreenHeight(){
            return ScreenHeight;
        }

        public int GetScreenWidth(){
            return screenWidth;
        }


    }
}