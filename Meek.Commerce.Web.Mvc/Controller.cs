using Meek.Business;
using Meek.Commerce.Framework.Authentication;

namespace Meek.Commerce.Web.Mvc
{
    public abstract class Controller : Meek.Web.Mvc.Controller
    {
        protected virtual ISystemUser CurrentUser
        {
            get
            {
                return SystemUserManager.CurrentUser;
            }
        }
    }

    public abstract class Controller<TLogic> : Meek.Web.Mvc.Controller<TLogic>
        where TLogic : ILogic
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
