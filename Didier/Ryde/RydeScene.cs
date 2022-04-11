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
		private Bike bike;
		// private Background background;
		private List<Background> backgrounds;

		public RydeScene() : base()
		{
			backgrounds = new List<Background>();
			Reload();
		}

		public void Reload()
		{
			Children.Clear();
			State = State.Playing;

			backgrounds.Add(new Background("resources/achtergrond.png"));
			backgrounds[0].Position = new Vector2((int)Settings.ScreenSize.X / 2, 0);
			AddChild(backgrounds[0]);

			backgrounds.Add(new Background("resources/achtergrond.png"));
			backgrounds[1].Position = new Vector2((int)Settings.ScreenSize.X / 2, 720);
			AddChild(backgrounds[1]);

			bike = new Bike("resources/rydecar.png");
			bike.Position = new Vector2((int)Settings.ScreenSize.X / 2, (int)Settings.ScreenSize.Y / 2);
			AddChild(bike);
		}

		private void HandleBackGrounds(float deltaTime)
		{
			for (int i = 0; i < backgrounds.Count; i++)
			{
				backgrounds[i].ForwardSpeed(deltaTime);

				if (backgrounds[i].Position.Y > 720 + 360)
				{
					backgrounds[i].Position.Y = -360;
				}
			}
		}

		private void HandleInput(float deltaTime)
		{
			// Reload Game
			if (Raylib.IsKeyReleased(KeyboardKey.KEY_R))
			{
				Reload();
				Console.WriteLine("Reloaded!!!");
			}
			// Player Positioning
			if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
			{
				bike.LeanLeft(deltaTime);
			}
            else if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
			{
				bike.LeanRight(deltaTime);
            }
            else
            {
				bike.Straight(deltaTime);
            }

			//player giving gas and braking
			if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
				bike.Gas(deltaTime);
            }
            else if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
			{
				bike.Slow(deltaTime);
			}
			else
			{
				bike.Idle(deltaTime);
			}

			//background moving
			if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
				HandleBackGrounds(deltaTime);
            }

			//anders sta rechtop wanneer geen button pressed. meer sprites leunen

			/*if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                bike.RotateLeft(deltaTime);
            }
            if (Raylib.IsKeyReleased(KeyboardKey.KEY_RIGHT))
            {
                bike.StopRotating();
            }
            if (Raylib.IsKeyReleased(KeyboardKey.KEY_LEFT))
            {
                bike.StopRotating();
            }
            // Player Thrust
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                bike.Thrust();
            }
            if (Raylib.IsKeyReleased(KeyboardKey.KEY_UP))
            {
                bike.NoThrust();
            }*/
		}
		public override void Update(float deltaTime)
		{
			HandleInput(deltaTime);
		}
	}
}
