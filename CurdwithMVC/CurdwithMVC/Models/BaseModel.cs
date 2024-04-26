using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurdwithMVC.Models
{
	public class BaseModel
	{
		public int CurrentPage { get; set; }
		public int PageSize { get; set; }
		public int TotalRecords { get; set; }
	}
}