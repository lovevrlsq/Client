﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18051
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.Model
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CnLotteryDbs")]
	public partial class MainDatadbmlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertUserInfo(UserInfo instance);
    partial void UpdateUserInfo(UserInfo instance);
    partial void DeleteUserInfo(UserInfo instance);
    #endregion
		
		public MainDatadbmlDataContext() : 
				base(global::Client.Model.Properties.Settings.Default.CnLotteryDbsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MainDatadbmlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MainDatadbmlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MainDatadbmlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MainDatadbmlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<UserInfo> UserInfo
		{
			get
			{
				return this.GetTable<UserInfo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserInfo")]
	public partial class UserInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _UserID;
		
		private string _UserPwd;
		
		private string _ParentUID;
		
		private System.DateTime _RegTime;
		
		private System.Nullable<int> _IsOnline;
		
		private System.Nullable<System.DateTime> _LastLoginTime;
		
		private int _IsActive;
		
		private double _Bonus;
		
		private string _FullPath;
		
		private System.Nullable<int> _RoleID;
		
		private string _CarrierBankCardNo;
		
		private string _Email;
		
		private string _MobilePhoneNum;
		
		private string _Name;
		
		private System.Nullable<double> _BonusToParent;
		
		private string _QQ;
		
		private int _Level;
		
		private int _Status;
		
		private int _CanMoneyToLower;
		
		private int _FreezingLevel;
		
		private double _RiseBonus;
		
		private System.Nullable<System.DateTime> _UpdateTime;
		
		private System.Nullable<int> _RankID;
		
		private string _Nickname;
		
		private System.Nullable<System.DateTime> _LastUpRankTime;
		
		private int _IsRankEnable;
		
		private System.Nullable<double> _MaxBonus;
		
		private double _DishScore;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnUserPwdChanging(string value);
    partial void OnUserPwdChanged();
    partial void OnParentUIDChanging(string value);
    partial void OnParentUIDChanged();
    partial void OnRegTimeChanging(System.DateTime value);
    partial void OnRegTimeChanged();
    partial void OnIsOnlineChanging(System.Nullable<int> value);
    partial void OnIsOnlineChanged();
    partial void OnLastLoginTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnLastLoginTimeChanged();
    partial void OnIsActiveChanging(int value);
    partial void OnIsActiveChanged();
    partial void OnBonusChanging(double value);
    partial void OnBonusChanged();
    partial void OnFullPathChanging(string value);
    partial void OnFullPathChanged();
    partial void OnRoleIDChanging(System.Nullable<int> value);
    partial void OnRoleIDChanged();
    partial void OnCarrierBankCardNoChanging(string value);
    partial void OnCarrierBankCardNoChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnMobilePhoneNumChanging(string value);
    partial void OnMobilePhoneNumChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnBonusToParentChanging(System.Nullable<double> value);
    partial void OnBonusToParentChanged();
    partial void OnQQChanging(string value);
    partial void OnQQChanged();
    partial void OnLevelChanging(int value);
    partial void OnLevelChanged();
    partial void OnStatusChanging(int value);
    partial void OnStatusChanged();
    partial void OnCanMoneyToLowerChanging(int value);
    partial void OnCanMoneyToLowerChanged();
    partial void OnFreezingLevelChanging(int value);
    partial void OnFreezingLevelChanged();
    partial void OnRiseBonusChanging(double value);
    partial void OnRiseBonusChanged();
    partial void OnUpdateTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdateTimeChanged();
    partial void OnRankIDChanging(System.Nullable<int> value);
    partial void OnRankIDChanged();
    partial void OnNicknameChanging(string value);
    partial void OnNicknameChanged();
    partial void OnLastUpRankTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnLastUpRankTimeChanged();
    partial void OnIsRankEnableChanging(int value);
    partial void OnIsRankEnableChanged();
    partial void OnMaxBonusChanging(System.Nullable<double> value);
    partial void OnMaxBonusChanged();
    partial void OnDishScoreChanging(double value);
    partial void OnDishScoreChanged();
    #endregion
		
		public UserInfo()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string UserID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPwd", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string UserPwd
		{
			get
			{
				return this._UserPwd;
			}
			set
			{
				if ((this._UserPwd != value))
				{
					this.OnUserPwdChanging(value);
					this.SendPropertyChanging();
					this._UserPwd = value;
					this.SendPropertyChanged("UserPwd");
					this.OnUserPwdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentUID", DbType="NVarChar(20)")]
		public string ParentUID
		{
			get
			{
				return this._ParentUID;
			}
			set
			{
				if ((this._ParentUID != value))
				{
					this.OnParentUIDChanging(value);
					this.SendPropertyChanging();
					this._ParentUID = value;
					this.SendPropertyChanged("ParentUID");
					this.OnParentUIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegTime", DbType="DateTime NOT NULL")]
		public System.DateTime RegTime
		{
			get
			{
				return this._RegTime;
			}
			set
			{
				if ((this._RegTime != value))
				{
					this.OnRegTimeChanging(value);
					this.SendPropertyChanging();
					this._RegTime = value;
					this.SendPropertyChanged("RegTime");
					this.OnRegTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsOnline", DbType="Int")]
		public System.Nullable<int> IsOnline
		{
			get
			{
				return this._IsOnline;
			}
			set
			{
				if ((this._IsOnline != value))
				{
					this.OnIsOnlineChanging(value);
					this.SendPropertyChanging();
					this._IsOnline = value;
					this.SendPropertyChanged("IsOnline");
					this.OnIsOnlineChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastLoginTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastLoginTime
		{
			get
			{
				return this._LastLoginTime;
			}
			set
			{
				if ((this._LastLoginTime != value))
				{
					this.OnLastLoginTimeChanging(value);
					this.SendPropertyChanging();
					this._LastLoginTime = value;
					this.SendPropertyChanged("LastLoginTime");
					this.OnLastLoginTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Int NOT NULL")]
		public int IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bonus", DbType="Float NOT NULL")]
		public double Bonus
		{
			get
			{
				return this._Bonus;
			}
			set
			{
				if ((this._Bonus != value))
				{
					this.OnBonusChanging(value);
					this.SendPropertyChanging();
					this._Bonus = value;
					this.SendPropertyChanged("Bonus");
					this.OnBonusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullPath", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string FullPath
		{
			get
			{
				return this._FullPath;
			}
			set
			{
				if ((this._FullPath != value))
				{
					this.OnFullPathChanging(value);
					this.SendPropertyChanging();
					this._FullPath = value;
					this.SendPropertyChanged("FullPath");
					this.OnFullPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleID", DbType="Int")]
		public System.Nullable<int> RoleID
		{
			get
			{
				return this._RoleID;
			}
			set
			{
				if ((this._RoleID != value))
				{
					this.OnRoleIDChanging(value);
					this.SendPropertyChanging();
					this._RoleID = value;
					this.SendPropertyChanged("RoleID");
					this.OnRoleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarrierBankCardNo", DbType="NVarChar(30)")]
		public string CarrierBankCardNo
		{
			get
			{
				return this._CarrierBankCardNo;
			}
			set
			{
				if ((this._CarrierBankCardNo != value))
				{
					this.OnCarrierBankCardNoChanging(value);
					this.SendPropertyChanging();
					this._CarrierBankCardNo = value;
					this.SendPropertyChanged("CarrierBankCardNo");
					this.OnCarrierBankCardNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(100)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MobilePhoneNum", DbType="NVarChar(20)")]
		public string MobilePhoneNum
		{
			get
			{
				return this._MobilePhoneNum;
			}
			set
			{
				if ((this._MobilePhoneNum != value))
				{
					this.OnMobilePhoneNumChanging(value);
					this.SendPropertyChanging();
					this._MobilePhoneNum = value;
					this.SendPropertyChanged("MobilePhoneNum");
					this.OnMobilePhoneNumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BonusToParent", DbType="Float")]
		public System.Nullable<double> BonusToParent
		{
			get
			{
				return this._BonusToParent;
			}
			set
			{
				if ((this._BonusToParent != value))
				{
					this.OnBonusToParentChanging(value);
					this.SendPropertyChanging();
					this._BonusToParent = value;
					this.SendPropertyChanged("BonusToParent");
					this.OnBonusToParentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QQ", DbType="NVarChar(20)")]
		public string QQ
		{
			get
			{
				return this._QQ;
			}
			set
			{
				if ((this._QQ != value))
				{
					this.OnQQChanging(value);
					this.SendPropertyChanging();
					this._QQ = value;
					this.SendPropertyChanged("QQ");
					this.OnQQChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Level]", Storage="_Level", DbType="Int NOT NULL")]
		public int Level
		{
			get
			{
				return this._Level;
			}
			set
			{
				if ((this._Level != value))
				{
					this.OnLevelChanging(value);
					this.SendPropertyChanging();
					this._Level = value;
					this.SendPropertyChanged("Level");
					this.OnLevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int NOT NULL")]
		public int Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CanMoneyToLower", DbType="Int NOT NULL")]
		public int CanMoneyToLower
		{
			get
			{
				return this._CanMoneyToLower;
			}
			set
			{
				if ((this._CanMoneyToLower != value))
				{
					this.OnCanMoneyToLowerChanging(value);
					this.SendPropertyChanging();
					this._CanMoneyToLower = value;
					this.SendPropertyChanged("CanMoneyToLower");
					this.OnCanMoneyToLowerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FreezingLevel", DbType="Int NOT NULL")]
		public int FreezingLevel
		{
			get
			{
				return this._FreezingLevel;
			}
			set
			{
				if ((this._FreezingLevel != value))
				{
					this.OnFreezingLevelChanging(value);
					this.SendPropertyChanging();
					this._FreezingLevel = value;
					this.SendPropertyChanged("FreezingLevel");
					this.OnFreezingLevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RiseBonus", DbType="Float NOT NULL")]
		public double RiseBonus
		{
			get
			{
				return this._RiseBonus;
			}
			set
			{
				if ((this._RiseBonus != value))
				{
					this.OnRiseBonusChanging(value);
					this.SendPropertyChanging();
					this._RiseBonus = value;
					this.SendPropertyChanged("RiseBonus");
					this.OnRiseBonusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdateTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> UpdateTime
		{
			get
			{
				return this._UpdateTime;
			}
			set
			{
				if ((this._UpdateTime != value))
				{
					this.OnUpdateTimeChanging(value);
					this.SendPropertyChanging();
					this._UpdateTime = value;
					this.SendPropertyChanged("UpdateTime");
					this.OnUpdateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RankID", DbType="Int")]
		public System.Nullable<int> RankID
		{
			get
			{
				return this._RankID;
			}
			set
			{
				if ((this._RankID != value))
				{
					this.OnRankIDChanging(value);
					this.SendPropertyChanging();
					this._RankID = value;
					this.SendPropertyChanged("RankID");
					this.OnRankIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nickname", DbType="NVarChar(20)")]
		public string Nickname
		{
			get
			{
				return this._Nickname;
			}
			set
			{
				if ((this._Nickname != value))
				{
					this.OnNicknameChanging(value);
					this.SendPropertyChanging();
					this._Nickname = value;
					this.SendPropertyChanged("Nickname");
					this.OnNicknameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastUpRankTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastUpRankTime
		{
			get
			{
				return this._LastUpRankTime;
			}
			set
			{
				if ((this._LastUpRankTime != value))
				{
					this.OnLastUpRankTimeChanging(value);
					this.SendPropertyChanging();
					this._LastUpRankTime = value;
					this.SendPropertyChanged("LastUpRankTime");
					this.OnLastUpRankTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsRankEnable", DbType="Int NOT NULL")]
		public int IsRankEnable
		{
			get
			{
				return this._IsRankEnable;
			}
			set
			{
				if ((this._IsRankEnable != value))
				{
					this.OnIsRankEnableChanging(value);
					this.SendPropertyChanging();
					this._IsRankEnable = value;
					this.SendPropertyChanged("IsRankEnable");
					this.OnIsRankEnableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaxBonus", DbType="Float")]
		public System.Nullable<double> MaxBonus
		{
			get
			{
				return this._MaxBonus;
			}
			set
			{
				if ((this._MaxBonus != value))
				{
					this.OnMaxBonusChanging(value);
					this.SendPropertyChanging();
					this._MaxBonus = value;
					this.SendPropertyChanged("MaxBonus");
					this.OnMaxBonusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DishScore", DbType="Float NOT NULL")]
		public double DishScore
		{
			get
			{
				return this._DishScore;
			}
			set
			{
				if ((this._DishScore != value))
				{
					this.OnDishScoreChanging(value);
					this.SendPropertyChanging();
					this._DishScore = value;
					this.SendPropertyChanged("DishScore");
					this.OnDishScoreChanged();
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
