using Meek.Commerce.Extendable.Business;
using Meek.Commerce.Extendable.Data;
using Meek.Commerce.Framework.Authentication;

namespace Meek.Commerce.Business
{
    public abstract class BaseLogic : Meek.Business.BaseLogic, ILogic, IUserrable
    {
        public virtual ISystemUser CurrentUser { get; set; }
    }

    public abstract class BaseLogic<TDataSession> : Meek.Business.BaseLogic<TDataSession>, ILogic, IUserrable
        where TDataSession : IDataSession
    {
        private TDataSession _dataSession;

        public virtual ISystemUser CurrentUser { get; set; }

        protected override TDataSession DataSession
        {
            get
            {
                if (Equals(_dataSession, null))
                {
                    _dataSession = CreateDataSession<TDataSession>();
                    if (!Equals(_dataSession, null))
                    {
                        if (_dataSession is IUserrable)
                        {
                            (_dataSession as IUserrable).CurrentUser = CurrentUser;
                        }
                    }
                }
                return _dataSession;
            }
        }        
    }
}