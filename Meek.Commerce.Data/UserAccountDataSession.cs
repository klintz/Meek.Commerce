using System.Linq;
using Meek.Commerce.Extendable.Data;
using Meek.Commerce.Framework.Model;

namespace Meek.Commerce.Data
{
    public class UserAccountDataSession : DataSession, IUserAccountDataSession
    {
        
        public SystemUserAccount GetSystemUserAccount(long id)
        {
            return CurrentContext.SystemUserAccount.SingleOrDefault(u => u.ID == id);
        }
        
        public SystemUserAccount GetSystemUserAccount(string userName)
        {
            return CurrentContext.SystemUserAccount.SingleOrDefault(u => u.UserName == userName);
        }

        public void SaveUserAccount(SystemUserAccount userAccount)
        {
            CurrentContext.SystemUserAccount.AddObject(userAccount);
        }
    }
}
