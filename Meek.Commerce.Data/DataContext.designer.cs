using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Linq;
using System.Text;
using Meek.Commerce.Framework.Model;

namespace Meek.Commerce.Data
{
    public partial class DataContext : ObjectContext
    {
        #region Constructors

        /// <summary>
        /// Initializes a new DataContext object using the connection string found in the 'DataContext' section of the application configuration file.
        /// </summary>
        public DataContext()
            : base("name=DataContext", "DataContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new DataContext object.
        /// </summary>
        public DataContext(string connectionString)
            : base(connectionString, "DataContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new DataContext object.
        /// </summary>
        public DataContext(EntityConnection connection)
            : base(connection, "DataContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        #endregion

        #region Partial Methods

        partial void OnContextCreated();

        #endregion

        #region ObjectSet Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<SystemUserAccount> SystemUserAccount
        {
            get
            {
                if ((_SystemUserAccount == null))
                {
                    _SystemUserAccount = base.CreateObjectSet<SystemUserAccount>("SystemUserAccount");
                }
                return _SystemUserAccount;
            }
        }
        private ObjectSet<SystemUserAccount> _SystemUserAccount;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<SystemUserRole> SystemUserRole
        {
            get
            {
                if ((_SystemUserRole == null))
                {
                    _SystemUserRole = base.CreateObjectSet<SystemUserRole>("SystemUserRole");
                }
                return _SystemUserRole;
            }
        }
        private ObjectSet<SystemUserRole> _SystemUserRole;

        #endregion
        #region AddTo Methods

        /// <summary>
        /// Deprecated Method for adding a new object to the SystemUserAccount EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSystemUserAccount(SystemUserAccount systemUserAccount)
        {
            base.AddObject("SystemUserAccount", systemUserAccount);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the SystemUserRole EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSystemUserRole(SystemUserRole systemUserRole)
        {
            base.AddObject("SystemUserRole", systemUserRole);
        }

        #endregion
    }
}
