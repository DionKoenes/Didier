using System.Numerics;

namespace Didier
{
	enum State
	{
		Quit,
		Playing,
		Lost,
		Won
	}

	abstract class SceneNode : Node
	{
		public Vector2 Camera;
		public State State { get; set; }

		protected SceneNode() : base()
		{
			Camera = new Vector2(Settings.ScreenSize.X/2, Settings.ScreenSize.Y/2);
			State = State.Playing;
		}
	}
}
