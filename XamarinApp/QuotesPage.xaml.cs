using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinApp
{
	public partial class QuotesPage : ContentPage
	{
		private int index = 0;
		private string[] quotes = new string[]{
				"Quote 1",
				"Quote 2",
				"Quote 3",
				"Quote 4"
			};
			
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			index++;
			if (index == quotes.Length)
				index = 0;
			
			quoteText.Text = quotes[index];
		}

		public QuotesPage()
		{
			InitializeComponent();

			quoteText.Text = quotes[index];
		}
	}
}
