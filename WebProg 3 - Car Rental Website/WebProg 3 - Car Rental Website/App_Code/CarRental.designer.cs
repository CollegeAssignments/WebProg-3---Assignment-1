﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="mainDatabase")]
public partial class CarRentalDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertBookingLink(BookingLink instance);
  partial void UpdateBookingLink(BookingLink instance);
  partial void DeleteBookingLink(BookingLink instance);
  partial void InsertUserLink(UserLink instance);
  partial void UpdateUserLink(UserLink instance);
  partial void DeleteUserLink(UserLink instance);
  partial void InsertDealLink(DealLink instance);
  partial void UpdateDealLink(DealLink instance);
  partial void DeleteDealLink(DealLink instance);
  #endregion
	
	public CarRentalDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["mainDatabaseConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public CarRentalDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CarRentalDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CarRentalDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CarRentalDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<BookingLink> BookingLinks
	{
		get
		{
			return this.GetTable<BookingLink>();
		}
	}
	
	public System.Data.Linq.Table<UserLink> UserLinks
	{
		get
		{
			return this.GetTable<UserLink>();
		}
	}
	
	public System.Data.Linq.Table<DealLink> DealLinks
	{
		get
		{
			return this.GetTable<DealLink>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bookings")]
public partial class BookingLink : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _BookingID;
	
	private System.Nullable<int> _UserID;
	
	private System.Nullable<System.DateTime> _StartDate;
	
	private System.Nullable<System.DateTime> _EndDate;
	
	private System.Nullable<int> _CarID;
	
	private System.Nullable<int> _DealID;
	
	private bool _IsPaid;
	
	private decimal _Price;
	
	private System.Guid _BookingKey;
	
	private EntityRef<UserLink> _UserLink;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBookingIDChanging(int value);
    partial void OnBookingIDChanged();
    partial void OnUserIDChanging(System.Nullable<int> value);
    partial void OnUserIDChanged();
    partial void OnStartDateChanging(System.Nullable<System.DateTime> value);
    partial void OnStartDateChanged();
    partial void OnEndDateChanging(System.Nullable<System.DateTime> value);
    partial void OnEndDateChanged();
    partial void OnCarIDChanging(System.Nullable<int> value);
    partial void OnCarIDChanged();
    partial void OnDealIDChanging(System.Nullable<int> value);
    partial void OnDealIDChanged();
    partial void OnIsPaidChanging(bool value);
    partial void OnIsPaidChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnBookingKeyChanging(System.Guid value);
    partial void OnBookingKeyChanged();
    #endregion
	
	public BookingLink()
	{
		this._UserLink = default(EntityRef<UserLink>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookingID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int BookingID
	{
		get
		{
			return this._BookingID;
		}
		set
		{
			if ((this._BookingID != value))
			{
				this.OnBookingIDChanging(value);
				this.SendPropertyChanging();
				this._BookingID = value;
				this.SendPropertyChanged("BookingID");
				this.OnBookingIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
	public System.Nullable<int> UserID
	{
		get
		{
			return this._UserID;
		}
		set
		{
			if ((this._UserID != value))
			{
				if (this._UserLink.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUserIDChanging(value);
				this.SendPropertyChanging();
				this._UserID = value;
				this.SendPropertyChanged("UserID");
				this.OnUserIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDate", DbType="Date")]
	public System.Nullable<System.DateTime> StartDate
	{
		get
		{
			return this._StartDate;
		}
		set
		{
			if ((this._StartDate != value))
			{
				this.OnStartDateChanging(value);
				this.SendPropertyChanging();
				this._StartDate = value;
				this.SendPropertyChanged("StartDate");
				this.OnStartDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="Date")]
	public System.Nullable<System.DateTime> EndDate
	{
		get
		{
			return this._EndDate;
		}
		set
		{
			if ((this._EndDate != value))
			{
				this.OnEndDateChanging(value);
				this.SendPropertyChanging();
				this._EndDate = value;
				this.SendPropertyChanged("EndDate");
				this.OnEndDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarID", DbType="Int")]
	public System.Nullable<int> CarID
	{
		get
		{
			return this._CarID;
		}
		set
		{
			if ((this._CarID != value))
			{
				this.OnCarIDChanging(value);
				this.SendPropertyChanging();
				this._CarID = value;
				this.SendPropertyChanged("CarID");
				this.OnCarIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DealID", DbType="Int")]
	public System.Nullable<int> DealID
	{
		get
		{
			return this._DealID;
		}
		set
		{
			if ((this._DealID != value))
			{
				this.OnDealIDChanging(value);
				this.SendPropertyChanging();
				this._DealID = value;
				this.SendPropertyChanged("DealID");
				this.OnDealIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsPaid", DbType="Bit NOT NULL")]
	public bool IsPaid
	{
		get
		{
			return this._IsPaid;
		}
		set
		{
			if ((this._IsPaid != value))
			{
				this.OnIsPaidChanging(value);
				this.SendPropertyChanging();
				this._IsPaid = value;
				this.SendPropertyChanged("IsPaid");
				this.OnIsPaidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="SmallMoney NOT NULL")]
	public decimal Price
	{
		get
		{
			return this._Price;
		}
		set
		{
			if ((this._Price != value))
			{
				this.OnPriceChanging(value);
				this.SendPropertyChanging();
				this._Price = value;
				this.SendPropertyChanged("Price");
				this.OnPriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookingKey", DbType="UniqueIdentifier NOT NULL")]
	public System.Guid BookingKey
	{
		get
		{
			return this._BookingKey;
		}
		set
		{
			if ((this._BookingKey != value))
			{
				this.OnBookingKeyChanging(value);
				this.SendPropertyChanging();
				this._BookingKey = value;
				this.SendPropertyChanged("BookingKey");
				this.OnBookingKeyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserLink_BookingLink", Storage="_UserLink", ThisKey="UserID", OtherKey="UserID", IsForeignKey=true)]
	public UserLink UserLink
	{
		get
		{
			return this._UserLink.Entity;
		}
		set
		{
			UserLink previousValue = this._UserLink.Entity;
			if (((previousValue != value) 
						|| (this._UserLink.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._UserLink.Entity = null;
					previousValue.BookingLinks.Remove(this);
				}
				this._UserLink.Entity = value;
				if ((value != null))
				{
					value.BookingLinks.Add(this);
					this._UserID = value.UserID;
				}
				else
				{
					this._UserID = default(Nullable<int>);
				}
				this.SendPropertyChanged("UserLink");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
public partial class UserLink : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _UserID;
	
	private string _UserName;
	
	private string _FName;
	
	private string _LName;
	
	private string _Address;
	
	private System.Nullable<System.DateTime> _DOB;
	
	private string _Email;
	
	private string _Phone;
	
	private System.Nullable<short> _UserType;
	
	private string _Password;
	
	private System.Nullable<System.DateTime> _DateReg;
	
	private string _LicenseNum;
	
	private EntitySet<BookingLink> _BookingLinks;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnFNameChanging(string value);
    partial void OnFNameChanged();
    partial void OnLNameChanging(string value);
    partial void OnLNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnDOBChanging(System.Nullable<System.DateTime> value);
    partial void OnDOBChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnUserTypeChanging(System.Nullable<short> value);
    partial void OnUserTypeChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnDateRegChanging(System.Nullable<System.DateTime> value);
    partial void OnDateRegChanged();
    partial void OnLicenseNumChanging(string value);
    partial void OnLicenseNumChanged();
    #endregion
	
	public UserLink()
	{
		this._BookingLinks = new EntitySet<BookingLink>(new Action<BookingLink>(this.attach_BookingLinks), new Action<BookingLink>(this.detach_BookingLinks));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int UserID
	{
		get
		{
			return this._UserID;
		}
		set
		{
			if ((this._UserID != value))
			{
				this.OnUserIDChanging(value);
				this.SendPropertyChanging();
				this._UserID = value;
				this.SendPropertyChanged("UserID");
				this.OnUserIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NChar(30)")]
	public string UserName
	{
		get
		{
			return this._UserName;
		}
		set
		{
			if ((this._UserName != value))
			{
				this.OnUserNameChanging(value);
				this.SendPropertyChanging();
				this._UserName = value;
				this.SendPropertyChanged("UserName");
				this.OnUserNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FName", DbType="NChar(20)")]
	public string FName
	{
		get
		{
			return this._FName;
		}
		set
		{
			if ((this._FName != value))
			{
				this.OnFNameChanging(value);
				this.SendPropertyChanging();
				this._FName = value;
				this.SendPropertyChanged("FName");
				this.OnFNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LName", DbType="NChar(20)")]
	public string LName
	{
		get
		{
			return this._LName;
		}
		set
		{
			if ((this._LName != value))
			{
				this.OnLNameChanging(value);
				this.SendPropertyChanging();
				this._LName = value;
				this.SendPropertyChanged("LName");
				this.OnLNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NChar(50)")]
	public string Address
	{
		get
		{
			return this._Address;
		}
		set
		{
			if ((this._Address != value))
			{
				this.OnAddressChanging(value);
				this.SendPropertyChanging();
				this._Address = value;
				this.SendPropertyChanged("Address");
				this.OnAddressChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="Date")]
	public System.Nullable<System.DateTime> DOB
	{
		get
		{
			return this._DOB;
		}
		set
		{
			if ((this._DOB != value))
			{
				this.OnDOBChanging(value);
				this.SendPropertyChanging();
				this._DOB = value;
				this.SendPropertyChanged("DOB");
				this.OnDOBChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NChar(30)")]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NChar(15)")]
	public string Phone
	{
		get
		{
			return this._Phone;
		}
		set
		{
			if ((this._Phone != value))
			{
				this.OnPhoneChanging(value);
				this.SendPropertyChanging();
				this._Phone = value;
				this.SendPropertyChanged("Phone");
				this.OnPhoneChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="SmallInt")]
	public System.Nullable<short> UserType
	{
		get
		{
			return this._UserType;
		}
		set
		{
			if ((this._UserType != value))
			{
				this.OnUserTypeChanging(value);
				this.SendPropertyChanging();
				this._UserType = value;
				this.SendPropertyChanged("UserType");
				this.OnUserTypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="Char(32)")]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateReg", DbType="Date")]
	public System.Nullable<System.DateTime> DateReg
	{
		get
		{
			return this._DateReg;
		}
		set
		{
			if ((this._DateReg != value))
			{
				this.OnDateRegChanging(value);
				this.SendPropertyChanging();
				this._DateReg = value;
				this.SendPropertyChanged("DateReg");
				this.OnDateRegChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LicenseNum", DbType="Char(20)")]
	public string LicenseNum
	{
		get
		{
			return this._LicenseNum;
		}
		set
		{
			if ((this._LicenseNum != value))
			{
				this.OnLicenseNumChanging(value);
				this.SendPropertyChanging();
				this._LicenseNum = value;
				this.SendPropertyChanged("LicenseNum");
				this.OnLicenseNumChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserLink_BookingLink", Storage="_BookingLinks", ThisKey="UserID", OtherKey="UserID")]
	public EntitySet<BookingLink> BookingLinks
	{
		get
		{
			return this._BookingLinks;
		}
		set
		{
			this._BookingLinks.Assign(value);
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
	
	private void attach_BookingLinks(BookingLink entity)
	{
		this.SendPropertyChanging();
		entity.UserLink = this;
	}
	
	private void detach_BookingLinks(BookingLink entity)
	{
		this.SendPropertyChanging();
		entity.UserLink = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Deals")]
public partial class DealLink : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _DealId;
	
	private string _DealName;
	
	private string _DealDesc;
	
	private int _Discount;
	
	private string _DealImage;
	
	private System.Guid _DealKey;
	
	private System.Nullable<int> _LimitedDealCounter;
	
	private System.Nullable<int> _MinDays;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDealIdChanging(int value);
    partial void OnDealIdChanged();
    partial void OnDealNameChanging(string value);
    partial void OnDealNameChanged();
    partial void OnDealDescChanging(string value);
    partial void OnDealDescChanged();
    partial void OnDiscountChanging(int value);
    partial void OnDiscountChanged();
    partial void OnDealImageChanging(string value);
    partial void OnDealImageChanged();
    partial void OnDealKeyChanging(System.Guid value);
    partial void OnDealKeyChanged();
    partial void OnLimitedDealCounterChanging(System.Nullable<int> value);
    partial void OnLimitedDealCounterChanged();
    partial void OnMinDaysChanging(System.Nullable<int> value);
    partial void OnMinDaysChanged();
    #endregion
	
	public DealLink()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DealId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int DealId
	{
		get
		{
			return this._DealId;
		}
		set
		{
			if ((this._DealId != value))
			{
				this.OnDealIdChanging(value);
				this.SendPropertyChanging();
				this._DealId = value;
				this.SendPropertyChanged("DealId");
				this.OnDealIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DealName", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
	public string DealName
	{
		get
		{
			return this._DealName;
		}
		set
		{
			if ((this._DealName != value))
			{
				this.OnDealNameChanging(value);
				this.SendPropertyChanging();
				this._DealName = value;
				this.SendPropertyChanged("DealName");
				this.OnDealNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DealDesc", DbType="NChar(10)")]
	public string DealDesc
	{
		get
		{
			return this._DealDesc;
		}
		set
		{
			if ((this._DealDesc != value))
			{
				this.OnDealDescChanging(value);
				this.SendPropertyChanging();
				this._DealDesc = value;
				this.SendPropertyChanged("DealDesc");
				this.OnDealDescChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Discount", DbType="Int NOT NULL")]
	public int Discount
	{
		get
		{
			return this._Discount;
		}
		set
		{
			if ((this._Discount != value))
			{
				this.OnDiscountChanging(value);
				this.SendPropertyChanging();
				this._Discount = value;
				this.SendPropertyChanged("Discount");
				this.OnDiscountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DealImage", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
	public string DealImage
	{
		get
		{
			return this._DealImage;
		}
		set
		{
			if ((this._DealImage != value))
			{
				this.OnDealImageChanging(value);
				this.SendPropertyChanging();
				this._DealImage = value;
				this.SendPropertyChanged("DealImage");
				this.OnDealImageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DealKey", DbType="UniqueIdentifier NOT NULL")]
	public System.Guid DealKey
	{
		get
		{
			return this._DealKey;
		}
		set
		{
			if ((this._DealKey != value))
			{
				this.OnDealKeyChanging(value);
				this.SendPropertyChanging();
				this._DealKey = value;
				this.SendPropertyChanged("DealKey");
				this.OnDealKeyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LimitedDealCounter", DbType="Int")]
	public System.Nullable<int> LimitedDealCounter
	{
		get
		{
			return this._LimitedDealCounter;
		}
		set
		{
			if ((this._LimitedDealCounter != value))
			{
				this.OnLimitedDealCounterChanging(value);
				this.SendPropertyChanging();
				this._LimitedDealCounter = value;
				this.SendPropertyChanged("LimitedDealCounter");
				this.OnLimitedDealCounterChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinDays", DbType="Int")]
	public System.Nullable<int> MinDays
	{
		get
		{
			return this._MinDays;
		}
		set
		{
			if ((this._MinDays != value))
			{
				this.OnMinDaysChanging(value);
				this.SendPropertyChanging();
				this._MinDays = value;
				this.SendPropertyChanged("MinDays");
				this.OnMinDaysChanged();
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
#pragma warning restore 1591
