// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IStudentsService.cs" company="">
//   
// </copyright>
// <summary>
//   The StudentsService interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinSample.Contract
{
    using System.Collections.Generic;

    using XamarinSample.Models;

    /// <summary>
    /// The StudentService interface.
    /// </summary>
    public interface IStudentService
    {
        /// <summary>
        /// The get student collection.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        List<Student> GetStudentCollection();
    }
}