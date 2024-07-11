using LayoutExamples.Models;

namespace LayoutExamples;

public partial class FlexLayoutExamplePage : ContentPage
{
	public FlexLayoutExamplePage()
	{
		InitializeComponent();
	}

    private async void NavigateOnClick(object sender, EventArgs e)
    {
		Button button=sender as Button;
		Page page = null;
		if (button != null)
		{
			if (button.Id == flexPage.Id)
				page = new FlexLayoutExamplePage2();

			else if (button.Id == WrapPage.Id)
				page = new FlexExample3Page();
			else 
				page = new FlexExamplepage4();
			
			await Navigation.PushAsync(page);
			

		}

    }
}