using System;
using Raylib_cs;
using System.Numerics;

namespace snakeGame
{
    public class InteractableObject : Timer
    {

        protected Rectangle rectangle = new Rectangle();

        public bool CollissionCheck(InteractableObject other)
        {
            bool collission = Raylib.CheckCollisionRecs(this.rectangle, other.rectangle);
            return collission;
        }
    }
}