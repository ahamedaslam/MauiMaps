using Microsoft.Maui.Maps;

namespace MuiMapsApp;

public partial class MainPage : ContentPage
{
	//int count = 0;

	public MainPage()
	{
		InitializeComponent();

		var location = new Location(36.9628066, -122.0194722);
		var mapSpan = new MapSpan(location, 0.01, 0.01);
		map.MoveToRegion(mapSpan);
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		//count++;

		//if (count == 1)
		//	CounterBtn.Text = $"Clicked {count} time";
		//else
		//	CounterBtn.Text = $"Clicked {count} times";

		//SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

