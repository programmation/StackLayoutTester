using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StackLayoutTester
{
	public partial class ButtonsPage : ContentPage
	{
		private bool _expanded = true;

		public ButtonsPage ()
		{
			InitializeComponent ();
		}

		public void OnExpand (object sender, EventArgs e)
		{
			if (_expanded) {
				b1.VerticalOptions = LayoutOptions.Start;
				b2.VerticalOptions = LayoutOptions.Center;
				b3.VerticalOptions = LayoutOptions.End;
				t1.Text = "Expand";
			} else {
				b1.VerticalOptions = LayoutOptions.StartAndExpand;
				b2.VerticalOptions = LayoutOptions.CenterAndExpand;
				b3.VerticalOptions = LayoutOptions.EndAndExpand;
				t1.Text = "Fix";
			}
			_expanded = !_expanded;
			ForceLayout ();
		}
	}
}

