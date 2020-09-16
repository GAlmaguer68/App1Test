using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1Test
{
    public partial class App : Application
    {
        public App()
        {
            //Device.SetFlags(new string[] { "RadioButton_Experimental", "CarouselView_Experimental", "MediaElement_Experimental", "SwipeView_Experimental" });
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
