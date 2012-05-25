using Meek.Business;
using Meek.Commerce.Framework.Authentication;

namespace Meek.Commerce.Web.Mvc
{
    public abstract class View : Meek.Web.Mvc.View
    {
        protected virtual ISystemUser CurrentUser
        {
            get
            {
                return SystemUserManager.CurrentUser;
            }
        }
    }

    public abstract class View<TModel> : Meek.Web.Mvc.View<TModel>
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
