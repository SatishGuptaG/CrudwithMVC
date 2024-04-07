using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurdwithMVC.Models;


namespace CurdwithMVC.Service
{
	

	
	public interface IUserService
	{
		 bool SaveUser(User user);
	}
}
