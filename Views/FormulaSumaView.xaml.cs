using SumaAppMvvm.ViewModels;
namespace SumaAppMvvm.Views;

public partial class FormulaSumaView : ContentPage
{
	FormulaSumaViewModel ViewModel;
	public FormulaSumaView()
	{
		InitializeComponent();
		ViewModel = new FormulaSumaViewModel();
		BindingContext = ViewModel;
	}

}