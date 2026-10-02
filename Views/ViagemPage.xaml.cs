using Viagem.ViewModel;

namespace Viagem.Views;

public partial class ViagemPage : ContentPage
{
	public ViagemPage(ViagemViewModel viewModels)
	{
		InitializeComponent();
		BindingContext = viewModels;
	}
}