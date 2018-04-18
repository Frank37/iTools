using System;
using Xamarin.Forms;

namespace AWWPA_Connect
{
	public partial class GrialDemoSettings : ContentPage
	{
		public GrialDemoSettings()
		{
			InitializeComponent();
		}

		public void OnBtnLightClicked()
		{
            Settings.SetTheme(Theme.Light);
		}

		public void OnBtnDarkClicked()
		{
            Settings.SetTheme(Theme.Dark);
		}

		public void OnBtnEnterpriseClicked()
		{
            Settings.SetTheme(Theme.Enterprise);
		}

		public void OnBtnCustomClicked()
		{
			//var uri = "mailto:hello@grialkit.com?subject=I%20want%20a%20custom%20theme%20for%20my%20Grial%20app&body=Please%20leave%20us%20your%20comments.";
			var uri = "http://grialkit.com/getquote";
			Device.OpenUri(new Uri(uri));
		}
	}
}
