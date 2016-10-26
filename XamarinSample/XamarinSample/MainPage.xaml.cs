// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainPage.xaml.cs" company="">
//   
// </copyright>
// <summary>
//   The main page.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinSample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Xamarin.Forms;

    using XamarinSample.Models;
    using XamarinSample.Views;

    /// <summary>
    /// The main page.
    /// </summary>
    public partial class MainPage : MasterDetailPage
    {
        /// <summary>
        /// Gets the list view.
        /// </summary>
        public ListView ListView { get { return listView; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();

            this.listView.ItemSelected += this.OnItemSelected;

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Login",
                IconSource = "@drawable/login.png",
                TargetType = typeof(LoginPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "StudentListPage",
                IconSource = "@drawable/students.png",
                TargetType = typeof(StudentListPage)
            });

            this.listView.ItemsSource = masterPageItems;

        }

        /// <summary>
        /// The on item selected.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                this.listView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
