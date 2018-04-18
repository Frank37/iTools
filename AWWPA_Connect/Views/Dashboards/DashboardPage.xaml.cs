using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AWWPA_Connect
{
	public partial class DashboardPage : ContentPage
	{
		public DashboardPage()
		{			
			InitializeComponent();

			BindingContext = new DashboardViewModel();
		}

		public async void NavigateToGrialSettingsPage()
		{ 
			await Navigation.PushAsync(new GrialDemoSettings());
		}
	}
}