using System;
using System.Data.Objects.DataClasses;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Meek.Commerce.Framework.Model
{
    #region Entities

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "Meek.Commerce.Framework.Model", Name = "SystemUserAccount")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class SystemUserAccount : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new SystemUserAccount object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="userName">Initial value of the UserName property.</param>
        /// <param name="userRoleID">Initial value of the UserRoleID property.</param>
        /// <param name="profileID">Initial value of the ProfileID property.</param>
        /// <param name="isActive">Initial value of the IsActive property.</param>
        public static SystemUserAccount CreateSystemUserAccount(global::System.Int64 id, global::System.String userName, global::System.Int64 userRoleID, global::System.Int64 profileID, global::System.Boolean isActive)
        {
            SystemUserAccount systemUserAccount = new SystemUserAccount();
            systemUserAccount.ID = id;
            systemUserAccount.UserName = userName;
            systemUserAccount.UserRoleID = userRoleID;
            systemUserAccount.ProfileID = profileID;
            systemUserAccount.IsActive = isActive;
            return systemUserAccount;
        }

        #endregion
        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int64 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int64 _ID;
        partial void OnIDChanging(global::System.Int64 value);
        partial void OnIDChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public global::System.String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                OnPasswordChanging(value);
                ReportPropertyChanging("Password");
                _Password = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Password");
                OnPasswordChanged();
            }
        }
        private global::System.String _Password;
        partial void OnPasswordChanging(global::System.String value);
        partial void OnPasswordChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public global::System.String PasswordSalt
        {
            get
            {
                return _PasswordSalt;
            }
            set
            {
                OnPasswordSaltChanging(value);
                ReportPropertyChanging("PasswordSalt");
                _PasswordSalt = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PasswordSalt");
                OnPasswordSaltChanged();
            }
        }
        private global::System.String _PasswordSalt;
        partial void OnPasswordSaltChanging(global::System.String value);
        partial void OnPasswordSaltChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int64 UserRoleID
        {
            get
            {
                return _UserRoleID;
            }
            set
            {
                OnUserRoleIDChanging(value);
                ReportPropertyChanging("UserRoleID");
                _UserRoleID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UserRoleID");
                OnUserRoleIDChanged();
            }
        }
        private global::System.Int64 _UserRoleID;
        partial void OnUserRoleIDChanging(global::System.Int64 value);
        partial void OnUserRoleIDChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int64 ProfileID
        {
            get
            {
                return _ProfileID;
            }
            set
            {
                OnProfileIDChanging(value);
                ReportPropertyChanging("ProfileID");
                _ProfileID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ProfileID");
                OnProfileIDChanged();
            }
        }
        private global::System.Int64 _ProfileID;
        partial void OnProfileIDChanging(global::System.Int64 value);
        partial void OnProfileIDChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                OnIsActiveChanging(value);
                ReportPropertyChanging("IsActive");
                _IsActive = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsActive");
                OnIsActiveChanged();
            }
        }
        private global::System.Boolean _IsActive;
        partial void OnIsActiveChanging(global::System.Boolean value);
        partial void OnIsActiveChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int64> UserCreated
        {
            get
            {
                return _UserCreated;
            }
            set
            {
                OnUserCreatedChanging(value);
                ReportPropertyChanging("UserCreated");
                _UserCreated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UserCreated");
                OnUserCreatedChanged();
            }
        }
        private Nullable<global::System.Int64> _UserCreated;
        partial void OnUserCreatedChanging(Nullable<global::System.Int64> value);
        partial void OnUserCreatedChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DateCreated
        {
            get
            {
                return _DateCreated;
            }
            set
            {
                OnDateCreatedChanging(value);
                ReportPropertyChanging("DateCreated");
                _DateCreated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateCreated");
                OnDateCreatedChanged();
            }
        }
        private Nullable<global::System.DateTime> _DateCreated;
        partial void OnDateCreatedChanging(Nullable<global::System.DateTime> value);
        partial void OnDateCreatedChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int64> UserModified
        {
            get
            {
                return _UserModified;
            }
            set
            {
                OnUserModifiedChanging(value);
                ReportPropertyChanging("UserModified");
                _UserModified = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UserModified");
                OnUserModifiedChanged();
            }
        }
        private Nullable<global::System.Int64> _UserModified;
        partial void OnUserModifiedChanging(Nullable<global::System.Int64> value);
        partial void OnUserModifiedChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DateModified
        {
            get
            {
                return _DateModified;
            }
            set
            {
                OnDateModifiedChanging(value);
                ReportPropertyChanging("DateModified");
                _DateModified = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateModified");
                OnDateModifiedChanged();
            }
        }
        private Nullable<global::System.DateTime> _DateModified;
        partial void OnDateModifiedChanging(Nullable<global::System.DateTime> value);
        partial void OnDateModifiedChanged();

        #endregion

        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Meek.Commerce.Framework.Model", "FK_SystemUserAccount_SystemUserRole", "SystemUserRole")]
        public SystemUserRole SystemUserRole
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SystemUserRole>("Meek.Commerce.Framework.Model.FK_SystemUserAccount_SystemUserRole", "SystemUserRole").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SystemUserRole>("Meek.Commerce.Framework.Model.FK_SystemUserAccount_SystemUserRole", "SystemUserRole").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<SystemUserRole> SystemUserRoleReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SystemUserRole>("Meek.Commerce.Framework.Model.FK_SystemUserAccount_SystemUserRole", "SystemUserRole");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<SystemUserRole>("Meek.Commerce.Framework.Model.FK_SystemUserAccount_SystemUserRole", "SystemUserRole", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Meek.Commerce.Framework.Model", "FK_SystemUserRole_UserCreated", "SystemUserRole")]
        public EntityCollection<SystemUserRole> SystemUserRole1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<SystemUserRole>("Meek.Commerce.Framework.Model.FK_SystemUserRole_UserCreated", "SystemUserRole");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<SystemUserRole>("Meek.Commerce.Framework.Model.FK_SystemUserRole_UserCreated", "SystemUserRole", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Meek.Commerce.Framework.Model", "FK_SystemUserRole_UserModified", "SystemUserRole")]
        public EntityCollection<SystemUserRole> SystemUserRole2
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<SystemUserRole>("Meek.Commerce.Framework.Model.FK_SystemUserRole_UserModified", "SystemUserRole");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<SystemUserRole>("Meek.Commerce.Framework.Model.FK_SystemUserRole_UserModified", "SystemUserRole", value);
                }
            }
        }

        #endregion
    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "Meek.Commerce.Framework.Model", Name = "SystemUserRole")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class SystemUserRole : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new SystemUserRole object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="roleCode">Initial value of the RoleCode property.</param>
        /// <param name="isTemplate">Initial value of the IsTemplate property.</param>
        /// <param name="isActive">Initial value of the IsActive property.</param>
        public static SystemUserRole CreateSystemUserRole(global::System.Int64 id, global::System.String roleCode, global::System.Boolean isTemplate, global::System.Boolean isActive)
        {
            SystemUserRole systemUserRole = new SystemUserRole();
            systemUserRole.ID = id;
            systemUserRole.RoleCode = roleCode;
            systemUserRole.IsTemplate = isTemplate;
            systemUserRole.IsActive = isActive;
            return systemUserRole;
        }

        #endregion
        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int64 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int64 _ID;
        partial void OnIDChanging(global::System.Int64 value);
        partial void OnIDChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String RoleCode
        {
            get
            {
                return _RoleCode;
            }
            set
            {
                OnRoleCodeChanging(value);
                ReportPropertyChanging("RoleCode");
                _RoleCode = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("RoleCode");
                OnRoleCodeChanged();
            }
        }
        private global::System.String _RoleCode;
        partial void OnRoleCodeChanging(global::System.String value);
        partial void OnRoleCodeChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsTemplate
        {
            get
            {
                return _IsTemplate;
            }
            set
            {
                OnIsTemplateChanging(value);
                ReportPropertyChanging("IsTemplate");
                _IsTemplate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsTemplate");
                OnIsTemplateChanged();
            }
        }
        private global::System.Boolean _IsTemplate;
        partial void OnIsTemplateChanging(global::System.Boolean value);
        partial void OnIsTemplateChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                OnIsActiveChanging(value);
                ReportPropertyChanging("IsActive");
                _IsActive = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsActive");
                OnIsActiveChanged();
            }
        }
        private global::System.Boolean _IsActive;
        partial void OnIsActiveChanging(global::System.Boolean value);
        partial void OnIsActiveChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int64> UserCreated
        {
            get
            {
                return _UserCreated;
            }
            set
            {
                OnUserCreatedChanging(value);
                ReportPropertyChanging("UserCreated");
                _UserCreated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UserCreated");
                OnUserCreatedChanged();
            }
        }
        private Nullable<global::System.Int64> _UserCreated;
        partial void OnUserCreatedChanging(Nullable<global::System.Int64> value);
        partial void OnUserCreatedChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DateCreated
        {
            get
            {
                return _DateCreated;
            }
            set
            {
                OnDateCreatedChanging(value);
                ReportPropertyChanging("DateCreated");
                _DateCreated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateCreated");
                OnDateCreatedChanged();
            }
        }
        private Nullable<global::System.DateTime> _DateCreated;
        partial void OnDateCreatedChanging(Nullable<global::System.DateTime> value);
        partial void OnDateCreatedChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int64> UserModified
        {
            get
            {
                return _UserModified;
            }
            set
            {
                OnUserModifiedChanging(value);
                ReportPropertyChanging("UserModified");
                _UserModified = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UserModified");
                OnUserModifiedChanged();
            }
        }
        private Nullable<global::System.Int64> _UserModified;
        partial void OnUserModifiedChanging(Nullable<global::System.Int64> value);
        partial void OnUserModifiedChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DateModified
        {
            get
            {
                return _DateModified;
            }
            set
            {
                OnDateModifiedChanging(value);
                ReportPropertyChanging("DateModified");
                _DateModified = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateModified");
                OnDateModifiedChanged();
            }
        }
        private Nullable<global::System.DateTime> _DateModified;
        partial void OnDateModifiedChanging(Nullable<global::System.DateTime> value);
        partial void OnDateModifiedChanged();

        #endregion

        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Meek.Commerce.Framework.Model", "FK_SystemUserAccount_SystemUserRole", "SystemUserAccount")]
        public EntityCollection<SystemUserAccount> SystemUserAccount
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<SystemUserAccount>("Meek.Commerce.Framework.Model.FK_SystemUserAccount_SystemUserRole", "SystemUserAccount");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<SystemUserAccount>("Meek.Commerce.Framework.Model.FK_SystemUserAccount_SystemUserRole", "SystemUserAccount", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Meek.Commerce.Framework.Model", "FK_SystemUserRole_UserCreated", "SystemUserAccount")]
        public SystemUserAccount SystemUserAccount1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SystemUserAccount>("Meek.Commerce.Framework.Model.FK_SystemUserRole_UserCreated", "SystemUserAccount").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SystemUserAccount>("Meek.Commerce.Framework.Model.FK_SystemUserRole_UserCreated", "SystemUserAccount").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<SystemUserAccount> SystemUserAccount1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SystemUserAccount>("Meek.Commerce.Framework.Model.FK_SystemUserRole_UserCreated", "SystemUserAccount");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<SystemUserAccount>("Meek.Commerce.Framework.Model.FK_SystemUserRole_UserCreated", "SystemUserAccount", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Meek.Commerce.Framework.Model", "FK_SystemUserRole_UserModified", "SystemUserAccount")]
        public SystemUserAccount SystemUserAccount2
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SystemUserAccount>("Meek.Commerce.Framework.Model.FK_SystemUserRole_UserModified", "SystemUserAccount").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SystemUserAccount>("Meek.Commerce.Framework.Model.FK_SystemUserRole_UserModified", "SystemUserAccount").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<SystemUserAccount> SystemUserAccount2Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SystemUserAccount>("Meek.Commerce.Framework.Model.FK_SystemUserRole_UserModified", "SystemUserAccount");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<SystemUserAccount>("Meek.Commerce.Framework.Model.FK_SystemUserRole_UserModified", "SystemUserAccount", value);
                }
            }
        }

        #endregion
    }

    #endregion
}
