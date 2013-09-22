using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using NoahMath.BaseClasses;
using NoahMath.Models;

namespace NoahMath.GUI
{
	public class CountViewModel : NotifyPropertyChangedBase
	{
		private readonly Random _random;
		private readonly PreparedQuestions _questions;
		private readonly Dice _dice;

		private Visibility _happySmileyVisible;
		public Visibility HappySmileyVisible
		{
			get { return _happySmileyVisible; }
			set
			{
				_happySmileyVisible = value;
				OnPropertyChanged("HappySmileyVisible");
			}
		}

		private Visibility _sadSmileyVisible;
		
		public Visibility SadSmileyVisible 
		{ get { return _sadSmileyVisible; }
			set
			{
				_sadSmileyVisible = value;
				OnPropertyChanged("SadSmileyVisible");
			} }

		public ObservableCollection<DotPosition> DotPositions { get; set; }
		public Question Question { get; set; }

		private int _buttonOneText;

		public int ButtonOneText
		{
			get { return _buttonOneText; }
			set
			{
				_buttonOneText = value;
				OnPropertyChanged("ButtonOneText");
			}
		}

		private int _buttonTwoText;

		public int ButtonTwoText
		{
			get { return _buttonTwoText; }
			set
			{
				_buttonTwoText = value;
				OnPropertyChanged("ButtonTwoText");
			}
		}

		private int _buttonThreeText;

		public int ButtonThreeText
		{
			get { return _buttonThreeText; }
			set
			{
				_buttonThreeText = value;
				OnPropertyChanged("ButtonThreeText");
			}
		}

		public ICommand ButtonOneCommand { get; set; }
		public ICommand ButtonTwoCommand { get; set; }
		public ICommand ButtonThreeCommand { get; set; }
		public ICommand NextQuestionCommand { get; set; }

		public CountViewModel()
		{
			ButtonOneCommand = new RelayCommand(_ => ButtonOne(), _ => true);
			ButtonTwoCommand = new RelayCommand(_ => ButtonTwo(), _ => true);
			ButtonThreeCommand = new RelayCommand(_ => ButtonThree(), _ => true);
			NextQuestionCommand = new RelayCommand(_ => NextQuestion(), _ => HappySmileyVisible == Visibility.Visible);

			DotPositions = new ObservableCollection<DotPosition>();
			HappySmileyVisible = Visibility.Hidden;
			SadSmileyVisible = Visibility.Hidden;

			_dice = new Dice();
			_questions = new PreparedQuestions();
			_random = new Random(DateTime.Now.Millisecond);
			SetupQuestion();
		}

		private void NextQuestion()
		{
			HappySmileyVisible = Visibility.Hidden;
			SetupQuestion();
		}

		private void SetupQuestion()
		{
			var questionNumber = _random.Next(_questions.Questions.Count);
			Question = _questions.Questions.ElementAt(questionNumber);

			DotPositions.Clear();
			var dotPositions = _dice.DiceSides.ElementAt(Question.Answer - 1).DotPositions;
			foreach (var dotPosition in dotPositions)
			{
				DotPositions.Add(dotPosition);
			}
			ButtonOneText = Question.Alternative1;
			ButtonTwoText = Question.Alternative2;
			ButtonThreeText = Question.Alternative3;
		}

		private void ButtonOne()
		{
			if (Question.Alternative1 == Question.Answer)
				CorrectAnswer();
			else
				InCorrectAnswer();
		}

		private void ButtonTwo()
		{
			if (Question.Alternative2 == Question.Answer)
				CorrectAnswer();
			else
				InCorrectAnswer();
		}

		private void ButtonThree()
		{
			if (Question.Alternative3 == Question.Answer)
				CorrectAnswer();
			else
				InCorrectAnswer();
		}

		private void CorrectAnswer()
		{
			HappySmileyVisible = Visibility.Visible;
			SadSmileyVisible = Visibility.Hidden;
		}

		private void InCorrectAnswer()
		{
			HappySmileyVisible = Visibility.Hidden;
			SadSmileyVisible = Visibility.Visible;
		}
	}
}
