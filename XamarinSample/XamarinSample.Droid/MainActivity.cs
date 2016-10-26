// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainActivity.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the MainActivity type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinSample.Droid
{
    using Android.App;
    using Android.Content.PM;
    using Android.OS;

    [Activity(Label = "XamarinSample", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        /// <summary>
        /// The on create.
        /// </summary>
        /// <param name="bundle">
        /// The bundle.
        /// </param>
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

