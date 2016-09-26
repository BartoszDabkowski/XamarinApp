using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinApp
{
	public partial class ImagePage : ContentPage
	{
		public ImagePage()
		{
			InitializeComponent();

			var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/3/") };
			imageSource.CachingEnabled = false;
			image.Source = imageSource;
		}
	}
}
