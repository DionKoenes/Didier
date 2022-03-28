using System; // Console
using Raylib_cs; //RayDot

namespace Didier
{
	class RydeGame
	{
		private Core core;
		private RydeScene currentScene;

		public RydeGame()
		{
			core = new Core("Ryde the Game");

			currentScene = new RydeScene();
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
