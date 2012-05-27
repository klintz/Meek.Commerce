using System.Runtime.Serialization;
using Meek.Commerce.Framework.Model;
using Meek.Security;

namespace Meek.Commerce.Framework.Authentication
{
    [DataContract]
    public class SystemUser : MembershipUser, ISystemUser
    {
        [DataMember]
        public override string Username
        {
            get
            {
                return base.Username;
            }
            protected set
            {
                base.Username = value;
            }
        }

        [DataMember]
        public long UserID { get; private set; }

        [DataMember]
        public long UserRoleID { get; private set; }

        [DataMember]
        public string DisplayName { get; private set; }

        [DataMember]
        public string UserRoleCode { get; private set; }

        [DataMember]
        public override string Comment
        {
            get
            {
                return base.Comment;
            }
            set
            {
                base.Comment = value;
            }
        }

        [DataMember]
        public override System.DateTime CreationDate
        {
            get
            {
                return base.CreationDate;
            }
            protected set
            {
                base.CreationDate = value;
            }
        }

        [DataMember]
        public override string Email
        {
            get
            {
                return base.Email;
            }
            set
            {
                base.Email = value;
            }
        }

        [DataMember]
        public override bool IsApproved
        {
            get
            {
                return base.IsApproved;
            }
            set
            {
                base.IsApproved = value;
            }
        }

        [DataMember]
        public override bool IsLockedOut
        {
            get
            {
                return base.IsLockedOut;
            }
            protected set
            {
                base.IsLockedOut = value;
            }
        }

        [DataMember]
        public override bool IsOnline
        {
            get
            {
                return base.IsOnline;
            }
            protected set
            {
                base.IsOnline = value;
            }
        }

        [DataMember]
        public override System.DateTime LastActivityDate
        {
            get
            {
                return base.LastActivityDate;
            }
            set
            {
                base.LastActivityDate = value;
            }
        }

        [DataMember]
        public override System.DateTime LastLockoutDate
        {
            get
            {
                return base.LastLockoutDate;
            }
            protected set
            {
                base.LastLockoutDate = value;
            }
        }

        [DataMember]
        public override System.DateTime LastLoginDate
        {
            get
            {
                return base.LastLoginDate;
            }
            set
            {
                base.LastLoginDate = value;
            }
        }

        [DataMember]
        public override System.DateTime LastPasswordChangedDate
        {
            get
            {
                return base.LastPasswordChangedDate;
            }
            protected set
            {
                base.LastPasswordChangedDate = value;
            }
        }

        [DataMember]
        public override string PasswordQuestion
        {
            get
            {
                return base.PasswordQuestion;
            }
            protected set
            {
                base.PasswordQuestion = value;
            }
        }

        [DataMember]
        public override string ProviderName
        {
            get
            {
                return base.ProviderName;
            }
            protected set
            {
                base.ProviderName = value;
            }
        }

        private SystemUser()
        { }

        private SystemUser(SystemUserAccount account)
        {
            UserID = account.ID;
            UserRoleID = account.UserRoleID;
            Username = account.UserName;
            UserRoleCode = account.SystemUserRole.RoleCode;
        }

        public static ISystemUser NewSystemUser(SystemUserAccount account)
        {
            return new SystemUser(account);
        }

        public static ISystemUser NewSystemUser()
        {
            return new SystemUser { 
                UserID = 0,
                UserRoleID = 0};  
        }
    }
}
