namespace XamarinSample.Service.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using XamarinSample.Models;

    /// <summary>
    /// The member data manager stub.
    /// </summary>
    public class MemberDataManagerStub : IMemberDataManager
    {
        /// <summary>
        /// The get member on login from DataBase.
        /// </summary>
        /// <param name="login">
        /// The login.
        /// </param>
        /// <returns>
        /// The <see cref="Member"/>.
        /// </returns>
        public Member GetMemberOnLoginFromDB(string login)
        {
            Member member = new Member();

            // member with that login only one (check when register), so FirstOrDefault
            member = this.GetMemberCollectionFromDB().FirstOrDefault(m => m.Login == login);

            return member;
        }

        /// <summary>
        /// The get member collection from DataBase.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Member> GetMemberCollectionFromDB()
        {
            Member member1 = new Member { Login = "dev", Password = "dev" };
            Member member2 = new Member { Login = "admin", Password = "admin" };
            Member member3 = new Member { Login = "user", Password = "user" };
            Member member4 = new Member { Login = "sa", Password = "sa123456!" };

            List<Member> memberCollection = new List<Member> { member1, member2, member3, member4 };
            return memberCollection;
        }
    }
}