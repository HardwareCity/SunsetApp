using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SunsetHackathon
{
    public partial class WebPage : ContentPage
    {
		public WebPage(String Source)
        {
			var browser = new WebView();
			browser.Source = Source;
            Content = browser;
        }
    }
}
