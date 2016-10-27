using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XamarinSample.Service.DAL
{
    using XamarinSample.Contract;

    /// <summary>
    /// The dal manager factory.
    /// </summary>
    public static class DalManagerFactory
    {
        #region StudentDataManager
        /// <summary>
        /// The create student data manager.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="IStudentDataManager"/>.
        /// </returns>
        public static IStudentDataManager CreateStudentDataManager(string type)
        {
            IStudentDataManager studentDataManager = null;
            switch (type)
            {
                case "stub":
                    studentDataManager = StudentDataManagerStub;
                    break;
                case "real":
                    studentDataManager = StudentDataManager;
                    break;
                default:
                    break;
            }

            return studentDataManager;
        }

        /// <summary>
        /// Gets or sets the student data manager.
        /// </summary>
        private static IStudentDataManager StudentDataManager
        {
            //todo for real
            get; set;
        }

        /// <summary>
        /// Gets the student data manager stub.
        /// </summary>
        private static IStudentDataManager StudentDataManagerStub
        {
            get
            {
                //see https://github.com/mrbrl/PCLAppConfig
                /*  var typeName = ConfiguratorManager.AppSettings["studentDataManagerStub"];
                  var providerType = Type.GetType(typeName);
                  if (providerType != null)
                  {
                      return (IStudentService)Activator.CreateInstance(providerType);
                  }

                  throw new ArgumentNullException("StudentDataManagerStub"); */
                return new StudentDataManagerStub();
            }
        }

        #endregion StudentDataManager

        #region MemberDataManager

        /// <summary>
        /// The member data manager.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="IMemberDataManager"/>.
        /// </returns>
        public static IMemberDataManager CreateMemberDataManager(string type)
        {
            IMemberDataManager memberDataManager = null;
            switch (type)
            {
                case "stub":
                    memberDataManager = MemberDataManagerStub;
                    break;
                case "real":
                    memberDataManager = MemberDataManager;
                    break;
                default:
                    break;
            }

            return memberDataManager;
        }

        /// <summary>
        /// Gets the member data manager stub.
        /// </summary>
        private static IMemberDataManager MemberDataManagerStub
        {
            get
            {
                return new MemberDataManagerStub();
            }
        }

        /// <summary>
        /// Gets the member data manager.
        /// </summary>
        private static IMemberDataManager MemberDataManager { get; }

        #endregion MemberDataManager
    }
}
