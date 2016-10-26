// --------------------------------------------------------------------------------------------------------------------
// <copyright file="App.cs" company="">
//   
// </copyright>
// <summary>
//   The app.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinSample
{
    using Xamarin.Forms;

    /// <summary>
    /// The app.
    /// </summary>
    public class App : Application
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
            // The root page of your application
            MainPage = new MainPage();
        }

        /// <summary>
        /// The on start.
        /// </summary>
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        /// <summary>
        /// The on sleep.
        /// </summary>
        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        /// <summary>
        /// The on resume.
        /// </summary>
        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
