using System; // Random, Math
using System.Numerics; // Vector2
using System.Collections.Generic; // List
using Raylib_cs; // Raylib

namespace Didier
{
	class RydeScene : SceneNode
	{
		//private SpaceShip player;
		//private List<Bullet> bullets;
		//private List<Asteroid> asteroids;
		private SpriteNode bike;

		public RydeScene() : base()
		{
			bike = new SpriteNode("resources/rydecar.png");
			bike.Position = new Vector2((int)Settings.ScreenSize.X / 2, (int)Settings.ScreenSize.Y / 2);
			AddChild(bike);
		}


		public override void Update(float deltaTime)
		{

		}

			// Camera
			/*
			float camspeed = 200.0f;
			if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
			{
				Camera.X += deltaTime * camspeed;
			}
			if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
			{
				Camera.X -= deltaTime * camspeed;
			}
			if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
			{
				Camera.Y += deltaTime * camspeed;
			}
			if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
			{
				Camera.Y -= deltaTime * camspeed;
			}
			*/
	}
}

