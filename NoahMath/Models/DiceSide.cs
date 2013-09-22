using System.Collections.Generic;

namespace NoahMath.Models
{
	public class DiceSide
	{
		private const int X1 = 10;
		private const int X2 = 50;
		private const int X3 = 90;

		private const int Y1 = 10;
		private const int Y2 = 50;
		private const int Y3 = 90;


		public List<DotPosition> DotPositions { get; private set; }

		public DiceSide(int side)
		{
			DotPositions = new List<DotPosition>();
			switch (side)
			{
				case 1:
					DotPositions.Add(new DotPosition(X2, Y2));
					break;
				case 2:
					DotPositions.Add(new DotPosition(X1, Y1));
					DotPositions.Add(new DotPosition(X3, Y3));
					break;
				case 3:
					DotPositions.Add(new DotPosition(X1, Y1));
					DotPositions.Add(new DotPosition(X2, Y2));
					DotPositions.Add(new DotPosition(X3, Y3));
					break;
				case 4:
					DotPositions.Add(new DotPosition(X1, Y1));
					DotPositions.Add(new DotPosition(X3, Y1));
					DotPositions.Add(new DotPosition(X1, Y3));
					DotPositions.Add(new DotPosition(X3, Y3));
					break;
				case 5:
					DotPositions.Add(new DotPosition(X1, Y1));
					DotPositions.Add(new DotPosition(X3, Y1));
					DotPositions.Add(new DotPosition(X1, Y3));
					DotPositions.Add(new DotPosition(X3, Y3));
					DotPositions.Add(new DotPosition(X2, Y2));
					break;
				case 6:
					DotPositions.Add(new DotPosition(X1, Y1));
					DotPositions.Add(new DotPosition(X2, Y1));
					DotPositions.Add(new DotPosition(X3, Y1));
					DotPositions.Add(new DotPosition(X1, Y3));
					DotPositions.Add(new DotPosition(X2, Y3));
					DotPositions.Add(new DotPosition(X3, Y3));

					break;

			}
		}
	}
}