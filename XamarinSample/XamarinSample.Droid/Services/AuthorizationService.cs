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
    using XamarinSample.Service.DAL;

    /// <summary>
    /// The authorization service.
    /// </summary>
    public class AuthorizationService : IAuthorizationService
    {
        /// <summary>
        /// The _member data manager.
        /// </summary>
        private IMemberDataManager _memberDataManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationService"/> class.
        /// </summary>
        public AuthorizationService()
        {
            this._memberDataManager = DalManagerFactory.CreateMemberDataManager("stub");
        }

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

            Member member = this.GetMemberOnLogin(memberInfo.Login);
            if (member != null)
            {
                if (memberInfo.Password == member.Password)
                {
                    return true;
                }

            }

            return false;
        }

        /// <summary>
        /// The get member on login.
        /// </summary>
        /// <param name="login">
        /// The login.
        /// </param>
        /// <returns>
        /// The <see cref="Member"/>.
        /// </returns>
        private Member GetMemberOnLogin(string login)
        {
            Member member = this._memberDataManager.GetMemberOnLoginFromDB(login);
            return member;
        }

    }
}