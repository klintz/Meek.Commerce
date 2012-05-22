using System.ServiceModel;
using Meek.Commerce.Framework.Authentication;

namespace Meek.Commerce.Extendable.Data
{
    [ServiceContract]
    public interface IDataSession : Meek.Data.IDataSession
    {
         
    }
}