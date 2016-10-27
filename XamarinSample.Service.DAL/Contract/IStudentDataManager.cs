// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IStudentDataManager.cs" company="">
//   
// </copyright>
// <summary>
//   The StudentDataManager interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinSample.Service.DAL
{
    using System.Collections.Generic;

    using XamarinSample.Models;

    /// <summary>
    /// The StudentDataManager interface.
    /// </summary>
    public interface IStudentDataManager
    {
        /// <summary>
        /// The get student collection from db.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        List<Student> GetStudentCollectionFromDB();
    }
}