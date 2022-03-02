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

namespace DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PERSONNEL TRACKING")]
	public partial class EmlployeeDataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDEPARTMENT(DEPARTMENT instance);
    partial void UpdateDEPARTMENT(DEPARTMENT instance);
    partial void DeleteDEPARTMENT(DEPARTMENT instance);
    partial void InsertTASKSTATE(TASKSTATE instance);
    partial void UpdateTASKSTATE(TASKSTATE instance);
    partial void DeleteTASKSTATE(TASKSTATE instance);
    partial void InsertEMPLOYEE(EMPLOYEE instance);
    partial void UpdateEMPLOYEE(EMPLOYEE instance);
    partial void DeleteEMPLOYEE(EMPLOYEE instance);
    partial void InsertMONTH(MONTH instance);
    partial void UpdateMONTH(MONTH instance);
    partial void DeleteMONTH(MONTH instance);
    partial void InsertPERMISSION(PERMISSION instance);
    partial void UpdatePERMISSION(PERMISSION instance);
    partial void DeletePERMISSION(PERMISSION instance);
    partial void InsertPERMISSIONSTATE(PERMISSIONSTATE instance);
    partial void UpdatePERMISSIONSTATE(PERMISSIONSTATE instance);
    partial void DeletePERMISSIONSTATE(PERMISSIONSTATE instance);
    partial void InsertPOSITION(POSITION instance);
    partial void UpdatePOSITION(POSITION instance);
    partial void DeletePOSITION(POSITION instance);
    partial void InsertSALARY(SALARY instance);
    partial void UpdateSALARY(SALARY instance);
    partial void DeleteSALARY(SALARY instance);
    partial void InsertTASK(TASK instance);
    partial void UpdateTASK(TASK instance);
    partial void DeleteTASK(TASK instance);
    #endregion
		
		public EmlployeeDataClassDataContext() : 
				base(global::DAL.Properties.Settings.Default.PERSONNEL_TRACKINGConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EmlployeeDataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmlployeeDataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmlployeeDataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmlployeeDataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DEPARTMENT> DEPARTMENTs
		{
			get
			{
				return this.GetTable<DEPARTMENT>();
			}
		}
		
		public System.Data.Linq.Table<TASKSTATE> TASKSTATEs
		{
			get
			{
				return this.GetTable<TASKSTATE>();
			}
		}
		
		public System.Data.Linq.Table<EMPLOYEE> EMPLOYEEs
		{
			get
			{
				return this.GetTable<EMPLOYEE>();
			}
		}
		
		public System.Data.Linq.Table<MONTH> MONTHs
		{
			get
			{
				return this.GetTable<MONTH>();
			}
		}
		
		public System.Data.Linq.Table<PERMISSION> PERMISSIONs
		{
			get
			{
				return this.GetTable<PERMISSION>();
			}
		}
		
		public System.Data.Linq.Table<PERMISSIONSTATE> PERMISSIONSTATEs
		{
			get
			{
				return this.GetTable<PERMISSIONSTATE>();
			}
		}
		
		public System.Data.Linq.Table<POSITION> POSITIONs
		{
			get
			{
				return this.GetTable<POSITION>();
			}
		}
		
		public System.Data.Linq.Table<SALARY> SALARies
		{
			get
			{
				return this.GetTable<SALARY>();
			}
		}
		
		public System.Data.Linq.Table<TASK> TASKs
		{
			get
			{
				return this.GetTable<TASK>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DEPARTMENT")]
	public partial class DEPARTMENT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _DepartmentName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDepartmentNameChanging(string value);
    partial void OnDepartmentNameChanged();
    #endregion
		
		public DEPARTMENT()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DepartmentName
		{
			get
			{
				return this._DepartmentName;
			}
			set
			{
				if ((this._DepartmentName != value))
				{
					this.OnDepartmentNameChanging(value);
					this.SendPropertyChanging();
					this._DepartmentName = value;
					this.SendPropertyChanged("DepartmentName");
					this.OnDepartmentNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TASKSTATE")]
	public partial class TASKSTATE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _StateName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnStateNameChanging(string value);
    partial void OnStateNameChanged();
    #endregion
		
		public TASKSTATE()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string StateName
		{
			get
			{
				return this._StateName;
			}
			set
			{
				if ((this._StateName != value))
				{
					this.OnStateNameChanging(value);
					this.SendPropertyChanging();
					this._StateName = value;
					this.SendPropertyChanged("StateName");
					this.OnStateNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EMPLOYEE")]
	public partial class EMPLOYEE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _UserNo;
		
		private string _Name;
		
		private string _Surname;
		
		private string _ImagePath;
		
		private int _DepartmentID;
		
		private int _PositionID;
		
		private int _Salary;
		
		private System.Nullable<System.DateTime> _Birthday;
		
		private string _Address;
		
		private string _Password;
		
		private System.Nullable<bool> _isAdmin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUserNoChanging(int value);
    partial void OnUserNoChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnImagePathChanging(string value);
    partial void OnImagePathChanged();
    partial void OnDepartmentIDChanging(int value);
    partial void OnDepartmentIDChanged();
    partial void OnPositionIDChanging(int value);
    partial void OnPositionIDChanged();
    partial void OnSalaryChanging(int value);
    partial void OnSalaryChanged();
    partial void OnBirthdayChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthdayChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnisAdminChanging(System.Nullable<bool> value);
    partial void OnisAdminChanged();
    #endregion
		
		public EMPLOYEE()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserNo", DbType="Int NOT NULL")]
		public int UserNo
		{
			get
			{
				return this._UserNo;
			}
			set
			{
				if ((this._UserNo != value))
				{
					this.OnUserNoChanging(value);
					this.SendPropertyChanging();
					this._UserNo = value;
					this.SendPropertyChanged("UserNo");
					this.OnUserNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImagePath", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ImagePath
		{
			get
			{
				return this._ImagePath;
			}
			set
			{
				if ((this._ImagePath != value))
				{
					this.OnImagePathChanging(value);
					this.SendPropertyChanging();
					this._ImagePath = value;
					this.SendPropertyChanged("ImagePath");
					this.OnImagePathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentID", DbType="Int NOT NULL")]
		public int DepartmentID
		{
			get
			{
				return this._DepartmentID;
			}
			set
			{
				if ((this._DepartmentID != value))
				{
					this.OnDepartmentIDChanging(value);
					this.SendPropertyChanging();
					this._DepartmentID = value;
					this.SendPropertyChanged("DepartmentID");
					this.OnDepartmentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionID", DbType="Int NOT NULL")]
		public int PositionID
		{
			get
			{
				return this._PositionID;
			}
			set
			{
				if ((this._PositionID != value))
				{
					this.OnPositionIDChanging(value);
					this.SendPropertyChanging();
					this._PositionID = value;
					this.SendPropertyChanged("PositionID");
					this.OnPositionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Int NOT NULL")]
		public int Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthday", DbType="Date")]
		public System.Nullable<System.DateTime> Birthday
		{
			get
			{
				return this._Birthday;
			}
			set
			{
				if ((this._Birthday != value))
				{
					this.OnBirthdayChanging(value);
					this.SendPropertyChanging();
					this._Birthday = value;
					this.SendPropertyChanged("Birthday");
					this.OnBirthdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(MAX)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isAdmin", DbType="Bit")]
		public System.Nullable<bool> isAdmin
		{
			get
			{
				return this._isAdmin;
			}
			set
			{
				if ((this._isAdmin != value))
				{
					this.OnisAdminChanging(value);
					this.SendPropertyChanging();
					this._isAdmin = value;
					this.SendPropertyChanged("isAdmin");
					this.OnisAdminChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MONTH")]
	public partial class MONTH : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _MonthName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMonthNameChanging(string value);
    partial void OnMonthNameChanged();
    #endregion
		
		public MONTH()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MonthName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string MonthName
		{
			get
			{
				return this._MonthName;
			}
			set
			{
				if ((this._MonthName != value))
				{
					this.OnMonthNameChanging(value);
					this.SendPropertyChanging();
					this._MonthName = value;
					this.SendPropertyChanged("MonthName");
					this.OnMonthNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PERMISSION")]
	public partial class PERMISSION : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _EmployeeID;
		
		private System.DateTime _PermissionStartDate;
		
		private System.DateTime _PermissionEndDate;
		
		private int _PermissionState;
		
		private string _PermissionExplanation;
		
		private int _PermissionDay;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnEmployeeIDChanging(int value);
    partial void OnEmployeeIDChanged();
    partial void OnPermissionStartDateChanging(System.DateTime value);
    partial void OnPermissionStartDateChanged();
    partial void OnPermissionEndDateChanging(System.DateTime value);
    partial void OnPermissionEndDateChanged();
    partial void OnPermissionStateChanging(int value);
    partial void OnPermissionStateChanged();
    partial void OnPermissionExplanationChanging(string value);
    partial void OnPermissionExplanationChanged();
    partial void OnPermissionDayChanging(int value);
    partial void OnPermissionDayChanged();
    #endregion
		
		public PERMISSION()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", DbType="Int NOT NULL")]
		public int EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PermissionStartDate", DbType="Date NOT NULL")]
		public System.DateTime PermissionStartDate
		{
			get
			{
				return this._PermissionStartDate;
			}
			set
			{
				if ((this._PermissionStartDate != value))
				{
					this.OnPermissionStartDateChanging(value);
					this.SendPropertyChanging();
					this._PermissionStartDate = value;
					this.SendPropertyChanged("PermissionStartDate");
					this.OnPermissionStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PermissionEndDate", DbType="Date NOT NULL")]
		public System.DateTime PermissionEndDate
		{
			get
			{
				return this._PermissionEndDate;
			}
			set
			{
				if ((this._PermissionEndDate != value))
				{
					this.OnPermissionEndDateChanging(value);
					this.SendPropertyChanging();
					this._PermissionEndDate = value;
					this.SendPropertyChanged("PermissionEndDate");
					this.OnPermissionEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PermissionState", DbType="Int NOT NULL")]
		public int PermissionState
		{
			get
			{
				return this._PermissionState;
			}
			set
			{
				if ((this._PermissionState != value))
				{
					this.OnPermissionStateChanging(value);
					this.SendPropertyChanging();
					this._PermissionState = value;
					this.SendPropertyChanged("PermissionState");
					this.OnPermissionStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PermissionExplanation", DbType="NVarChar(MAX)")]
		public string PermissionExplanation
		{
			get
			{
				return this._PermissionExplanation;
			}
			set
			{
				if ((this._PermissionExplanation != value))
				{
					this.OnPermissionExplanationChanging(value);
					this.SendPropertyChanging();
					this._PermissionExplanation = value;
					this.SendPropertyChanged("PermissionExplanation");
					this.OnPermissionExplanationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PermissionDay", DbType="Int NOT NULL")]
		public int PermissionDay
		{
			get
			{
				return this._PermissionDay;
			}
			set
			{
				if ((this._PermissionDay != value))
				{
					this.OnPermissionDayChanging(value);
					this.SendPropertyChanging();
					this._PermissionDay = value;
					this.SendPropertyChanged("PermissionDay");
					this.OnPermissionDayChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PERMISSIONSTATE")]
	public partial class PERMISSIONSTATE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _StateName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnStateNameChanging(string value);
    partial void OnStateNameChanged();
    #endregion
		
		public PERMISSIONSTATE()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string StateName
		{
			get
			{
				return this._StateName;
			}
			set
			{
				if ((this._StateName != value))
				{
					this.OnStateNameChanging(value);
					this.SendPropertyChanging();
					this._StateName = value;
					this.SendPropertyChanged("StateName");
					this.OnStateNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.POSITION")]
	public partial class POSITION : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _PositionName;
		
		private int _DepartmentID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnPositionNameChanging(string value);
    partial void OnPositionNameChanged();
    partial void OnDepartmentIDChanging(int value);
    partial void OnDepartmentIDChanged();
    #endregion
		
		public POSITION()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PositionName
		{
			get
			{
				return this._PositionName;
			}
			set
			{
				if ((this._PositionName != value))
				{
					this.OnPositionNameChanging(value);
					this.SendPropertyChanging();
					this._PositionName = value;
					this.SendPropertyChanged("PositionName");
					this.OnPositionNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentID", DbType="Int NOT NULL")]
		public int DepartmentID
		{
			get
			{
				return this._DepartmentID;
			}
			set
			{
				if ((this._DepartmentID != value))
				{
					this.OnDepartmentIDChanging(value);
					this.SendPropertyChanging();
					this._DepartmentID = value;
					this.SendPropertyChanged("DepartmentID");
					this.OnDepartmentIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SALARY")]
	public partial class SALARY : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _EmployeeID;
		
		private int _Amount;
		
		private int _Year;
		
		private int _MonthID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnEmployeeIDChanging(int value);
    partial void OnEmployeeIDChanged();
    partial void OnAmountChanging(int value);
    partial void OnAmountChanged();
    partial void OnYearChanging(int value);
    partial void OnYearChanged();
    partial void OnMonthIDChanging(int value);
    partial void OnMonthIDChanged();
    #endregion
		
		public SALARY()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", DbType="Int NOT NULL")]
		public int EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Int NOT NULL")]
		public int Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int NOT NULL")]
		public int Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MonthID", DbType="Int NOT NULL")]
		public int MonthID
		{
			get
			{
				return this._MonthID;
			}
			set
			{
				if ((this._MonthID != value))
				{
					this.OnMonthIDChanging(value);
					this.SendPropertyChanging();
					this._MonthID = value;
					this.SendPropertyChanged("MonthID");
					this.OnMonthIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TASK")]
	public partial class TASK : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _EmployeeID;
		
		private string _TaskTitle;
		
		private string _TaskContent;
		
		private System.Nullable<System.DateTime> _TaskStartDate;
		
		private System.Nullable<System.DateTime> _TaskDeliveryDate;
		
		private System.Nullable<int> _TaskState;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnEmployeeIDChanging(int value);
    partial void OnEmployeeIDChanged();
    partial void OnTaskTitleChanging(string value);
    partial void OnTaskTitleChanged();
    partial void OnTaskContentChanging(string value);
    partial void OnTaskContentChanged();
    partial void OnTaskStartDateChanging(System.Nullable<System.DateTime> value);
    partial void OnTaskStartDateChanged();
    partial void OnTaskDeliveryDateChanging(System.Nullable<System.DateTime> value);
    partial void OnTaskDeliveryDateChanged();
    partial void OnTaskStateChanging(System.Nullable<int> value);
    partial void OnTaskStateChanged();
    #endregion
		
		public TASK()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", DbType="Int NOT NULL")]
		public int EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskTitle", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TaskTitle
		{
			get
			{
				return this._TaskTitle;
			}
			set
			{
				if ((this._TaskTitle != value))
				{
					this.OnTaskTitleChanging(value);
					this.SendPropertyChanging();
					this._TaskTitle = value;
					this.SendPropertyChanged("TaskTitle");
					this.OnTaskTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskContent", DbType="VarChar(MAX)")]
		public string TaskContent
		{
			get
			{
				return this._TaskContent;
			}
			set
			{
				if ((this._TaskContent != value))
				{
					this.OnTaskContentChanging(value);
					this.SendPropertyChanging();
					this._TaskContent = value;
					this.SendPropertyChanged("TaskContent");
					this.OnTaskContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskStartDate", DbType="Date")]
		public System.Nullable<System.DateTime> TaskStartDate
		{
			get
			{
				return this._TaskStartDate;
			}
			set
			{
				if ((this._TaskStartDate != value))
				{
					this.OnTaskStartDateChanging(value);
					this.SendPropertyChanging();
					this._TaskStartDate = value;
					this.SendPropertyChanged("TaskStartDate");
					this.OnTaskStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskDeliveryDate", DbType="Date")]
		public System.Nullable<System.DateTime> TaskDeliveryDate
		{
			get
			{
				return this._TaskDeliveryDate;
			}
			set
			{
				if ((this._TaskDeliveryDate != value))
				{
					this.OnTaskDeliveryDateChanging(value);
					this.SendPropertyChanging();
					this._TaskDeliveryDate = value;
					this.SendPropertyChanged("TaskDeliveryDate");
					this.OnTaskDeliveryDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskState", DbType="Int")]
		public System.Nullable<int> TaskState
		{
			get
			{
				return this._TaskState;
			}
			set
			{
				if ((this._TaskState != value))
				{
					this.OnTaskStateChanging(value);
					this.SendPropertyChanging();
					this._TaskState = value;
					this.SendPropertyChanged("TaskState");
					this.OnTaskStateChanged();
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
}
#pragma warning restore 1591
