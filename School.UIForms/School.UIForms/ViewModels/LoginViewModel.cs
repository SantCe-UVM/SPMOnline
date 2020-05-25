namespace School.UIForms.ViewModels
{
	using GalaSoft.MvvmLight.Command;
	using School.UIForms.Views;
	using System;
	using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel
	{
		public string Email { get; set; }
		public string Password { get; set; }
		public ICommand LoginCommand => new RelayCommand(Login);

		private async void Login()
		{
			if (string.IsNullOrEmpty(this.Email))
			{
				await Application.Current.MainPage.DisplayAlert(
					"Error",
					"You must enter an Email",
					"Accept");
				return;
			}
			if (string.IsNullOrEmpty(this.Password))
			{
				await Application.Current.MainPage.DisplayAlert(
					"Error",
					"You must enter a Password",
					"Accept");
				return;
			}
			if(!this.Email.Equals("eduardofong@gmail.com")||!this.Password.Equals("123456"))
			{
				await Application.Current.MainPage.DisplayAlert(
					"Error",
					"User or Password incorrect",
					"Accept");
				return;
			}
			//await Application.Current.MainPage.DisplayAlert(
			//		"LISTOOO",
			//		"OK",
			//		"Accept");
			MainViewModel.GetInstance().Subjects = new SubjectsViewModel();
			await Application.Current.MainPage.Navigation.PushAsync(new SubjectsPage());
			return;
		}
		public LoginViewModel()
		{
			this.Email = "eduardofong@gmail.com";
			this.Password = "123456";
		}
	}
}
