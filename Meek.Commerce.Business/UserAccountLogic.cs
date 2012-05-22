using Meek.Commerce.Data;
using Meek.Commerce.Extendable.Business;
using Meek.Commerce.Extendable.Data;
using Meek.Commerce.Framework.Model;

namespace Meek.Commerce.Business
{
    public class UserAccountLogic : BaseLogic<IUserAccountDataSession>, IUserAccountLogic
    {
        protected override IUserAccountDataSession DefaultDataSession
        {
            get
            {
                return new UserAccountDataSession();
            }
        }

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
