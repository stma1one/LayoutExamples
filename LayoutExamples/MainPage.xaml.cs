namespace LayoutExamples;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		Button btn= sender as Button;
		ContentPage p = null; 
		switch(btn.Text)
		{
			case "Border Example":
				p = new BorderExamplePage();
				await App.Current.Windows[0].Page.Navigation.PushAsync(p);
				break;
			case "ScrollView Example":
				p = new ScrollViewExamplePage();
                await App.Current.Windows[0].Page.Navigation.PushAsync(p);
                break;
			case "Horizontal StackLayout Example":
				p = new HorizontalStackLayoutExamplePage();
                await App.Current.Windows[0].Page.Navigation.PushAsync(p);
                break;
			case "Grid Example":
				p = new GridExamplePage();
               await App.Current.Windows[0].Page.Navigation.PushAsync(p);
                break;
            case "FlexLayout Example":
				p = new FlexLayoutExamplePage();
                await App.Current.Windows[0].Page.Navigation.PushAsync(p);
                break;
            default:
				await DisplayAlert("אין מה לעשות פה", "אין פה כלום", "אישור");
				break;
		}
	}
}

