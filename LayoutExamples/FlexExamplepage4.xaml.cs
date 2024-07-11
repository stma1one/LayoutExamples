
using LayoutExamples.Models;
namespace LayoutExamples;

public partial class FlexExamplepage4 : ContentPage
{
	public FlexExamplepage4()
	{
		InitializeComponent();
		BuildUI();
	}

    private async void BuildUI()
    {
        try
        {
            List<string> list = await MyPhotos.CreateMyPhotos();
            foreach (string photo in list)
            {
                Image image = new Image() { Source= photo  ,HeightRequest=100, WidthRequest=100 };    
                flexLayout.Children.Add(image);
            }
            activityIndicator.IsRunning = false;
            activityIndicator.IsVisible= false; 
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
    }
}