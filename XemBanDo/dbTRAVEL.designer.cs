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

namespace XemBanDo
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TRAVEL")]
	public partial class dbTRAVELDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTua(Tua instance);
    partial void UpdateTua(Tua instance);
    partial void DeleteTua(Tua instance);
    partial void InsertTheNap(TheNap instance);
    partial void UpdateTheNap(TheNap instance);
    partial void DeleteTheNap(TheNap instance);
    partial void InsertHoaDon(HoaDon instance);
    partial void UpdateHoaDon(HoaDon instance);
    partial void DeleteHoaDon(HoaDon instance);
    partial void InsertDanhMuc(DanhMuc instance);
    partial void UpdateDanhMuc(DanhMuc instance);
    partial void DeleteDanhMuc(DanhMuc instance);
    partial void InsertCountry(Country instance);
    partial void UpdateCountry(Country instance);
    partial void DeleteCountry(Country instance);
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    #endregion
		
		public dbTRAVELDataContext() : 
				base(global::XemBanDo.Properties.Settings.Default.TRAVELConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbTRAVELDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbTRAVELDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbTRAVELDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbTRAVELDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Tua> Tuas
		{
			get
			{
				return this.GetTable<Tua>();
			}
		}
		
		public System.Data.Linq.Table<TheNap> TheNaps
		{
			get
			{
				return this.GetTable<TheNap>();
			}
		}
		
		public System.Data.Linq.Table<HoaDon> HoaDons
		{
			get
			{
				return this.GetTable<HoaDon>();
			}
		}
		
		public System.Data.Linq.Table<DanhMuc> DanhMucs
		{
			get
			{
				return this.GetTable<DanhMuc>();
			}
		}
		
		public System.Data.Linq.Table<Country> Countries
		{
			get
			{
				return this.GetTable<Country>();
			}
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tua")]
	public partial class Tua : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TenTua;
		
		private int _DatNuoc;
		
		private int _IDDanhMuc;
		
		private decimal _Gia;
		
		private string _KhachSan;
		
		private System.DateTime _NgayDen;
		
		private System.DateTime _NgayDi;
		
		private int _DaDat;
		
		private string _MaTua;
		
		private EntitySet<HoaDon> _HoaDons;
		
		private EntityRef<DanhMuc> _DanhMuc;
		
		private EntityRef<Country> _Country;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTenTuaChanging(string value);
    partial void OnTenTuaChanged();
    partial void OnDatNuocChanging(int value);
    partial void OnDatNuocChanged();
    partial void OnIDDanhMucChanging(int value);
    partial void OnIDDanhMucChanged();
    partial void OnGiaChanging(decimal value);
    partial void OnGiaChanged();
    partial void OnKhachSanChanging(string value);
    partial void OnKhachSanChanged();
    partial void OnNgayDenChanging(System.DateTime value);
    partial void OnNgayDenChanged();
    partial void OnNgayDiChanging(System.DateTime value);
    partial void OnNgayDiChanged();
    partial void OnDaDatChanging(int value);
    partial void OnDaDatChanged();
    partial void OnMaTuaChanging(string value);
    partial void OnMaTuaChanged();
    #endregion
		
		public Tua()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			this._DanhMuc = default(EntityRef<DanhMuc>);
			this._Country = default(EntityRef<Country>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTua", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenTua
		{
			get
			{
				return this._TenTua;
			}
			set
			{
				if ((this._TenTua != value))
				{
					this.OnTenTuaChanging(value);
					this.SendPropertyChanging();
					this._TenTua = value;
					this.SendPropertyChanged("TenTua");
					this.OnTenTuaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DatNuoc", DbType="Int NOT NULL")]
		public int DatNuoc
		{
			get
			{
				return this._DatNuoc;
			}
			set
			{
				if ((this._DatNuoc != value))
				{
					if (this._Country.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDatNuocChanging(value);
					this.SendPropertyChanging();
					this._DatNuoc = value;
					this.SendPropertyChanged("DatNuoc");
					this.OnDatNuocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDDanhMuc", DbType="Int NOT NULL")]
		public int IDDanhMuc
		{
			get
			{
				return this._IDDanhMuc;
			}
			set
			{
				if ((this._IDDanhMuc != value))
				{
					if (this._DanhMuc.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDDanhMucChanging(value);
					this.SendPropertyChanging();
					this._IDDanhMuc = value;
					this.SendPropertyChanged("IDDanhMuc");
					this.OnIDDanhMucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Money NOT NULL")]
		public decimal Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KhachSan", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string KhachSan
		{
			get
			{
				return this._KhachSan;
			}
			set
			{
				if ((this._KhachSan != value))
				{
					this.OnKhachSanChanging(value);
					this.SendPropertyChanging();
					this._KhachSan = value;
					this.SendPropertyChanged("KhachSan");
					this.OnKhachSanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDen", DbType="Date NOT NULL")]
		public System.DateTime NgayDen
		{
			get
			{
				return this._NgayDen;
			}
			set
			{
				if ((this._NgayDen != value))
				{
					this.OnNgayDenChanging(value);
					this.SendPropertyChanging();
					this._NgayDen = value;
					this.SendPropertyChanged("NgayDen");
					this.OnNgayDenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDi", DbType="Date NOT NULL")]
		public System.DateTime NgayDi
		{
			get
			{
				return this._NgayDi;
			}
			set
			{
				if ((this._NgayDi != value))
				{
					this.OnNgayDiChanging(value);
					this.SendPropertyChanging();
					this._NgayDi = value;
					this.SendPropertyChanged("NgayDi");
					this.OnNgayDiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaDat", DbType="Int NOT NULL")]
		public int DaDat
		{
			get
			{
				return this._DaDat;
			}
			set
			{
				if ((this._DaDat != value))
				{
					this.OnDaDatChanging(value);
					this.SendPropertyChanging();
					this._DaDat = value;
					this.SendPropertyChanged("DaDat");
					this.OnDaDatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTua", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaTua
		{
			get
			{
				return this._MaTua;
			}
			set
			{
				if ((this._MaTua != value))
				{
					this.OnMaTuaChanging(value);
					this.SendPropertyChanging();
					this._MaTua = value;
					this.SendPropertyChanged("MaTua");
					this.OnMaTuaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tua_HoaDon", Storage="_HoaDons", ThisKey="MaTua", OtherKey="MaTua")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DanhMuc_Tua", Storage="_DanhMuc", ThisKey="IDDanhMuc", OtherKey="ID", IsForeignKey=true)]
		public DanhMuc DanhMuc
		{
			get
			{
				return this._DanhMuc.Entity;
			}
			set
			{
				DanhMuc previousValue = this._DanhMuc.Entity;
				if (((previousValue != value) 
							|| (this._DanhMuc.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DanhMuc.Entity = null;
						previousValue.Tuas.Remove(this);
					}
					this._DanhMuc.Entity = value;
					if ((value != null))
					{
						value.Tuas.Add(this);
						this._IDDanhMuc = value.ID;
					}
					else
					{
						this._IDDanhMuc = default(int);
					}
					this.SendPropertyChanged("DanhMuc");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Country_Tua", Storage="_Country", ThisKey="DatNuoc", OtherKey="Id", IsForeignKey=true)]
		public Country Country
		{
			get
			{
				return this._Country.Entity;
			}
			set
			{
				Country previousValue = this._Country.Entity;
				if (((previousValue != value) 
							|| (this._Country.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Country.Entity = null;
						previousValue.Tuas.Remove(this);
					}
					this._Country.Entity = value;
					if ((value != null))
					{
						value.Tuas.Add(this);
						this._DatNuoc = value.Id;
					}
					else
					{
						this._DatNuoc = default(int);
					}
					this.SendPropertyChanged("Country");
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
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.Tua = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.Tua = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TheNap")]
	public partial class TheNap : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _MaTheNap;
		
		private decimal _GiaThe;
		
		private int _DaSuDung;
		
		private string _SoSeri;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMaTheNapChanging(string value);
    partial void OnMaTheNapChanged();
    partial void OnGiaTheChanging(decimal value);
    partial void OnGiaTheChanged();
    partial void OnDaSuDungChanging(int value);
    partial void OnDaSuDungChanged();
    partial void OnSoSeriChanging(string value);
    partial void OnSoSeriChanged();
    #endregion
		
		public TheNap()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTheNap", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaTheNap
		{
			get
			{
				return this._MaTheNap;
			}
			set
			{
				if ((this._MaTheNap != value))
				{
					this.OnMaTheNapChanging(value);
					this.SendPropertyChanging();
					this._MaTheNap = value;
					this.SendPropertyChanged("MaTheNap");
					this.OnMaTheNapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaThe", DbType="Money NOT NULL")]
		public decimal GiaThe
		{
			get
			{
				return this._GiaThe;
			}
			set
			{
				if ((this._GiaThe != value))
				{
					this.OnGiaTheChanging(value);
					this.SendPropertyChanging();
					this._GiaThe = value;
					this.SendPropertyChanged("GiaThe");
					this.OnGiaTheChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaSuDung", DbType="Int NOT NULL")]
		public int DaSuDung
		{
			get
			{
				return this._DaSuDung;
			}
			set
			{
				if ((this._DaSuDung != value))
				{
					this.OnDaSuDungChanging(value);
					this.SendPropertyChanging();
					this._DaSuDung = value;
					this.SendPropertyChanged("DaSuDung");
					this.OnDaSuDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoSeri", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string SoSeri
		{
			get
			{
				return this._SoSeri;
			}
			set
			{
				if ((this._SoSeri != value))
				{
					this.OnSoSeriChanging(value);
					this.SendPropertyChanging();
					this._SoSeri = value;
					this.SendPropertyChanged("SoSeri");
					this.OnSoSeriChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HoaDon")]
	public partial class HoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _MaTua;
		
		private decimal _GiaTua;
		
		private string _TenTaiKhoan;
		
		private System.DateTime _NgayDat;
		
		private EntityRef<Tua> _Tua;
		
		private EntityRef<Account> _Account;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMaTuaChanging(string value);
    partial void OnMaTuaChanged();
    partial void OnGiaTuaChanging(decimal value);
    partial void OnGiaTuaChanged();
    partial void OnTenTaiKhoanChanging(string value);
    partial void OnTenTaiKhoanChanged();
    partial void OnNgayDatChanging(System.DateTime value);
    partial void OnNgayDatChanged();
    #endregion
		
		public HoaDon()
		{
			this._Tua = default(EntityRef<Tua>);
			this._Account = default(EntityRef<Account>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTua", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string MaTua
		{
			get
			{
				return this._MaTua;
			}
			set
			{
				if ((this._MaTua != value))
				{
					if (this._Tua.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaTuaChanging(value);
					this.SendPropertyChanging();
					this._MaTua = value;
					this.SendPropertyChanged("MaTua");
					this.OnMaTuaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaTua", DbType="Money NOT NULL")]
		public decimal GiaTua
		{
			get
			{
				return this._GiaTua;
			}
			set
			{
				if ((this._GiaTua != value))
				{
					this.OnGiaTuaChanging(value);
					this.SendPropertyChanging();
					this._GiaTua = value;
					this.SendPropertyChanged("GiaTua");
					this.OnGiaTuaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTaiKhoan", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenTaiKhoan
		{
			get
			{
				return this._TenTaiKhoan;
			}
			set
			{
				if ((this._TenTaiKhoan != value))
				{
					if (this._Account.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTenTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TenTaiKhoan = value;
					this.SendPropertyChanged("TenTaiKhoan");
					this.OnTenTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDat", DbType="Date NOT NULL")]
		public System.DateTime NgayDat
		{
			get
			{
				return this._NgayDat;
			}
			set
			{
				if ((this._NgayDat != value))
				{
					this.OnNgayDatChanging(value);
					this.SendPropertyChanging();
					this._NgayDat = value;
					this.SendPropertyChanged("NgayDat");
					this.OnNgayDatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tua_HoaDon", Storage="_Tua", ThisKey="MaTua", OtherKey="MaTua", IsForeignKey=true)]
		public Tua Tua
		{
			get
			{
				return this._Tua.Entity;
			}
			set
			{
				Tua previousValue = this._Tua.Entity;
				if (((previousValue != value) 
							|| (this._Tua.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tua.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._Tua.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._MaTua = value.MaTua;
					}
					else
					{
						this._MaTua = default(string);
					}
					this.SendPropertyChanged("Tua");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_HoaDon", Storage="_Account", ThisKey="TenTaiKhoan", OtherKey="TenTaiKhoan", IsForeignKey=true)]
		public Account Account
		{
			get
			{
				return this._Account.Entity;
			}
			set
			{
				Account previousValue = this._Account.Entity;
				if (((previousValue != value) 
							|| (this._Account.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Account.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._Account.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._TenTaiKhoan = value.TenTaiKhoan;
					}
					else
					{
						this._TenTaiKhoan = default(string);
					}
					this.SendPropertyChanged("Account");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DanhMuc")]
	public partial class DanhMuc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TenDanhMuc;
		
		private EntitySet<Tua> _Tuas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTenDanhMucChanging(string value);
    partial void OnTenDanhMucChanged();
    #endregion
		
		public DanhMuc()
		{
			this._Tuas = new EntitySet<Tua>(new Action<Tua>(this.attach_Tuas), new Action<Tua>(this.detach_Tuas));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDanhMuc", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenDanhMuc
		{
			get
			{
				return this._TenDanhMuc;
			}
			set
			{
				if ((this._TenDanhMuc != value))
				{
					this.OnTenDanhMucChanging(value);
					this.SendPropertyChanging();
					this._TenDanhMuc = value;
					this.SendPropertyChanged("TenDanhMuc");
					this.OnTenDanhMucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DanhMuc_Tua", Storage="_Tuas", ThisKey="ID", OtherKey="IDDanhMuc")]
		public EntitySet<Tua> Tuas
		{
			get
			{
				return this._Tuas;
			}
			set
			{
				this._Tuas.Assign(value);
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
		
		private void attach_Tuas(Tua entity)
		{
			this.SendPropertyChanging();
			entity.DanhMuc = this;
		}
		
		private void detach_Tuas(Tua entity)
		{
			this.SendPropertyChanging();
			entity.DanhMuc = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Country")]
	public partial class Country : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _CountryCode;
		
		private string _CommonName;
		
		private string _FormalName;
		
		private string _CountryType;
		
		private string _Capital;
		
		private string _TelephoneCode;
		
		private string _InternetCountryCode;
		
		private EntitySet<Tua> _Tuas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCountryCodeChanging(string value);
    partial void OnCountryCodeChanged();
    partial void OnCommonNameChanging(string value);
    partial void OnCommonNameChanged();
    partial void OnFormalNameChanging(string value);
    partial void OnFormalNameChanged();
    partial void OnCountryTypeChanging(string value);
    partial void OnCountryTypeChanged();
    partial void OnCapitalChanging(string value);
    partial void OnCapitalChanged();
    partial void OnTelephoneCodeChanging(string value);
    partial void OnTelephoneCodeChanged();
    partial void OnInternetCountryCodeChanging(string value);
    partial void OnInternetCountryCodeChanged();
    #endregion
		
		public Country()
		{
			this._Tuas = new EntitySet<Tua>(new Action<Tua>(this.attach_Tuas), new Action<Tua>(this.detach_Tuas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryCode", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string CountryCode
		{
			get
			{
				return this._CountryCode;
			}
			set
			{
				if ((this._CountryCode != value))
				{
					this.OnCountryCodeChanging(value);
					this.SendPropertyChanging();
					this._CountryCode = value;
					this.SendPropertyChanged("CountryCode");
					this.OnCountryCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommonName", DbType="NVarChar(100)")]
		public string CommonName
		{
			get
			{
				return this._CommonName;
			}
			set
			{
				if ((this._CommonName != value))
				{
					this.OnCommonNameChanging(value);
					this.SendPropertyChanging();
					this._CommonName = value;
					this.SendPropertyChanged("CommonName");
					this.OnCommonNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FormalName", DbType="NVarChar(100)")]
		public string FormalName
		{
			get
			{
				return this._FormalName;
			}
			set
			{
				if ((this._FormalName != value))
				{
					this.OnFormalNameChanging(value);
					this.SendPropertyChanging();
					this._FormalName = value;
					this.SendPropertyChanged("FormalName");
					this.OnFormalNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryType", DbType="NVarChar(100)")]
		public string CountryType
		{
			get
			{
				return this._CountryType;
			}
			set
			{
				if ((this._CountryType != value))
				{
					this.OnCountryTypeChanging(value);
					this.SendPropertyChanging();
					this._CountryType = value;
					this.SendPropertyChanged("CountryType");
					this.OnCountryTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Capital", DbType="NVarChar(100)")]
		public string Capital
		{
			get
			{
				return this._Capital;
			}
			set
			{
				if ((this._Capital != value))
				{
					this.OnCapitalChanging(value);
					this.SendPropertyChanging();
					this._Capital = value;
					this.SendPropertyChanged("Capital");
					this.OnCapitalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelephoneCode", DbType="NVarChar(100)")]
		public string TelephoneCode
		{
			get
			{
				return this._TelephoneCode;
			}
			set
			{
				if ((this._TelephoneCode != value))
				{
					this.OnTelephoneCodeChanging(value);
					this.SendPropertyChanging();
					this._TelephoneCode = value;
					this.SendPropertyChanged("TelephoneCode");
					this.OnTelephoneCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InternetCountryCode", DbType="NVarChar(100)")]
		public string InternetCountryCode
		{
			get
			{
				return this._InternetCountryCode;
			}
			set
			{
				if ((this._InternetCountryCode != value))
				{
					this.OnInternetCountryCodeChanging(value);
					this.SendPropertyChanging();
					this._InternetCountryCode = value;
					this.SendPropertyChanged("InternetCountryCode");
					this.OnInternetCountryCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Country_Tua", Storage="_Tuas", ThisKey="Id", OtherKey="DatNuoc")]
		public EntitySet<Tua> Tuas
		{
			get
			{
				return this._Tuas;
			}
			set
			{
				this._Tuas.Assign(value);
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
		
		private void attach_Tuas(Tua entity)
		{
			this.SendPropertyChanging();
			entity.Country = this;
		}
		
		private void detach_Tuas(Tua entity)
		{
			this.SendPropertyChanging();
			entity.Country = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TenTaiKhoan;
		
		private string _MatKhau;
		
		private int _IsAdmin;
		
		private decimal _Tien;
		
		private EntitySet<HoaDon> _HoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTenTaiKhoanChanging(string value);
    partial void OnTenTaiKhoanChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnIsAdminChanging(int value);
    partial void OnIsAdminChanged();
    partial void OnTienChanging(decimal value);
    partial void OnTienChanged();
    #endregion
		
		public Account()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTaiKhoan", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TenTaiKhoan
		{
			get
			{
				return this._TenTaiKhoan;
			}
			set
			{
				if ((this._TenTaiKhoan != value))
				{
					this.OnTenTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TenTaiKhoan = value;
					this.SendPropertyChanged("TenTaiKhoan");
					this.OnTenTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsAdmin", DbType="Int NOT NULL")]
		public int IsAdmin
		{
			get
			{
				return this._IsAdmin;
			}
			set
			{
				if ((this._IsAdmin != value))
				{
					this.OnIsAdminChanging(value);
					this.SendPropertyChanging();
					this._IsAdmin = value;
					this.SendPropertyChanged("IsAdmin");
					this.OnIsAdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tien", DbType="Money NOT NULL")]
		public decimal Tien
		{
			get
			{
				return this._Tien;
			}
			set
			{
				if ((this._Tien != value))
				{
					this.OnTienChanging(value);
					this.SendPropertyChanging();
					this._Tien = value;
					this.SendPropertyChanged("Tien");
					this.OnTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_HoaDon", Storage="_HoaDons", ThisKey="TenTaiKhoan", OtherKey="TenTaiKhoan")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
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
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.Account = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.Account = null;
		}
	}
}
#pragma warning restore 1591
