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

            tabs.Children.Add(new WebPage("http://sunsethackathon.com/") { Title = "Dia 1" });
            tabs.Children.Add(new WebPage("https://sunsethackathon.com/v2/") { Title = "Dia 2" });
            tabs.Children.Add(new WebPage("https://www.facebook.com/events/268455490389190/") { Title = "Dia 3" });
            tabs.Children.Add(new WebPage("http://xamarin.com") { Title = "Talk with us" });

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
