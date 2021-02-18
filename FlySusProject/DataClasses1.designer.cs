﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlySusProject
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FlySusData")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSalespersons(Salespersons instance);
    partial void UpdateSalespersons(Salespersons instance);
    partial void DeleteSalespersons(Salespersons instance);
    partial void InsertOperationsManagers(OperationsManagers instance);
    partial void UpdateOperationsManagers(OperationsManagers instance);
    partial void DeleteOperationsManagers(OperationsManagers instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::FlySusProject.Properties.Settings.Default.FlySusDataConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Salespersons> Salespersons
		{
			get
			{
				return this.GetTable<Salespersons>();
			}
		}
		
		public System.Data.Linq.Table<OperationsManagers> OperationsManagers
		{
			get
			{
				return this.GetTable<OperationsManagers>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Salespersons")]
	public partial class Salespersons : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _SalepersonEposta;
		
		private string _SalespersonSıfre;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSalepersonEpostaChanging(string value);
    partial void OnSalepersonEpostaChanged();
    partial void OnSalespersonSıfreChanging(string value);
    partial void OnSalespersonSıfreChanged();
    #endregion
		
		public Salespersons()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalepersonEposta", DbType="NVarChar(MAX)")]
		public string SalepersonEposta
		{
			get
			{
				return this._SalepersonEposta;
			}
			set
			{
				if ((this._SalepersonEposta != value))
				{
					this.OnSalepersonEpostaChanging(value);
					this.SendPropertyChanging();
					this._SalepersonEposta = value;
					this.SendPropertyChanged("SalepersonEposta");
					this.OnSalepersonEpostaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalespersonSıfre", DbType="NVarChar(MAX)")]
		public string SalespersonSıfre
		{
			get
			{
				return this._SalespersonSıfre;
			}
			set
			{
				if ((this._SalespersonSıfre != value))
				{
					this.OnSalespersonSıfreChanging(value);
					this.SendPropertyChanging();
					this._SalespersonSıfre = value;
					this.SendPropertyChanged("SalespersonSıfre");
					this.OnSalespersonSıfreChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OperationsManagers")]
	public partial class OperationsManagers : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _OperationsmanagerEposta;
		
		private string _OperationsManagerSıfre;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnOperationsmanagerEpostaChanging(string value);
    partial void OnOperationsmanagerEpostaChanged();
    partial void OnOperationsManagerSıfreChanging(string value);
    partial void OnOperationsManagerSıfreChanged();
    #endregion
		
		public OperationsManagers()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OperationsmanagerEposta", DbType="NVarChar(MAX)")]
		public string OperationsmanagerEposta
		{
			get
			{
				return this._OperationsmanagerEposta;
			}
			set
			{
				if ((this._OperationsmanagerEposta != value))
				{
					this.OnOperationsmanagerEpostaChanging(value);
					this.SendPropertyChanging();
					this._OperationsmanagerEposta = value;
					this.SendPropertyChanged("OperationsmanagerEposta");
					this.OnOperationsmanagerEpostaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OperationsManagerSıfre", DbType="NVarChar(MAX)")]
		public string OperationsManagerSıfre
		{
			get
			{
				return this._OperationsManagerSıfre;
			}
			set
			{
				if ((this._OperationsManagerSıfre != value))
				{
					this.OnOperationsManagerSıfreChanging(value);
					this.SendPropertyChanging();
					this._OperationsManagerSıfre = value;
					this.SendPropertyChanged("OperationsManagerSıfre");
					this.OnOperationsManagerSıfreChanged();
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
