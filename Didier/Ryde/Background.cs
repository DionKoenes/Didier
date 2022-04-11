using System; // Random, Math
using System.Numerics; // Vector2
using System.Collections.Generic; // List
using Raylib_cs; // Raylib

namespace Didier
{
	class Background : MoverNode
	{
		private float yspeed;

		public Background(string fn) : base(fn)
		{
			Position = new Vector2(640, 360);

			Velocity = new Vector2(0.0f, 0.0f);
			Acceleration = new Vector2(0.0f, 0.0f);
			Mass = 1.0f;
			yspeed = 500;
		}

		public void BackgroundPaste()
        {

        }

		public void ForwardSpeed(float deltaTime)
		{
			if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
				position.Y += yspeed * deltaTime;
			}

			Console.WriteLine("Going FASTEERRRR!!!");

		}
	}
}