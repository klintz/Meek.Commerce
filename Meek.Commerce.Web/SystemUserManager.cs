using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Meek.Commerce.Framework.Model;
using Meek.Commerce.Framework.Authentication;

namespace Meek.Commerce.Web
{
    public sealed class SystemUserManager
    {
        private const string SYSTEM_USER_SESSION_KEY = "F9FC0A39-A8EA-4993-BEB1-A1ABAEECAB99";

        private static ISystemUser _defaultUser;

        private static ISystemUser DefaultUser
        {
            get
            {
                if (Equals(_defaultUser, null))
                {
                    var account = new SystemUserAccount
                    {
                        ID = 0,
                        UserRoleID = 0
                    };
                    _defaultUser = SystemUser.NewSystemUser(account);
                }
                return _defaultUser;
            }
        }

        public static ISystemUser CurrentUser
        {
            get
            {
                var user = HttpContext.Current.Session[SYSTEM_USER_SESSION_KEY];

                if (Equals(user, null))
                    return DefaultUser;

                if (user is ISystemUser)
                    return user as ISystemUser;

                return DefaultUser;
            }
        }
    }
}
