using Xamarin.Forms;

namespace XamarinSample.Views
{
    using XamarinSample.ViewModels;

    /// <summary>
    /// The student list page.
    /// </summary>
    public partial class StudentListPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StudentListPage"/> class.
        /// </summary>
        public StudentListPage()
        {
            InitializeComponent();
            BindingContext = new StudentListViewModel();
        }
    }
}
