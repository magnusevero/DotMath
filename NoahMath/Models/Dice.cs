using System.Collections.Generic;

namespace NoahMath.Models
{
	public class Dice
	{
		public List<DiceSide> DiceSides { get; set; }

		public Dice()
		{
			DiceSides= new List<DiceSide>();
			for (var side = 1; side <= 6; side++)
			{
				DiceSides.Add(new DiceSide(side));
			}
		}
	}
}
