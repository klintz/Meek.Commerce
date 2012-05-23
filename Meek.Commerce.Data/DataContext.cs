using System;
using System.Data;
using System.Linq;
using Meek.Commerce.Framework.Authentication;
using Meek.Commerce.Framework.Model;

namespace Meek.Commerce.Data
{
    public partial class DataContext : IUserrable
    {
        public ISystemUser User { get; set; }

        public override int SaveChanges(System.Data.Objects.SaveOptions options)
        {
            var transactionDate = DateTime.Now;

            //Add
            var addedEntries = ObjectStateManager.GetObjectStateEntries(EntityState.Added);
            var addedEntities = from e in addedEntries where e.Entity is IAuditable select e.Entity as IAuditable;
            foreach (var addedEntity in addedEntities)
            {
                addedEntity.UserCreated = User.UserID;
                addedEntity.DateCreated = transactionDate;
            }

            //Modified
            var modifiedEntries = ObjectStateManager.GetObjectStateEntries(EntityState.Modified);
            var modifiedEntities = from e in modifiedEntries where e.Entity is IAuditable select e.Entity as IAuditable;
            foreach (var modifiedEntity in modifiedEntities)
            {
                modifiedEntity.UserModified = User.UserID;
                modifiedEntity.DateModified = transactionDate;
            }
            
            return base.SaveChanges(options);
        }
    }
}
