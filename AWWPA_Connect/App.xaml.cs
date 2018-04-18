using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using UXDivers.Artina.Shared;

namespace AWWPA_Connect
{
	//[XamlCompilation (XamlCompilationOptions.Skip)]
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = GetMainPage();

			MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.White);

			SampleData.Initialize();
			SamplesDefinition.Initialize();


		}

		public static Page GetMainPage()
		{
			return new RootPage(true);
		}
	}
}
