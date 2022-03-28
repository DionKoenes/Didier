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
		private SpriteNode background;

		public RydeScene() : base()
		{
			bike = new SpriteNode("resources/rydecar.png");
			bike.Position = new Vector2((int)Settings.ScreenSize.X / 2, (int)Settings.ScreenSize.Y / 2);
			AddChild(bike);

			background = new SpriteNode("resoruceajnkwbdakwjdbawkdjb");
			
		}


		public override void Update(float deltaTime)
		{

		}
	}
}

