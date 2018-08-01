using System;
using System.Collections.Generic;

using Plugin.MediaManager;

using Xamarin.Forms;

namespace SunsetHackathon
{
    public partial class VideoStreamPage : ContentPage
    {
        public VideoStreamPage(String url)
        {
			ShowStream(url);

        }

		private async void ShowStream(String url){
			await CrossMediaManager.Current.Play(url);
		}

    }
}
