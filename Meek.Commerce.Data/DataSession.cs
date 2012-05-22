using Meek.Commerce.Extendable.Data;
using Meek.Commerce.Framework.Authentication;

namespace Meek.Commerce.Data
{
    public abstract class DataSession : Meek.Data.EntityFramework.DataSession, IDataSession, IUserrable
    {
        public virtual ISystemUser User { get; set; }

        protected DataContext CurrentContext
        {
            get { return DataContext as DataContext; }
        }

        protected DataSession()
            :this(null)
        {

        }

        internal DataSession(DataProvider provider)
            :base(provider)
        {
        }
    }
}
