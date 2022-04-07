using System; // Random, Math
using System.Numerics; // Vector2
using System.Collections.Generic; // List
using Raylib_cs; // Raylib

namespace Didier
{
    class Bike : SpriteNode
    {
        private SpriteNode Default;
        private SpriteNode Forward;
        private SpriteNode Left;
        private SpriteNode Right;
        private SpriteNode Brake;

        public Bike(string fn) : base(fn)
        {

        }

        public void Straight(float deltaTime)
        {
            Console.WriteLine("Going Straight");
        }
        public void LeanLeft(float deltaTime)
        {
            Console.WriteLine("Leaning Left");
        }
        public void LeanRight(float deltaTime)
        {
            Console.WriteLine("Leaning Right");
        }
        public void Idle(float deltaTime)
        {
            Console.WriteLine("Idling");
        }
        public void Gas(float deltaTime)
        {
            Console.WriteLine("Accelerating");
        }
        public void Slow(float deltaTime)
        {
            Console.WriteLine("Braking");
        }
    }
}