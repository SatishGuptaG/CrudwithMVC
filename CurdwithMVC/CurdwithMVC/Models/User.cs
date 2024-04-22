using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurdwithMVC.Models
{
	public class User
	{
		public string UserName { get; set; }
		public string Email { get; set; }
		public string MobileNumber { get; set; }
		public string Password { get; set; }
		public int? Id { get; set; }
		public string SelectedCity { get; set; }
		public string Gender { get; set; }
		public List<string> Hobbies { get; set; }
		public bool? IsActive { get; set; }


	}

}