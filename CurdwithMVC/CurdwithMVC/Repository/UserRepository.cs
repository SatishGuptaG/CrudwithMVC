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

		public List<User> GetUsers()
		{
			var dbResp = _dataFatoryDBDataContext.procGetUsers_20042024();
			var User = (from o in dbResp
						   select new User
						   {
							   UserName= o.Name,
							   Email= o.Email,
							   MobileNumber= o.MobileNo,
							   Id=o.id,
							   SelectedCity = o.SelectOption,
							   Gender=o.Gender,
							   Hobbies = o.Hobbies?.Split(new[] { "on" }, StringSplitOptions.RemoveEmptyEntries)
						         .Select(h => h.Trim())
						         .ToList(),
							   IsActive = o.IsActive.GetValueOrDefault(),
							   //   IsActive = o.IsActive!=null?(bool)o.IsActive:false,

						   }).ToList();
			return User;	

		}

		public User GetUserById(int id)
		{
			var dbResp = _dataFatoryDBDataContext.procGetUserDetail_20042024(id);
			var user = dbResp.Select(o => new User
			{
				UserName = o.Name,
				Email = o.Email,
				MobileNumber = o.MobileNo,
				Id = o.id,
			    Password= o.Password,
				SelectedCity = o.SelectOption,
				Gender = o.Gender,
				Hobbies = o.Hobbies?.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
							 .Select(h => h.Trim())
							 .ToList(),
				IsActive = o.IsActive.GetValueOrDefault(),

			})
			.FirstOrDefault();
			return user;
		}

		//public bool SaveUser(User user)
		//{
		//	string hobbies = string.Join(",", user.Hobbies);
		//	var res = _dataFatoryDBDataContext.procSaveUser_20042024(user.UserName, user.Email, user.Password, user.MobileNumber, user.SelectedCity, user.Gender, hobbies , user.IsActive);
		//	//why we use FirstOrDefault 
		//	var isValid = res.FirstOrDefault().isValid;
		//	//why we use cast
		//	return (bool)isValid;
		//}

		//public bool UpdateUser(User user)
		//{
		//	// Check if the new email is the same as the existing email
		//	var existingUser = GetUserById((int)user.Id);
		//	if (existingUser == null)
		//	{
		//		// Handle case where user with the specified ID does not exist
		//		return false;
		//	}

		//	if (existingUser.Email != user.Email)
		//	{
		//		// Email is being changed, check if the new email already exists
		//		//var isEmailExists = GetUsers().Any(u => u.Email == user.Email);
		//		//if (isEmailExists)
		//		//{
		//			// Email already exists, cannot update
		//			return false;
		//		//}
		//	}

		//	// Proceed with the update operation

		//	string hobbies = string.Join(",", user.Hobbies);
		//	var res = _dataFatoryDBDataContext.procUpdateUser_20042024(user.Id,user.UserName, user.Email, user.Password, user.MobileNumber, user.SelectedCity, user.Gender, hobbies, user.IsActive);
		//	var isValid = res.FirstOrDefault().isValid;
		//	return (bool)isValid;
		//}

		public Response UpsertUser(User user)
		{
			var a = new Response();
			if (user.Id != null)
			{
				var existingUser = GetUserById((int)user.Id);
				if (existingUser == null)
				{
					return a;
				}

				if (existingUser.Email != user.Email)
				{
					return a;
				}
			}
			
			string hobbies = string.Join(",", user.Hobbies);
			var res = _dataFatoryDBDataContext.procUpsertUser_20240421(user.Id, user.UserName, user.Email, user.Password, user.MobileNumber, user.SelectedCity, user.Gender, hobbies, user.IsActive);
			a = (from o in res
				 select new Response
				 {
					 isValid = o.isValid,
					 message = o.message,
				 }).FirstOrDefault();
			//var isValid = res.FirstOrDefault().isValid;
			return a;
		}

		public bool DeleteUser(int id)
		{
			// Implement logic to delete user from the database
			var dbResp = _dataFatoryDBDataContext.procDeleteUser_20042024(id);
			var isValid = dbResp.FirstOrDefault()?.isValid;
			return isValid ?? false;
		}

	}
}