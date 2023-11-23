using IMCApp.Mvvm.Views;

namespace IMCApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnGo_Clicked(object sender, EventArgs e)
            => App.Current.MainPage = new ImcCalculatorView();
    }

}
