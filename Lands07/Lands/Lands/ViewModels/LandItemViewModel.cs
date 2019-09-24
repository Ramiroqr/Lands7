namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Lands.Models;
    using Lands.Views;
    using System.Windows.Input;
    using Xamarin.Forms;

    class LandItemViewModel : Land
    {
        #region Commands
        public ICommand SelectLandCommand
        {
            get
            {
                return new RelayCommand(SelectLand);
            }
        }

        #endregion


        #region Methods
        private async void SelectLand()
        {                                               //this manda toda la clasa actual
            MainViewModel.GetInstance().Land = new LandViewModel(this);
            await Application.Current.MainPage.Navigation.PushAsync(new Landpage());
        } 
        #endregion
    }
}
