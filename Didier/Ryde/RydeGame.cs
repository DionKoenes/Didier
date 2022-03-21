using System; // Console
using System.Numerics; // Vector2

namespace Didier
{
	class RydeGame
	{
		private Core core;
		private Scene currentScene;

		public RydeGame()
		{
			core = new Core("Ryde");

			currentScene = new Scene();

			Node asteroid = new Node("resources/asteroid.png");
			asteroid.Position = new Vector2((int)Settings.ScreenSize.X / 2, (int)Settings.ScreenSize.Y / 2);

			currentScene.AddNode(asteroid);
		}

		public void Play()
		{
			while (core.Run(currentScene))
			{
				;
			}
			Console.WriteLine("Thank you for playing!");
		}
	}
}
