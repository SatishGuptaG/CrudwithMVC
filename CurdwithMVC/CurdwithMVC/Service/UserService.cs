using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CurdwithMVC.Models;
using CurdwithMVC.Repository;

namespace CurdwithMVC.Service
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public List<User> GetUsers()
		{
			var res = _userRepository.GetUsers();
			return res;
		}

		public User GetUserById(int id)
		{
			return _userRepository.GetUserById(id);
		}


		//public bool SaveUser(User user)
		//{
		//	var res= _userRepository.SaveUser(user);
		//	return res;
		//}

		//public bool UpdateUser(User user)
		//{
		//	return _userRepository.UpdateUser(user);
		//}
		public Response UpsertUser(User user)
		{
			return _userRepository.UpsertUser(user);
		}
		public bool DeleteUser(int id)
		{
			return _userRepository.DeleteUser(id);
		}

	}
}