﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurdwithMVC.Models;

namespace CurdwithMVC.Repository
{
	public interface IUserRepository
	{
		bool SaveUser(User user);
		List<User> GetUsers();

		User GetUserById(int id);
		bool UpdateUser(User user);
		bool DeleteUser(int id);

	}
}
