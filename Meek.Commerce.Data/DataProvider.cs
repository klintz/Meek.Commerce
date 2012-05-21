using System.Data.Objects;

namespace Meek.Commerce.Data
{
    public class DataProvider : Meek.Data.EntityFramework.DataProvider
    {
        public DataProvider(string connectionString)
            :base(connectionString)
        {
        }

        public DataProvider(ObjectContext context)
            :base(context)
        {
        }
    }
}
