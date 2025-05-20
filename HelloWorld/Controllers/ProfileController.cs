using ClassLibrary.Models;
using ClassLibrary.Persistence;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Rental.Controllers
{
    public class ProfileController : BaseController
    {
        public ProfileController(DBContext context) : base(context)
        {
        }

        public IActionResult Index()
        {
            var user = GetUserObject();
            if (user == null)
            {
                return RedirectToAction("SignIn", "Signin");
            }

            var dbUser = _context.Users.FirstOrDefault(u => u.Id == user.Id);
            if (dbUser != null)
            {
                ViewBag.FirstName = dbUser.Fname;
                ViewBag.LastName = dbUser.Lname;
                ViewBag.Email = dbUser.Email;
            }

            return View();
        }

        [HttpPost]
        public IActionResult Profile(string firstName, string lastName, string email, string nPassword, string cPassword)
        {
            var user = GetUserObject();
            if (user == null)
            {
                return RedirectToAction("SignIn", "Signin");
            }

            var dbUser = _context.Users.FirstOrDefault(u => u.Id == user.Id);
            if (dbUser == null)
            {
                ViewBag.ErrorMessage = "User not found.";
                return View("Index");
            }

            
            ViewBag.FirstName = firstName;
            ViewBag.LastName = lastName;
            ViewBag.Email = email;

            
            if (!string.IsNullOrWhiteSpace(nPassword) || !string.IsNullOrWhiteSpace(cPassword))
            {
                if (string.IsNullOrWhiteSpace(nPassword) || string.IsNullOrWhiteSpace(cPassword))
                {
                    ViewBag.ErrorMessage = "Both New Password and Confirm Password must be filled.";
                    return View("Index");
                }

                if (nPassword != cPassword)
                {
                    ViewBag.ErrorMessage = "New Password and Confirm Password do not match.";
                    return View("Index");
                }

             
                dbUser.Password = nPassword; 
            }

            dbUser.Fname = firstName;
            dbUser.Lname = lastName;
            dbUser.Email = email;

            _context.SaveChanges();

          
            var updatedUser = _context.Users.FirstOrDefault(u => u.Id == user.Id);
            if (updatedUser != null)
            {
                ViewBag.FirstName = updatedUser.Fname;
                ViewBag.LastName = updatedUser.Lname;
                ViewBag.Email = updatedUser.Email;

                var userJson = JsonConvert.SerializeObject(updatedUser);
                var encodedUser = Convert.ToBase64String(Encoding.UTF8.GetBytes(userJson));
                Response.Cookies.Append("credentials", encodedUser);
            }

            ViewBag.Message = "Profile updated successfully!";
            return View("Index");
        }
    }
}
