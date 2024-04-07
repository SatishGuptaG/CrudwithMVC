//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using CurdwithMVC.Models;

//namespace CurdwithMVC.Controllers
//{
//    public class UserController : Controller
//    {
//        // GET: User
//        public ActionResult NewUser()
//        {
//            return View();
//        }
//		[HttpPost]


//		public ActionResult Registration( User user)
//		{
//			return View();
//		}

//		public ActionResult Index()
//		{
//			return View();
//		}

//	}
//}


using System.Web.Mvc;
using CurdwithMVC.Models;
using CurdwithMVC.Service;

namespace CurdwithMVC.Controllers
{
	public class UserController : Controller
	{
		private readonly IUserService _userService;

		// Constructor injection to inject IUserService
		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		// GET: User/NewUser
		public ActionResult NewUser()
		{
			return View();
		}

		// POST: User/NewUser
		[HttpPost]
		public JsonResult NewUser(User user)
		{
			
				// Call UserService to save the user
				var result = _userService.SaveUser(user);

				
				// Optionally, you can redirect to a success page
				//return RedirectToAction("NewUserSuccess");
				return Json(result, JsonRequestBehavior.AllowGet);

		
			
			
		}

		// GET: User/NewUserSuccess
		public ActionResult NewUserSuccess()
		{
			return View();
		}
	}
}
