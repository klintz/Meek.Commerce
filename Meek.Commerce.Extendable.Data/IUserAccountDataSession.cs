using System.ServiceModel;
using Meek.Commerce.Framework.Model;

namespace Meek.Commerce.Extendable.Data
{
    [ServiceContract]
    public interface IUserAccountDataSession : IDataSession
    {
        [OperationContract(Name = "GetSystemUserAccountByID")]
        SystemUserAccount GetSystemUserAccount(long id);

        [OperationContract(Name = "GetSystemUserAccountByUserName")]
        SystemUserAccount GetSystemUserAccount(string userName);

        [OperationContract(Name = "SaveUserAccount")]
        void SaveUserAccount(SystemUserAccount userAccount);
    }
}