using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AWWPA_Connect
{
	public partial class ProductItemFullScreenPage : ContentPage
	{
		public ProductItemFullScreenPage()
		{
			InitializeComponent();

			BindingContext = new ProductViewModel(SampleData.Products[0].Id);
		}
	}
}