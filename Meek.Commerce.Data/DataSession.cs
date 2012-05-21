using Meek.Commerce.Extendable.Data;

namespace Meek.Commerce.Data
{
    public abstract class DataSession : Meek.Data.EntityFramework.DataSession, IDataSession
    {
        protected DataSession(DataProvider provider)
            :base(provider)
        {
        }
    }
}
