﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chapter01_Tai_Khoan_LinQ
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ACCOUNT_LINQ")]
	public partial class AccountLinQDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertAccountType(AccountType instance);
    partial void UpdateAccountType(AccountType instance);
    partial void DeleteAccountType(AccountType instance);
    #endregion
		
		public AccountLinQDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ACCOUNT_LINQConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AccountLinQDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AccountLinQDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AccountLinQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AccountLinQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<AccountType> AccountTypes
		{
			get
			{
				return this.GetTable<AccountType>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ACCOUNTID;
		
		private string _NAME;
		
		private string _PASSWORLD;
		
		private int _ACCOUNTTYPE;
		
		private EntityRef<AccountType> _AccountType1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnACCOUNTIDChanging(string value);
    partial void OnACCOUNTIDChanged();
    partial void OnNAMEChanging(string value);
    partial void OnNAMEChanged();
    partial void OnPASSWORLDChanging(string value);
    partial void OnPASSWORLDChanged();
    partial void OnACCOUNTTYPEChanging(int value);
    partial void OnACCOUNTTYPEChanged();
    #endregion
		
		public Account()
		{
			this._AccountType1 = default(EntityRef<AccountType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ACCOUNTID", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ACCOUNTID
		{
			get
			{
				return this._ACCOUNTID;
			}
			set
			{
				if ((this._ACCOUNTID != value))
				{
					this.OnACCOUNTIDChanging(value);
					this.SendPropertyChanging();
					this._ACCOUNTID = value;
					this.SendPropertyChanged("ACCOUNTID");
					this.OnACCOUNTIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAME", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string NAME
		{
			get
			{
				return this._NAME;
			}
			set
			{
				if ((this._NAME != value))
				{
					this.OnNAMEChanging(value);
					this.SendPropertyChanging();
					this._NAME = value;
					this.SendPropertyChanged("NAME");
					this.OnNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PASSWORLD", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string PASSWORLD
		{
			get
			{
				return this._PASSWORLD;
			}
			set
			{
				if ((this._PASSWORLD != value))
				{
					this.OnPASSWORLDChanging(value);
					this.SendPropertyChanging();
					this._PASSWORLD = value;
					this.SendPropertyChanged("PASSWORLD");
					this.OnPASSWORLDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ACCOUNTTYPE", DbType="Int NOT NULL")]
		public int ACCOUNTTYPE
		{
			get
			{
				return this._ACCOUNTTYPE;
			}
			set
			{
				if ((this._ACCOUNTTYPE != value))
				{
					if (this._AccountType1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnACCOUNTTYPEChanging(value);
					this.SendPropertyChanging();
					this._ACCOUNTTYPE = value;
					this.SendPropertyChanged("ACCOUNTTYPE");
					this.OnACCOUNTTYPEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AccountType_Account", Storage="_AccountType1", ThisKey="ACCOUNTTYPE", OtherKey="ACCOUNTTYPE1", IsForeignKey=true)]
		public AccountType AccountType1
		{
			get
			{
				return this._AccountType1.Entity;
			}
			set
			{
				AccountType previousValue = this._AccountType1.Entity;
				if (((previousValue != value) 
							|| (this._AccountType1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AccountType1.Entity = null;
						previousValue.Accounts.Remove(this);
					}
					this._AccountType1.Entity = value;
					if ((value != null))
					{
						value.Accounts.Add(this);
						this._ACCOUNTTYPE = value.ACCOUNTTYPE1;
					}
					else
					{
						this._ACCOUNTTYPE = default(int);
					}
					this.SendPropertyChanged("AccountType1");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AccountType")]
	public partial class AccountType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ACCOUNTTYPE1;
		
		private string _TYPENAMENAME;
		
		private string _TYPEDESCRIPTION;
		
		private EntitySet<Account> _Accounts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnACCOUNTTYPE1Changing(int value);
    partial void OnACCOUNTTYPE1Changed();
    partial void OnTYPENAMENAMEChanging(string value);
    partial void OnTYPENAMENAMEChanged();
    partial void OnTYPEDESCRIPTIONChanging(string value);
    partial void OnTYPEDESCRIPTIONChanged();
    #endregion
		
		public AccountType()
		{
			this._Accounts = new EntitySet<Account>(new Action<Account>(this.attach_Accounts), new Action<Account>(this.detach_Accounts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="ACCOUNTTYPE", Storage="_ACCOUNTTYPE1", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ACCOUNTTYPE1
		{
			get
			{
				return this._ACCOUNTTYPE1;
			}
			set
			{
				if ((this._ACCOUNTTYPE1 != value))
				{
					this.OnACCOUNTTYPE1Changing(value);
					this.SendPropertyChanging();
					this._ACCOUNTTYPE1 = value;
					this.SendPropertyChanged("ACCOUNTTYPE1");
					this.OnACCOUNTTYPE1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TYPENAMENAME", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string TYPENAMENAME
		{
			get
			{
				return this._TYPENAMENAME;
			}
			set
			{
				if ((this._TYPENAMENAME != value))
				{
					this.OnTYPENAMENAMEChanging(value);
					this.SendPropertyChanging();
					this._TYPENAMENAME = value;
					this.SendPropertyChanged("TYPENAMENAME");
					this.OnTYPENAMENAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TYPEDESCRIPTION", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string TYPEDESCRIPTION
		{
			get
			{
				return this._TYPEDESCRIPTION;
			}
			set
			{
				if ((this._TYPEDESCRIPTION != value))
				{
					this.OnTYPEDESCRIPTIONChanging(value);
					this.SendPropertyChanging();
					this._TYPEDESCRIPTION = value;
					this.SendPropertyChanged("TYPEDESCRIPTION");
					this.OnTYPEDESCRIPTIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AccountType_Account", Storage="_Accounts", ThisKey="ACCOUNTTYPE1", OtherKey="ACCOUNTTYPE")]
		public EntitySet<Account> Accounts
		{
			get
			{
				return this._Accounts;
			}
			set
			{
				this._Accounts.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Accounts(Account entity)
		{
			this.SendPropertyChanging();
			entity.AccountType1 = this;
		}
		
		private void detach_Accounts(Account entity)
		{
			this.SendPropertyChanging();
			entity.AccountType1 = null;
		}
	}
}
#pragma warning restore 1591
