using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StackLayoutTester
{
	public partial class MappedAddressPage : ContentPage
	{
		private bool _expanded = true;

		public MappedAddressPage ()
		{
			InitializeComponent ();
		}

		public void OnExpand (object sender, EventArgs e)
		{
			if (_expanded) {
				e1.VerticalOptions = LayoutOptions.Start;
				e2.VerticalOptions = LayoutOptions.Start;
				e3.VerticalOptions = LayoutOptions.Start;
				sl2.VerticalOptions = LayoutOptions.Start;
				sl3.VerticalOptions = LayoutOptions.Start;
				t1.Text = "Expand";
			} else {
				e1.VerticalOptions = LayoutOptions.StartAndExpand;
				e2.VerticalOptions = LayoutOptions.StartAndExpand;
				e3.VerticalOptions = LayoutOptions.StartAndExpand;
				sl2.VerticalOptions = LayoutOptions.StartAndExpand;
				sl3.VerticalOptions = LayoutOptions.StartAndExpand;
				t1.Text = "Fix";
			}
			_expanded = !_expanded;
			sl2.ForceLayout ();
			sl3.ForceLayout ();
			sl0.ForceLayout ();
		}
	}
}

