using System.Runtime.Serialization;
using Meek.Commerce.Framework.Model;

namespace Meek.Commerce.Framework.Authentication
{
    [DataContract]
    public class SystemUser : ISystemUser
    {
        [DataMember]
        public long UserID { get; private set; }

        [DataMember]
        public long UserRoleID { get; private set; }

        [DataMember]
        public string UserName { get; private set; }

        [DataMember]
        public string DisplayName { get; private set; }

        [DataMember]
        public string UserRoleCode { get; private set; }


        private SystemUser(SystemUserAccount account)
        {
            UserID = account.ID;
            UserRoleID = account.UserRoleID;
            UserName = account.UserName;
            UserRoleCode = account.SystemUserRole.RoleCode;
        }

        public static ISystemUser NewSystemUser(SystemUserAccount account)
        {
            return new SystemUser(account);
        }
    }
}
