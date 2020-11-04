using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XFFurniture.Droid
{
    [Activity(Label = "OSSC Móvil", Icon = "@mipmap/icon", Theme = "@style/splashThemeOSSC",
        MainLauncher = true, NoHistory = true)]

    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //NavigationPage.SetHasNavigationBar(this, false);

            StartActivity(new Intent(Application.Context, typeof(MainActivity)));

            // Create your application here

        }// onCreate

    }// class

}// namespace