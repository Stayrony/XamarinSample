// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorizationService.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the AuthorizationService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using XamarinSample.Droid.Services;

[assembly: Xamarin.Forms.Dependency(typeof(AuthorizationService))]

namespace XamarinSample.Droid.Services
{
    using XamarinSample.Contract;
    using XamarinSample.Models;

    /// <summary>
    /// The authorization service.
    /// </summary>
    public class AuthorizationService : IAuthorizationService
    {
        /// <summary>
        /// The login.
        /// </summary>
        /// <param name="memberInfo">
        /// The member Info.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool Login(Member memberInfo)
        {
            if (memberInfo.Login == "dev" && memberInfo.Password == "dev")
            {
                return true;
            }
            return false;
        }
    }
}