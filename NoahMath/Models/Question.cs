namespace NoahMath.Models
{
	public class Question
	{
		public int Answer { get; set; }
		public int Alternative1 { get; set; }
		public int Alternative2 { get; set; }
		public int Alternative3 { get; set; }

		public Question(int answer, int alt1, int alt2, int alt3)
		{
			Answer = answer;
			Alternative1 = alt1;
			Alternative2 = alt2;
			Alternative3 = alt3;
		}
	}
}
