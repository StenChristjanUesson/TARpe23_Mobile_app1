using Models;

namespace Maui_Planets.Views;

public partial class PlanetDetailsPage : ContentPage
{
	public PlanetDetailsPage(Planet planet)
	{
		InitializeComponent();

        this.BindingContext = planet;
    }

	//async void BackButton_Clicked(System.Object, System.EventArgs e)
	//{
	//	await 
	//}
}