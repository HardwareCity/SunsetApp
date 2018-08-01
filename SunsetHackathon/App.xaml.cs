using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SunsetHackathon
{
    public partial class App : Application
    {
        public App()
        {
            var tabs = new TabbedPage();

            tabs.Children.Add(new WebPage(AppResources.url_day_one) { Title = AppResources.day_one });
            tabs.Children.Add(new WebPage(AppResources.url_day_two) { Title = AppResources.day_two });
            tabs.Children.Add(new WebPage(AppResources.url_day_three) { Title = AppResources.day_three });
			tabs.Children.Add(new VideoStreamPage("rtsp://184.72.239.149/vod/mp4:BigBuckBunny_175k.mov") { Title = "Video stream" });
            tabs.Children.Add(new WebPage(AppResources.url_talk_with_us) { Title = AppResources.talk_with_us });

            MainPage = tabs;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
