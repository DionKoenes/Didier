using System.Numerics; // Vector2
using Raylib_cs; // Color

namespace Didier
{
	interface IDrawable
	{
		string TextureName { get; set; }
		Vector2 TextureSize { get; set; }
		Vector2 Pivot { get; set; }
		Color Color { get; set; }

		void Draw();
	}
}
