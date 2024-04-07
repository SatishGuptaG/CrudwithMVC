using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace CurdwithMVC.Data
{
	public class DataFatory : IDataFatory
	{
		static MappingSource _sharedMappingSource = new AttributeMappingSource();
		string _connectionString;
		public DataFatoryDBDataContext DataFatoryDBDataContext()
		{
			_connectionString = ConfigurationManager.ConnectionStrings["CRUDConnectionString"].ConnectionString;
			return new DataFatoryDBDataContext(_connectionString, _sharedMappingSource);
		}
	}
}