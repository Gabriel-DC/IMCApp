using IMCApp.Mvvm.Models;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;


namespace IMCApp.Mvvm.ViewModels
{
    public partial class ImcCalculatorViewModel : ObservableObject
    {
        [ObservableProperty]
        private decimal _peso;

        [ObservableProperty]
        private decimal _altura;

        [ObservableProperty]
        private decimal _imc;

        private ESex _sex;

        [RelayCommand]
        public async Task CalcularImc()
        {
            decimal alturaEmMetros = (int)Altura / 100m;

            Imc = Peso / (alturaEmMetros * alturaEmMetros);
            await App.Current.MainPage.DisplayAlert("IMC", $"Seu IMC é {Imc:F2}", "Ok");
        }

        public void SetSex(ESex sex) => _sex = sex;
    }
}
