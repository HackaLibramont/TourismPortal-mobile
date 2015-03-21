using Android.App;
using Android.OS;
using FormsLibrary;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace eTourismeAndroid
{
    [Activity(Label = "eTourismeAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AndroidActivity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Forms.Init(this, bundle);

            LoadApplication(new App());
        }
    }
}

