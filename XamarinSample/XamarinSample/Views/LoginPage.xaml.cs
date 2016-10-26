// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoginPage.xaml.cs" company="">
//   
// </copyright>
// <summary>
//   The login page.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinSample.Views
{
    using Xamarin.Forms;

    using XamarinSample.ViewModels;

    /// <summary>
    /// The login page.
    /// </summary>
    public partial class LoginPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginPage"/> class.
        /// </summary>
        public LoginPage()
        {
            this.InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}
