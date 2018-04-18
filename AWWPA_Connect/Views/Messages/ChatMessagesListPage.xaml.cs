using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace AWWPA_Connect
{
	public partial class ChatMessagesListPage : ContentPage
	{
		public ChatMessagesListPage ()
		{
			InitializeComponent ();

			BindingContext = new ChatViewModel(useRecent: false);
		}
	}
}

