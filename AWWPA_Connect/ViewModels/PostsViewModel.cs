using System.Collections.Generic;
using System.Globalization;

namespace AWWPA_Connect
{
	public class PostsViewModel : ObservableObject
	{
		public PostsViewModel()
			: base(listenCultureChanges: true)
		{
		}

		public List<Post> PostsList 
		{ 
			get { return SampleData.Posts; }
		}

		protected override void OnCultureChanged(CultureInfo culture)
		{
			NotifyPropertyChanged(nameof(PostsList));
		}
	}
}

