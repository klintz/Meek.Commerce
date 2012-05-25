using Meek.Commerce.Extendable.Business;
using Meek.Commerce.Extendable.Data;
using Meek.Commerce.Framework.Model;
using Meek.Commerce.Framework.Authentication;

namespace Meek.Commerce.Business
{
    public class UserAccountLogic : BaseLogic<IUserAccountDataSession>, IUserAccountLogic
    {
        public SystemUserAccount NewSystemUserAccount()
        {
            return new SystemUserAccount();
        }

        public SystemUserAccount GetSystemUserAccount(long id)
        {
            return DataSession.GetSystemUserAccount(id);
        }

        public SystemUserAccount GetSystemUserAccount(string userName)
        {
            return DataSession.GetSystemUserAccount(userName);
        }
    }
}

