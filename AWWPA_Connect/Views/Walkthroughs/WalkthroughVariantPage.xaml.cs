using System;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AWWPA_Connect
{
	public partial class WalkthroughVariantPage : CarouselPage
	{
		public WalkthroughVariantPage ()
		{
			InitializeComponent ();

			NavigationPage.SetHasNavigationBar(this, false);

			this.BindingContext = new WalkthroughViewModel(Close, GoToStep);
		}

		private async Task GoToStep()
		{
			var index = Children.IndexOf(CurrentPage);
			var moveToIndex = 0;
			if (index < Children.Count - 1)
			{
				moveToIndex = index + 1;

				CurrentPage = Children[moveToIndex];
			}
			else
			{
				await Close();
			}
		}

		private async Task Close()
		{
			await Navigation.PopModalAsync();
		}

		protected async override void OnCurrentPageChanged()
		{
			base.OnCurrentPageChanged();
			var currentStep = (WalkthroughVariantStepItemTemplate)CurrentPage;

			await currentStep.AnimateIn();
		}
	}
}

