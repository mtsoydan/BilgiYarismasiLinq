﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lınq_Kim500
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Yarisma_DB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSoruDogruSık(SoruDogruSık instance);
    partial void UpdateSoruDogruSık(SoruDogruSık instance);
    partial void DeleteSoruDogruSık(SoruDogruSık instance);
    partial void InsertSoruSıkları(SoruSıkları instance);
    partial void UpdateSoruSıkları(SoruSıkları instance);
    partial void DeleteSoruSıkları(SoruSıkları instance);
    partial void InsertSorular(Sorular instance);
    partial void UpdateSorular(Sorular instance);
    partial void DeleteSorular(Sorular instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Lınq_Kim500.Properties.Settings.Default.Yarisma_DBConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SoruDogruSık> SoruDogruSıks
		{
			get
			{
				return this.GetTable<SoruDogruSık>();
			}
		}
		
		public System.Data.Linq.Table<SoruSıkları> SoruSıklarıs
		{
			get
			{
				return this.GetTable<SoruSıkları>();
			}
		}
		
		public System.Data.Linq.Table<Sorular> Sorulars
		{
			get
			{
				return this.GetTable<Sorular>();
			}
		}
		
		public System.Data.Linq.Table<view_Ayrintilar> view_Ayrintilars
		{
			get
			{
				return this.GetTable<view_Ayrintilar>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RasgeleSoru")]
		public ISingleResult<RasgeleSoruResult> RasgeleSoru()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<RasgeleSoruResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SoruSil")]
		public int SoruSil([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SoruEkle")]
		public int SoruEkle([global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoruMetni", DbType="NVarChar(250)")] string soruMetni, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="A", DbType="NVarChar(100)")] string a, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="B", DbType="NVarChar(100)")] string b, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="C", DbType="NVarChar(100)")] string c, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="D", DbType="NVarChar(100)")] string d, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoruDogruCevap", DbType="Char(1)")] System.Nullable<char> soruDogruCevap)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), soruMetni, a, b, c, d, soruDogruCevap);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SoruGuncelle")]
		public int SoruGuncelle([global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoruID", DbType="Int")] System.Nullable<int> soruID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoruMetni", DbType="NVarChar(250)")] string soruMetni, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DogruSık", DbType="Char(1)")] System.Nullable<char> dogruSık, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SıkA", DbType="NVarChar(100)")] string sıkA, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SıkB", DbType="NVarChar(100)")] string sıkB, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SıkC", DbType="NVarChar(100)")] string sıkC, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SıkD", DbType="NVarChar(100)")] string sıkD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), soruID, soruMetni, dogruSık, sıkA, sıkB, sıkC, sıkD);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SoruDogruSık")]
	public partial class SoruDogruSık : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SoruID;
		
		private char _DogruSık;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSoruIDChanging(int value);
    partial void OnSoruIDChanged();
    partial void OnDogruSıkChanging(char value);
    partial void OnDogruSıkChanged();
    #endregion
		
		public SoruDogruSık()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoruID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SoruID
		{
			get
			{
				return this._SoruID;
			}
			set
			{
				if ((this._SoruID != value))
				{
					this.OnSoruIDChanging(value);
					this.SendPropertyChanging();
					this._SoruID = value;
					this.SendPropertyChanged("SoruID");
					this.OnSoruIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DogruSık", DbType="Char(1) NOT NULL")]
		public char DogruSık
		{
			get
			{
				return this._DogruSık;
			}
			set
			{
				if ((this._DogruSık != value))
				{
					this.OnDogruSıkChanging(value);
					this.SendPropertyChanging();
					this._DogruSık = value;
					this.SendPropertyChanged("DogruSık");
					this.OnDogruSıkChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SoruSıkları")]
	public partial class SoruSıkları : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SoruID;
		
		private string _A;
		
		private string _B;
		
		private string _C;
		
		private string _D;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSoruIDChanging(int value);
    partial void OnSoruIDChanged();
    partial void OnAChanging(string value);
    partial void OnAChanged();
    partial void OnBChanging(string value);
    partial void OnBChanged();
    partial void OnCChanging(string value);
    partial void OnCChanged();
    partial void OnDChanging(string value);
    partial void OnDChanged();
    #endregion
		
		public SoruSıkları()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoruID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SoruID
		{
			get
			{
				return this._SoruID;
			}
			set
			{
				if ((this._SoruID != value))
				{
					this.OnSoruIDChanging(value);
					this.SendPropertyChanging();
					this._SoruID = value;
					this.SendPropertyChanged("SoruID");
					this.OnSoruIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string A
		{
			get
			{
				return this._A;
			}
			set
			{
				if ((this._A != value))
				{
					this.OnAChanging(value);
					this.SendPropertyChanging();
					this._A = value;
					this.SendPropertyChanged("A");
					this.OnAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_B", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string B
		{
			get
			{
				return this._B;
			}
			set
			{
				if ((this._B != value))
				{
					this.OnBChanging(value);
					this.SendPropertyChanging();
					this._B = value;
					this.SendPropertyChanged("B");
					this.OnBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string C
		{
			get
			{
				return this._C;
			}
			set
			{
				if ((this._C != value))
				{
					this.OnCChanging(value);
					this.SendPropertyChanging();
					this._C = value;
					this.SendPropertyChanged("C");
					this.OnCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_D", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string D
		{
			get
			{
				return this._D;
			}
			set
			{
				if ((this._D != value))
				{
					this.OnDChanging(value);
					this.SendPropertyChanging();
					this._D = value;
					this.SendPropertyChanged("D");
					this.OnDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sorular")]
	public partial class Sorular : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SoruID;
		
		private string _SoruMetni;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSoruIDChanging(int value);
    partial void OnSoruIDChanged();
    partial void OnSoruMetniChanging(string value);
    partial void OnSoruMetniChanged();
    #endregion
		
		public Sorular()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoruID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SoruID
		{
			get
			{
				return this._SoruID;
			}
			set
			{
				if ((this._SoruID != value))
				{
					this.OnSoruIDChanging(value);
					this.SendPropertyChanging();
					this._SoruID = value;
					this.SendPropertyChanged("SoruID");
					this.OnSoruIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoruMetni", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string SoruMetni
		{
			get
			{
				return this._SoruMetni;
			}
			set
			{
				if ((this._SoruMetni != value))
				{
					this.OnSoruMetniChanging(value);
					this.SendPropertyChanging();
					this._SoruMetni = value;
					this.SendPropertyChanged("SoruMetni");
					this.OnSoruMetniChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.view_Ayrintilar")]
	public partial class view_Ayrintilar
	{
		
		private int _SoruID;
		
		private char _DogruSık;
		
		private string _A;
		
		private string _B;
		
		private string _C;
		
		private string _SoruMetni;
		
		private string _D;
		
		public view_Ayrintilar()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoruID", DbType="Int NOT NULL")]
		public int SoruID
		{
			get
			{
				return this._SoruID;
			}
			set
			{
				if ((this._SoruID != value))
				{
					this._SoruID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DogruSık", DbType="Char(1) NOT NULL")]
		public char DogruSık
		{
			get
			{
				return this._DogruSık;
			}
			set
			{
				if ((this._DogruSık != value))
				{
					this._DogruSık = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string A
		{
			get
			{
				return this._A;
			}
			set
			{
				if ((this._A != value))
				{
					this._A = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_B", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string B
		{
			get
			{
				return this._B;
			}
			set
			{
				if ((this._B != value))
				{
					this._B = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string C
		{
			get
			{
				return this._C;
			}
			set
			{
				if ((this._C != value))
				{
					this._C = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoruMetni", DbType="NVarChar(100)")]
		public string SoruMetni
		{
			get
			{
				return this._SoruMetni;
			}
			set
			{
				if ((this._SoruMetni != value))
				{
					this._SoruMetni = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_D", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string D
		{
			get
			{
				return this._D;
			}
			set
			{
				if ((this._D != value))
				{
					this._D = value;
				}
			}
		}
	}
	
	public partial class RasgeleSoruResult
	{
		
		private int _SoruID;
		
		private char _DogruSık;
		
		private string _A;
		
		private string _B;
		
		private string _C;
		
		private string _SoruMetni;
		
		private string _D;
		
		public RasgeleSoruResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoruID", DbType="Int NOT NULL")]
		public int SoruID
		{
			get
			{
				return this._SoruID;
			}
			set
			{
				if ((this._SoruID != value))
				{
					this._SoruID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DogruSık", DbType="Char(1) NOT NULL")]
		public char DogruSık
		{
			get
			{
				return this._DogruSık;
			}
			set
			{
				if ((this._DogruSık != value))
				{
					this._DogruSık = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string A
		{
			get
			{
				return this._A;
			}
			set
			{
				if ((this._A != value))
				{
					this._A = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_B", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string B
		{
			get
			{
				return this._B;
			}
			set
			{
				if ((this._B != value))
				{
					this._B = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string C
		{
			get
			{
				return this._C;
			}
			set
			{
				if ((this._C != value))
				{
					this._C = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoruMetni", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string SoruMetni
		{
			get
			{
				return this._SoruMetni;
			}
			set
			{
				if ((this._SoruMetni != value))
				{
					this._SoruMetni = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_D", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string D
		{
			get
			{
				return this._D;
			}
			set
			{
				if ((this._D != value))
				{
					this._D = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
