using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Shapes;

namespace LayoutExamples;

public partial class FlexExample3Page : ContentPage
{
	public FlexExample3Page()
	{
		InitializeComponent();
	}

    private void OnAddVoteClick(object sender, EventArgs e)
    {

		Button button = (Button)sender;
		DefineStyle(button.Text);

    }

    private void DefineStyle(string text) 
    {
        Label label= new Label() { VerticalOptions=LayoutOptions.Center, HorizontalOptions=LayoutOptions.Center   ,Text = text, HorizontalTextAlignment= TextAlignment.Center };
        Border border = new Border()
        {
           
            Opacity = 0.8,
            WidthRequest = 100,
            HeightRequest = 40,
            StrokeShape = new Ellipse() {    },
            Content = label,


        };

        switch (label.Text)
        {
            case "גרוע":
                border.BackgroundColor=Colors.Red;
                label.TextColor = Colors.White;
                break;
            case "מעולה":
                border.BackgroundColor = Colors.DarkGreen;
                label.TextColor= Colors.White;   
                break;
            default:
                border.BackgroundColor = Colors.LightBlue;
                break;

        }
        cloudTags.Children.Add(border);
        

        
    }
}