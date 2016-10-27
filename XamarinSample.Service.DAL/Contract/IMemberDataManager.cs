// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMemberDataManager.cs" company="">
//   
// </copyright>
// <summary>
//   The MemberDataManager interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinSample.Service.DAL
{
    using System.Collections.Generic;

    using XamarinSample.Models;

    /// <summary>
    /// The MemberDataManager interface.
    /// </summary>
    public interface IMemberDataManager
    {
        /// <summary>
        /// The get member on login from db.
        /// </summary>
        /// <param name="login">
        /// The login.
        /// </param>
        /// <returns>
        /// The <see cref="Member"/>.
        /// </returns>
        Member GetMemberOnLoginFromDB(string login);

        /// <summary>
        /// The get member collection from db.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        List<Member> GetMemberCollectionFromDB();
    }
}