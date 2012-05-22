using System.ServiceModel;

namespace Meek.Commerce.Framework.Authentication
{
    [ServiceContract]
    public interface IUserrable
    {
        ISystemUser User
        {
            [OperationContract]
            get;
            
            [OperationContract]
            set;
        }
    }
}