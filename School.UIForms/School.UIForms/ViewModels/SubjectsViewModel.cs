namespace School.UIForms.ViewModels
{
    using School.Common.Models;
    using School.Common.Services;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;

    public class SubjectsViewModel:BaseViewModel
    {
        private ApiService apiService;
        private ObservableCollection<Subject> subjects;
        public ObservableCollection<Subject> Subjects 
        {
            get { return this.subjects; }
            set { this.SetValue(ref this.subjects, value); } 
        }

        public SubjectsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadSubjects();
        }

        private async void LoadSubjects()
        {
            var response = await this.apiService.GetListAsync<Subject>(
                "https://schoolwebcarlos.azurewebsites.net/",
                "/API",
                "/Subjects");
            if(!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept");
                return;
            }
            var mySubjects = (List<Subject>)response.Result;
            this.Subjects = new ObservableCollection<Subject>(mySubjects);
        }
    }
}
