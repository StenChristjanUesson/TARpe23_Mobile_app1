namespace ViewModels;

public partial class KalkulaatoriLeht : ContentPage
{
	public KalkulaatoriLeht()
	{
        InitializeComponent();

		this.BindingContext = new KalkulatooriLeheViewModel();
	}
}