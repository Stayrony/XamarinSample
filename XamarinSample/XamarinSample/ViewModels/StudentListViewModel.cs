// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StudentListViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the StudentListViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinSample.ViewModels
{
    using System;
    using System.Collections.ObjectModel;

    using Xamarin.Forms;

    using XamarinSample.Contract;
    using XamarinSample.Models;

    /// <summary>
    /// The student list view model.
    /// </summary>
    public class StudentListViewModel : BaseViewModel
    {
        /// <summary>
        /// The _student list.
        /// </summary>
        private ObservableCollection<Student> _studentList;

        /// <summary>
        /// The _selected student.
        /// </summary>
        private Student _selectedStudent;

        /// <summary>
        /// Initializes a new instance of the <see cref="StudentListViewModel"/> class.
        /// </summary>
        /// <exception cref="Exception">
        /// </exception>
        public StudentListViewModel()
        {
            try
            {
                //Student student1 = new Student { Name = "Admin", Surname = "SysAdmin" };
                //Student student2 = new Student { Name = "Developer", Surname = "Dev" };
                //this._studentList = new ObservableCollection<Student> { student2, student1 };

                this._studentList = new ObservableCollection<Student>(DependencyService.Get<IStudentService>().GetStudentCollection());

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// Gets or sets the selected student.
        /// </summary>
        public Student SelectedStudent
        {
            get
            {
                return this._selectedStudent;
            }

            set
            {
                this._selectedStudent = value;
                this.OnPropertyChanged("SelectedStudent");
            }
        }

        /// <summary>
        /// Gets the student list.
        /// </summary>
        public ObservableCollection<Student> StudentList
        {
            get
            {
                return this._studentList;
            }
        }
    }
}