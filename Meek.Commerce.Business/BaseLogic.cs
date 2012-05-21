using Meek.Commerce.Extendable.Business;
using Meek.Commerce.Extendable.Data;

namespace Meek.Commerce.Business
{
    public abstract class BaseLogic : Meek.Business.BaseLogic, ILogic
    {
    }

    public abstract class BaseLogic<TDataSession> : Meek.Business.BaseLogic<TDataSession>, ILogic
        where TDataSession : IDataSession
    {
    }
}