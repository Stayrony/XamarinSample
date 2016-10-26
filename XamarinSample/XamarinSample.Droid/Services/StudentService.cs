// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StudentService.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the StudentService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using XamarinSample.Contract;
using XamarinSample.Droid.Services;

[assembly: Xamarin.Forms.Dependency(typeof(StudentService))]

namespace XamarinSample.Droid.Services
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using XamarinSample.Models;

    /// <summary>
    /// The student service.
    /// </summary>
    public class StudentService : IStudentService
    {
        /// <summary>
        /// The get student collection.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Student> GetStudentCollection()
        {

            Student student1 = new Student { Name = "Admin", Surname = "SysAdmin" };
            Student student2 = new Student { Name = "Developer", Surname = "Dev" };
            Student student3 = new Student { Name = "Tony", Surname = "Stark" };
            Student student4 = new Student { Name = "Lok", Surname = "Loki" };
            List<Student> studentCollection = new List<Student> { student2, student1, student3, student4 };

            return studentCollection;
        }
    }
}