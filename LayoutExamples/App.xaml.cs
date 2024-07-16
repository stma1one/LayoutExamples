namespace LayoutExamples;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		//open navigation page with the menu
		MainPage = new NavigationPage(new MainPage());
	}
}
