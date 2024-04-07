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

		public bool SaveUser(User user)
		{
			var res= _userRepository.SaveUser(user);
			return res;
		}
	}
}