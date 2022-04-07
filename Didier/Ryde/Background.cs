using System; // Random, Math
using System.Numerics; // Vector2
using System.Collections.Generic; // List
using Raylib_cs; // Raylib

namespace Didier
{
	class Background : MoverNode
	{

		public Background(string fn) : base(fn)
		{

		}

		public void Forward(float deltaTime)
		{
			Console.WriteLine("Moving FAST!!!");
		}
	}
}