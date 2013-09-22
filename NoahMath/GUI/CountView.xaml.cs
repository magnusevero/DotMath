using System.Windows;

namespace NoahMath.GUI
{
	/// <summary>
	/// Interaction logic for Count.xaml
	/// </summary>
	public partial class CountView : Window
	{
		public CountView()
		{
			InitializeComponent();
			var viewModel = new CountViewModel();
			DataContext = viewModel;
		}
	}
}
