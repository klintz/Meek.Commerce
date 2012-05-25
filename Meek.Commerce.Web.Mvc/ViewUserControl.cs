using Meek.Business;
using Meek.Commerce.Framework.Authentication;

namespace Meek.Commerce.Web.Mvc
{
    public class ViewUserControl : Meek.Web.Mvc.ViewUserControl
    {
        protected virtual ISystemUser CurrentUser
        {
            get
            {
                return SystemUserManager.CurrentUser;
            }
        }
    }

    public class ViewUserControl<TModel> : Meek.Web.Mvc.ViewUserControl<TModel>
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
