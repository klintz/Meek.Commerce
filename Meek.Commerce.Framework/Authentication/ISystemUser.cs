namespace Meek.Commerce.Framework.Authentication
{
    public interface ISystemUser
    {
        long UserID { get; }

        long UserRoleID { get; }

        string UserName { get; }

        string DisplayName { get; }

        string UserRoleCode { get; }

    }
}