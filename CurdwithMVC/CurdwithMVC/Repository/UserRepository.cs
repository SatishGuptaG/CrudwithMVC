using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CurdwithMVC.Data;
using CurdwithMVC.Models;

namespace CurdwithMVC.Repository
{
	public class UserRepository : IUserRepository
	{
		private readonly IDataFatory _dataFatory;
		private readonly DataFatoryDBDataContext _dataFatoryDBDataContext;

		public UserRepository(IDataFatory dataFatory, DataFatoryDBDataContext dataFatoryDBDataContext)
		{
			_dataFatory = dataFatory;
			_dataFatoryDBDataContext = _dataFatory.DataFatoryDBDataContext();
		}

		public bool SaveUser(User user)
		{
			var res = _dataFatoryDBDataContext.procSaveUser_07042024(user.UserName, user.Email, user.MobileNumber, user.Password);
			//why we use FirstOrDefault 
			var isValid = res.FirstOrDefault().isValid;
			//why we use cast
			return (bool)isValid;
		}
	}
}