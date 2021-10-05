using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Xamarin.Forms;

using Xamarin.Forms.Platform.Android;
namespace SfRTE
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Forms.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            var mainPage = new SfRTE().CreateSupportFragment(this);
            SupportFragmentManager
             .BeginTransaction()
             .Replace(Resource.Id.fragment_frame_layout, mainPage)
             .Commit();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}