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
    using XamarinSample.Service.DAL;

    /// <summary>
    /// The student service.
    /// </summary>
    public class StudentService : IStudentService
    {
        /// <summary>
        /// The _student data manager.
        /// </summary>
        private IStudentDataManager _studentDataManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="StudentService"/> class.
        /// </summary>
        public StudentService()
        {
            this._studentDataManager = DalManagerFactory.CreateStudentDataManager("stub");
        }

        /// <summary>
        /// The get student collection.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Student> GetStudentCollection()
        {
            return this._studentDataManager.GetStudentCollectionFromDB();
        }
    }
}