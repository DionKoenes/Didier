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
		private Background background;

		public RydeScene() : base()
		{
			Reload();
		}

		public void Reload()
		{
			Children.Clear();
			State = State.Playing;

			background = new Background("resources/achtergrond.png");
			background.Position = new Vector2((int)Settings.ScreenSize.X / 2, (int)Settings.ScreenSize.Y / 2);
			AddChild(background);

			bike = new Bike("resources/rydecar.png");
			bike.Position = new Vector2((int)Settings.ScreenSize.X / 2, (int)Settings.ScreenSize.Y / 2);
			AddChild(bike);
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
				background.ForwardSpeed(deltaTime);
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

