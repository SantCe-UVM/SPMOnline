namespace School.UIForms.Infrastructure
{
	using School.UIForms.ViewModels;
	public class InstanceLocator
	{
		public MainViewModel Main { get; set; }
		public InstanceLocator()
		{
			this.Main = new MainViewModel();
		}
	}
}
