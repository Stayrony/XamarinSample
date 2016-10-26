// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAuthorizationService.cs" company="">
//   
// </copyright>
// <summary>
//   The AuthorizationService interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinSample.Contract
{
    using XamarinSample.Models;

    /// <summary>
    /// The AuthorizationService interface.
    /// </summary>
    public interface IAuthorizationService
    {
        /// <summary>
        /// The login.
        /// </summary>
        /// <param name="member">
        /// The member.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool Login(Member member);
    }
}