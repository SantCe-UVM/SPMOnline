namespace School.UIForms.ViewModels
{
    using School.Common.Models;
    using School.Common.Services;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;

    public class PlayersViewModel : BaseViewModel
    {
        private ApiService apiService;
        private ObservableCollection<PlayersViewModel> player;
        public ObservableCollection<PlayersViewModel> Players
        {
            get { return this.player; }
            set { this.SetValue(ref this.player, value); }
        }

        public PlayersViewModel()
        {
            this.apiService = new ApiService();
            this.LoadSubjects();
        }

        private async void LoadSubjects()
        {
            var response = await this.apiService.GetListAsync<PlayersViewModel>(
                "https://schoolweb20200526040544.azurewebsites.net/",
                "/API",
                "/Subjects");
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept");
                return;
            }
            var myPlayers = (List<PlayersViewModel>)response.Result;
            this.Players = new ObservableCollection<PlayersViewModel>(myPlayers);
        }
    }
}
