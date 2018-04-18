using System.Collections.Generic;
using System.Globalization;

namespace AWWPA_Connect
{
	public class DashboardViewModel : ObservableObject
	{
		public DashboardViewModel()
			: base(listenCultureChanges: true)
		{
		}

		public List<SampleCategory> Items 
		{ 
			get { return SamplesDefinition.SamplesCategoryList; } 
		}

		protected override void OnCultureChanged(CultureInfo culture)
		{
			NotifyPropertyChanged(nameof(Items));
		}
	}
}