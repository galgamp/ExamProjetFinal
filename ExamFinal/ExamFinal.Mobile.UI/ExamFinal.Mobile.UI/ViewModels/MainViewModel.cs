using ExamFinal.Mobile.UI.IViewModels;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Navigation;

namespace ExamFinal.Mobile.UI.ViewModels
{
    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        private INavigationService _iNavigationService;
        public ICommand NavigateCommand { get; set; }

        public MainViewModel(INavigationService navigationService)
        {
            _iNavigationService = navigationService;

            NavigateCommand = new Command<String>(NavigateTo);
        }

        private async void NavigateTo(string obj)
        {
            await _iNavigationService.NavigateTo(obj);
        }
    }
}
