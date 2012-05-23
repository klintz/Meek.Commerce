using System.ServiceModel;
using Meek.Commerce.Framework.Model;

namespace Meek.Commerce.Extendable.Business
{
    [ServiceContract]
    public interface IUserAccountLogic : ILogic
    {
        [OperationContract(Name = "NewUserAccount")]
        SystemUserAccount NewSystemUserAccount();

        [OperationContract(Name = "GetSystemUserAccountByID")]
        SystemUserAccount GetSystemUserAccount(long id);

        [OperationContract(Name = "GetSystemUserAccountByUserName")]
        SystemUserAccount GetSystemUserAccount(string userName);
    }
}
