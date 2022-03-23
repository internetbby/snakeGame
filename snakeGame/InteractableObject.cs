using System;
using Raylib_cs;
using System.Numerics;

namespace snakeGame
{
    public class InteractableObject : Timer
    {

        protected Vector2 position = new Vector2();

        protected Vector2 size = new Vector2();

        protected Rectangle rectangle = new Rectangle();

        public bool CollissionCheck(InteractableObject other)
        {
            bool collission = Raylib.CheckCollisionRecs(this.rectangle, other.rectangle);
            return collission;
        }
    }
}