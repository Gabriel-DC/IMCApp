
using IMCApp.Mvvm.Models;
using IMCApp.Mvvm.ViewModels;

namespace IMCApp.Mvvm.Views;

public partial class ImcCalculatorView : ContentPage
{
    private readonly ImcCalculatorViewModel _viewModel;
    public ImcCalculatorView()
	{
		InitializeComponent();
        _viewModel = new ImcCalculatorViewModel();
        BindingContext = _viewModel;
    }

    private void ManIcon_Clicked(object sender, EventArgs e)
    {
        if (App.Current.Resources.TryGetValue("Secondary", out object colorValue))
        {
            ManIcon.BackgroundColor = (Color)colorValue;
            WomanIcon.BackgroundColor = Color.FromRgba(0,0,0,0);
            _viewModel.SetSex(ESex.Male);
        }
    }

    private void WomanIcon_Clicked(object sender, EventArgs e)
    {
        if (App.Current.Resources.TryGetValue("FemaleColor", out object colorValue))
        {
            WomanIcon.BackgroundColor = (Color)colorValue;
            ManIcon.BackgroundColor = Color.FromRgba(0, 0, 0, 0);
            _viewModel.SetSex(ESex.Female);
        }
    }
}