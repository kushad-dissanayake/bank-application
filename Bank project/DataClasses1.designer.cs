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

namespace Bank_project
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="USERS")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Bank_project.Properties.Settings.Default.USERSConnectionString1, mappingSource)
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
		
		public System.Data.Linq.Table<Bank> Banks
		{
			get
			{
				return this.GetTable<Bank>();
			}
		}
		
		public System.Data.Linq.Table<Manager> Managers
		{
			get
			{
				return this.GetTable<Manager>();
			}
		}
		
		public System.Data.Linq.Table<Accountent> Accountents
		{
			get
			{
				return this.GetTable<Accountent>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bank")]
	public partial class Bank
	{
		
		private int _Account_No;
		
		private string _Crd_NO;
		
		private string _Full_Name;
		
		private int _Account_Balance;
		
		private int _Passward;
		
		private long _Phone_No;
		
		public Bank()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Account_No", DbType="Int NOT NULL")]
		public int Account_No
		{
			get
			{
				return this._Account_No;
			}
			set
			{
				if ((this._Account_No != value))
				{
					this._Account_No = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Crd_NO", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Crd_NO
		{
			get
			{
				return this._Crd_NO;
			}
			set
			{
				if ((this._Crd_NO != value))
				{
					this._Crd_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Full_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Full_Name
		{
			get
			{
				return this._Full_Name;
			}
			set
			{
				if ((this._Full_Name != value))
				{
					this._Full_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Account_Balance", DbType="Int NOT NULL")]
		public int Account_Balance
		{
			get
			{
				return this._Account_Balance;
			}
			set
			{
				if ((this._Account_Balance != value))
				{
					this._Account_Balance = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Passward", DbType="Int NOT NULL")]
		public int Passward
		{
			get
			{
				return this._Passward;
			}
			set
			{
				if ((this._Passward != value))
				{
					this._Passward = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone_No", DbType="BigInt NOT NULL")]
		public long Phone_No
		{
			get
			{
				return this._Phone_No;
			}
			set
			{
				if ((this._Phone_No != value))
				{
					this._Phone_No = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Manager")]
	public partial class Manager
	{
		
		private int _Manager_ID;
		
		private string _Branch;
		
		private string _Full_Name;
		
		private int _Passward;
		
		private long _Phone_No;
		
		public Manager()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Manager_ID", DbType="Int NOT NULL")]
		public int Manager_ID
		{
			get
			{
				return this._Manager_ID;
			}
			set
			{
				if ((this._Manager_ID != value))
				{
					this._Manager_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Branch", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Branch
		{
			get
			{
				return this._Branch;
			}
			set
			{
				if ((this._Branch != value))
				{
					this._Branch = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Full_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Full_Name
		{
			get
			{
				return this._Full_Name;
			}
			set
			{
				if ((this._Full_Name != value))
				{
					this._Full_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Passward", DbType="Int NOT NULL")]
		public int Passward
		{
			get
			{
				return this._Passward;
			}
			set
			{
				if ((this._Passward != value))
				{
					this._Passward = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone_No", DbType="BigInt NOT NULL")]
		public long Phone_No
		{
			get
			{
				return this._Phone_No;
			}
			set
			{
				if ((this._Phone_No != value))
				{
					this._Phone_No = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Accountent")]
	public partial class Accountent
	{
		
		private int _Accountent_ID;
		
		private string _Full_Name;
		
		private int _Pin_no;
		
		private long _Phone_No;
		
		public Accountent()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Accountent_ID", DbType="Int NOT NULL")]
		public int Accountent_ID
		{
			get
			{
				return this._Accountent_ID;
			}
			set
			{
				if ((this._Accountent_ID != value))
				{
					this._Accountent_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Full_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Full_Name
		{
			get
			{
				return this._Full_Name;
			}
			set
			{
				if ((this._Full_Name != value))
				{
					this._Full_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pin_no", DbType="Int NOT NULL")]
		public int Pin_no
		{
			get
			{
				return this._Pin_no;
			}
			set
			{
				if ((this._Pin_no != value))
				{
					this._Pin_no = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone_No", DbType="BigInt NOT NULL")]
		public long Phone_No
		{
			get
			{
				return this._Phone_No;
			}
			set
			{
				if ((this._Phone_No != value))
				{
					this._Phone_No = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
