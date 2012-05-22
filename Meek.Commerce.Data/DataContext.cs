using Meek.Commerce.Framework.Authentication;

namespace Meek.Commerce.Data
{
    public partial class DataContext : IUserrable
    {
        ISystemUser IUserrable.User { get; set; }
    }
}
