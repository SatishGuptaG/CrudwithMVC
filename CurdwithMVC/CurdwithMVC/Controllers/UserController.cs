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
		public ActionResult GetUsers()
		{
			var res = _userService.GetUsers();

			return View(res);
		}

		// GET: User/NewUserSuccess
		public ActionResult NewUserSuccess()
		{
			return View();
		}

		[HttpGet]
		public ActionResult Edit(int id)
		{
			var user = _userService.GetUserById(id);
			if (user == null)
			{
				return HttpNotFound(); // Or some other appropriate action
			}
			return View(user);
		}

		[HttpPost]
		public JsonResult UpdateUser(User user)
		{
			
			var result = _userService.UpdateUser(user);
			return Json(result, JsonRequestBehavior.AllowGet);

		}

		[HttpPost]
		public ActionResult Delete(int id)
		{
			var result = _userService.DeleteUser(id);
			if (result)
			{
				// Optionally, you can redirect to a success page or refresh the user list
				return RedirectToAction("GetUsers");
			}
			// Optionally handle the case where delete fails
			return RedirectToAction("GetUsers");
		}

	}
}
