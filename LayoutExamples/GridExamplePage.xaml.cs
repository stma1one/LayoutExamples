namespace LayoutExamples;

public partial class GridExamplePage : ContentPage
{
	public GridExamplePage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Page p = new SimplifiedGridPage();
		Navigation.PushAsync(p);
	}
}