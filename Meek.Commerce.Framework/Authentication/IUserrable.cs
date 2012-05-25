using System.ServiceModel;

namespace Meek.Commerce.Framework.Authentication
{
    [ServiceContract]
    public interface IUserrable
    {
        ISystemUser CurrentUser
        {
            [OperationContract]
            get;
            
            [OperationContract]
            set;
        }
    }
}