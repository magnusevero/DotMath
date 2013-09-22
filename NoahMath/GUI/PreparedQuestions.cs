using System.Collections.Generic;
using NoahMath.Models;

namespace NoahMath.GUI
{
	public class PreparedQuestions
	{
		public List<Question> Questions { get; set; }

		public PreparedQuestions()
		{
			Questions = new List<Question>();
			Questions.Add(new Question(1, 1, 2, 3));
			Questions.Add(new Question(2, 1, 5, 2));
			Questions.Add(new Question(3, 1, 2, 3));
			Questions.Add(new Question(4, 4, 5, 6));
			Questions.Add(new Question(5, 1, 5, 3));
			Questions.Add(new Question(6, 1, 4, 6));

			Questions.Add(new Question(1, 4, 5, 1));
			Questions.Add(new Question(2, 2, 5, 3));
			Questions.Add(new Question(3, 3, 4, 6));
			Questions.Add(new Question(4, 2, 5, 4));
			Questions.Add(new Question(5, 1, 2, 5));
			Questions.Add(new Question(6, 6, 2, 4));
		} 
	}
}