using ExamFinal.Mobile.UI.IViewModels;
using ExamFinal.Mobile.UI.Models;
using GalaSoft.MvvmLight;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Navigation;

namespace ExamFinal.Mobile.UI.ViewModels
{
    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        private INavigationService _iNavigationService;
        public ICommand AdresseCommand { get; set; }

        public MainViewModel(INavigationService navigationService)
        {
            _iNavigationService = navigationService;

            AdresseCommand = new Command<String>(FindCoordonnee);
        }

        private string _entryAdresse;
        public string EntryAdresse
        {
            get
            {
                return _entryAdresse;
            }
            set
            {
                _entryAdresse = value;
            }
        }

        private string _labelCoordonnee;
        public string LabelCoordonnee
        {
            get
            {
                return _labelCoordonnee;
            }
            set
            {
                _labelCoordonnee = value;
                RaisePropertyChanged("TauxBar");
            }
        }

        private async void FindCoordonnee(string obj)
        {
            using (var client = new HttpClient())
            {
                _entryAdresse = _entryAdresse.Replace(" ", "");
                var uri = new Uri( "http://dev.virtualearth.net/REST/v1/Locations?q=" + _entryAdresse + "&output=json&key=AiVtyKOfbie_p8qxC80wd3CXFWEANbXN_zSJcx9FdCV746v6At4qD-i-qjMWBhXU") ;
                var json = await client.GetStringAsync(uri);
                var result = JsonConvert.DeserializeObject<RootObject>(json);

                LabelCoordonnee = result.ToString();
            }
        }
    }
}
