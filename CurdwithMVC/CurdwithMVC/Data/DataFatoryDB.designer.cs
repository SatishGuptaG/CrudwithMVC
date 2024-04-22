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

namespace CurdwithMVC.Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CRUD")]
	public partial class DataFatoryDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataFatoryDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CRUDConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataFatoryDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataFatoryDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataFatoryDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataFatoryDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.procSaveUser_20042024")]
		public ISingleResult<procSaveUser_20042024Result> procSaveUser_20042024([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(100)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="NVarChar(100)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(100)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MobileNo", DbType="NVarChar(100)")] string mobileNo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SelectOption", DbType="NVarChar(50)")] string selectOption, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Gender", DbType="NVarChar(10)")] string gender, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Hobbies", DbType="NVarChar(100)")] string hobbies, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsActive", DbType="Bit")] System.Nullable<bool> isActive)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name, email, password, mobileNo, selectOption, gender, hobbies, isActive);
			return ((ISingleResult<procSaveUser_20042024Result>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.procGetUsers_20042024")]
		public ISingleResult<procGetUsers_20042024Result> procGetUsers_20042024()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<procGetUsers_20042024Result>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.procDeleteUser_20042024")]
		public ISingleResult<procDeleteUser_20042024Result> procDeleteUser_20042024([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((ISingleResult<procDeleteUser_20042024Result>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.procUpdateUser_20042024")]
		public ISingleResult<procUpdateUser_20042024Result> procUpdateUser_20042024([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(100)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="NVarChar(100)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(100)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MobileNo", DbType="NVarChar(100)")] string mobileNo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SelectOption", DbType="NVarChar(50)")] string selectOption, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Gender", DbType="NVarChar(10)")] string gender, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Hobbies", DbType="NVarChar(100)")] string hobbies, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsActive", DbType="Bit")] System.Nullable<bool> isActive)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, name, email, password, mobileNo, selectOption, gender, hobbies, isActive);
			return ((ISingleResult<procUpdateUser_20042024Result>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.procGetUserDetail_20042024")]
		public ISingleResult<procGetUserDetail_20042024Result> procGetUserDetail_20042024([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((ISingleResult<procGetUserDetail_20042024Result>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.procUpsertUser_20240421")]
		public ISingleResult<procUpsertUser_20240421Result> procUpsertUser_20240421([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(100)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="NVarChar(100)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(100)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MobileNo", DbType="NVarChar(100)")] string mobileNo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SelectOption", DbType="NVarChar(50)")] string selectOption, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Gender", DbType="NVarChar(10)")] string gender, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Hobbies", DbType="NVarChar(100)")] string hobbies, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsActive", DbType="Bit")] System.Nullable<bool> isActive)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, name, email, password, mobileNo, selectOption, gender, hobbies, isActive);
			return ((ISingleResult<procUpsertUser_20240421Result>)(result.ReturnValue));
		}
	}
	
	public partial class procSaveUser_20042024Result
	{
		
		private System.Nullable<bool> _isValid;
		
		public procSaveUser_20042024Result()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isValid", DbType="Bit")]
		public System.Nullable<bool> isValid
		{
			get
			{
				return this._isValid;
			}
			set
			{
				if ((this._isValid != value))
				{
					this._isValid = value;
				}
			}
		}
	}
	
	public partial class procGetUsers_20042024Result
	{
		
		private string _Name;
		
		private string _Email;
		
		private string _MobileNo;
		
		private int _id;
		
		private string _SelectOption;
		
		private string _Gender;
		
		private string _Hobbies;
		
		private System.Nullable<bool> _IsActive;
		
		public procGetUsers_20042024Result()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100)")]
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
					this._Name = value;
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
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MobileNo", DbType="NVarChar(100)")]
		public string MobileNo
		{
			get
			{
				return this._MobileNo;
			}
			set
			{
				if ((this._MobileNo != value))
				{
					this._MobileNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL")]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SelectOption", DbType="NVarChar(50)")]
		public string SelectOption
		{
			get
			{
				return this._SelectOption;
			}
			set
			{
				if ((this._SelectOption != value))
				{
					this._SelectOption = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(10)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this._Gender = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hobbies", DbType="NVarChar(100)")]
		public string Hobbies
		{
			get
			{
				return this._Hobbies;
			}
			set
			{
				if ((this._Hobbies != value))
				{
					this._Hobbies = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit")]
		public System.Nullable<bool> IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this._IsActive = value;
				}
			}
		}
	}
	
	public partial class procDeleteUser_20042024Result
	{
		
		private System.Nullable<bool> _isValid;
		
		public procDeleteUser_20042024Result()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isValid", DbType="Bit")]
		public System.Nullable<bool> isValid
		{
			get
			{
				return this._isValid;
			}
			set
			{
				if ((this._isValid != value))
				{
					this._isValid = value;
				}
			}
		}
	}
	
	public partial class procUpdateUser_20042024Result
	{
		
		private System.Nullable<bool> _isValid;
		
		public procUpdateUser_20042024Result()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isValid", DbType="Bit")]
		public System.Nullable<bool> isValid
		{
			get
			{
				return this._isValid;
			}
			set
			{
				if ((this._isValid != value))
				{
					this._isValid = value;
				}
			}
		}
	}
	
	public partial class procGetUserDetail_20042024Result
	{
		
		private string _Name;
		
		private string _Email;
		
		private string _MobileNo;
		
		private int _id;
		
		private string _Password;
		
		private string _SelectOption;
		
		private string _Gender;
		
		private string _Hobbies;
		
		private System.Nullable<bool> _IsActive;
		
		public procGetUserDetail_20042024Result()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100)")]
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
					this._Name = value;
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
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MobileNo", DbType="NVarChar(100)")]
		public string MobileNo
		{
			get
			{
				return this._MobileNo;
			}
			set
			{
				if ((this._MobileNo != value))
				{
					this._MobileNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL")]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(100)")]
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
					this._Password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SelectOption", DbType="NVarChar(50)")]
		public string SelectOption
		{
			get
			{
				return this._SelectOption;
			}
			set
			{
				if ((this._SelectOption != value))
				{
					this._SelectOption = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(10)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this._Gender = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hobbies", DbType="NVarChar(100)")]
		public string Hobbies
		{
			get
			{
				return this._Hobbies;
			}
			set
			{
				if ((this._Hobbies != value))
				{
					this._Hobbies = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit")]
		public System.Nullable<bool> IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this._IsActive = value;
				}
			}
		}
	}
	
	public partial class procUpsertUser_20240421Result
	{
		
		private System.Nullable<bool> _isValid;
		
		private string _message;
		
		private System.Nullable<int> _recordId;
		
		public procUpsertUser_20240421Result()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isValid", DbType="Bit")]
		public System.Nullable<bool> isValid
		{
			get
			{
				return this._isValid;
			}
			set
			{
				if ((this._isValid != value))
				{
					this._isValid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_message", DbType="NVarChar(100)")]
		public string message
		{
			get
			{
				return this._message;
			}
			set
			{
				if ((this._message != value))
				{
					this._message = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_recordId", DbType="Int")]
		public System.Nullable<int> recordId
		{
			get
			{
				return this._recordId;
			}
			set
			{
				if ((this._recordId != value))
				{
					this._recordId = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
