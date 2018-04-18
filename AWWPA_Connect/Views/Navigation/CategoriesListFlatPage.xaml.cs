using System;
using Xamarin.Forms;

namespace AWWPA_Connect
{
	public partial class CategoriesListFlatPage : ContentPage
	{
		public CategoriesListFlatPage()
		{
			InitializeComponent();

			BindingContext = new SamplesViewModel();
		}

		private async void OnItemTapped(Object sender, ItemTappedEventArgs e)
		{
			var selectedItem = ((ListView)sender).SelectedItem;
			var sampleCategory = (SampleCategory)selectedItem;

			await Navigation.PushAsync(new SamplesListFromCategoryPage(sampleCategory.Id));
		}
	}
}

