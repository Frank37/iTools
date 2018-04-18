using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AWWPA_Connect
{
	public partial class TimelinePage : ContentPage
	{
		public TimelinePage()
		{
			InitializeComponent();

			this.BindingContext = new TimelineViewModel();
		}
	}
}

