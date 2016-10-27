// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StudentDataManagerStub.cs" company="">
//   
// </copyright>
// <summary>
//   The student data manager stub.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinSample.Service.DAL
{
    using System.Collections.Generic;

    using XamarinSample.Contract;
    using XamarinSample.Models;

    /// <summary>
    /// The student data manager stub.
    /// </summary>
    public class StudentDataManagerStub : IStudentDataManager
    {
        /// <summary>
        /// The get student collection from db.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Student> GetStudentCollectionFromDB()
        {
            Student student1 = new Student { Name = "Bruce", Surname = "Hulk" };
            Student student2 = new Student { Name = "Natasha", Surname = "Romanoff" };
            Student student3 = new Student { Name = "Tony", Surname = "Stark" };
            Student student4 = new Student { Name = "Pepper", Surname = "Potts" };
            Student student5 = new Student { Name = "Chris ", Surname = "Hemsworth" };

            List<Student> studentCollection = new List<Student> { student2, student1, student3, student4, student5 };

            return studentCollection;
        }
    }
}