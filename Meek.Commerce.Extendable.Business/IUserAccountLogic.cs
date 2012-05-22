using Meek.Commerce.Framework.Model;

namespace Meek.Commerce.Extendable.Business
{
    public interface IUserAccountLogic : ILogic
    {
        SystemUserAccount NewSystemUserAccount();

        SystemUserAccount GetSystemUserAccount(long id);

        SystemUserAccount GetSystemUserAccount(string userName);
    }
}
