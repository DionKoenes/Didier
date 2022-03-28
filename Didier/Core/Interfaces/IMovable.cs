using System.Numerics;

namespace Didier
{
	interface IMovable
	{
		Vector2 Velocity { get; set; }
		Vector2 Acceleration { get; set; }
		float Mass { get; set; }

		void Move(float deltaTime);
		void AddForce(Vector2 force);
	}
}
