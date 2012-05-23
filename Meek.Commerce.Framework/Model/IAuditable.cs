using System;

namespace Meek.Commerce.Framework.Model
{
    public interface IAuditable
    {
        long? UserCreated { get; set; }

        DateTime? DateCreated { get; set; }

        long? UserModified { get; set; }

        DateTime? DateModified { get; set; }
    }
}
