using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Service.DAL.Test
{
    using NUnit.Framework;

    using XamarinSample.Models;

    /// <summary>
    /// The member data manager tester.
    /// </summary>
    [TestFixture]
    public class MemberDataManagerTester
    {
        /// <summary>
        /// The _member data manager.
        /// </summary>
        private IMemberDataManager _memberDataManager;

        /// <summary>
        /// The set up.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            this._memberDataManager = DalManagerFactory.CreateMemberDataManager("stub");
        }

        /// <summary>
        /// The get member on login test.
        /// </summary>
        [Test]
        public void GetMemberOnLoginTest()
        {
            string login = "admin";

            Member member = this._memberDataManager.GetMemberOnLoginFromDB(login);

            Assert.That(member.Login, Is.EqualTo(login));
        }
    }
}
