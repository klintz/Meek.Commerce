using Meek.Business;
using Meek.Commerce.Framework.Authentication;

namespace Meek.Commerce.Web.Mvc
{
    public abstract class ViewMasterPage : Meek.Web.Mvc.ViewMasterPage
    {
        protected virtual ISystemUser CurrentUser
        {
            get
            {
                return SystemUserManager.CurrentUser;
            }
        }
    }

    public abstract class ViewMasterPage<TModel> : Meek.Web.Mvc.ViewMasterPage<TModel>
    {
        protected virtual ISystemUser CurrentUser
        {
            get
            {
                return SystemUserManager.CurrentUser;
            }
        }
    }
}
