using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AvansasProject.Models;


namespace AvansasProject.Controllers
{
    public class HomeController : Controller
    {
        Context context = new Context();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public static class AuthorizeRol {
            public enum Roles
            {
                Admin = 1,
                User = 2
            }

        }
        
        [Route("Home/PersonDelete/{Email?}")]
        public IActionResult PersonDelete(string Email)
        {
            
            var dep = context.Userlar.Where(x => x.Email == Email).FirstOrDefault();
            context.Userlar.Remove(dep);
            context.SaveChanges();

            return RedirectToAction("Index");
            
        }
        [Route("Home/PersonUpdate/{Email?}")]
        public IActionResult PersonUpdate(string Email)
        {
            var dep = context.Userlar.Where(x => x.Email == Email).FirstOrDefault();

            return View(dep);
        }
        public IActionResult PersonUpdateSendDataView(Users user)
        {
            var dep = context.Userlar.Where(x => x.ID == user.ID).FirstOrDefault();
            dep.ID = user.ID;
            dep.Name = user.Name;
            dep.Surname = user.Surname;
            dep.pass = user.pass;
            dep.UserRolID = user.UserRolID;
            dep.PhoneNumber = user.PhoneNumber;
            dep.BornDate = user.BornDate;

            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public List<AuthorizeRol.Roles> EnumArray()
        {
            var enumArray = Enum.GetValues(typeof(AuthorizeRol.Roles)).Cast<AuthorizeRol.Roles>().ToList();

            return enumArray;
        }
        public IActionResult NewUser() 
        {
            

            return View(EnumArray());
        }
        public IActionResult Login()
        {
            return View();

        }
       // NewUser
        [HttpPost]
        public IActionResult isLogin(string Email, string Password)
        {


            var result = from p in context.Userlar where p.Email == Email && p.pass == Password select p;

         

            if (!result.Any())
            {


                return Json(new { success = false, responseText = "Kullanıcı Email veya  şifre hatası" });
            }
            else
            {
                var rol = result.FirstOrDefault().UserRolID;
                return Json(new { success = true, responseText = "" + rol });


                // return Index();
            }



        }
        public IActionResult Index()
        {
            List<Users> userlarList = context.Userlar.ToList();
            return View(userlarList);
        }
        public IActionResult IndexUser()
        {
            List<Users> userlarList = context.Userlar.ToList();
            return View(userlarList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult InsertNewUser(string ID, string UserID, string Name, string Surname, string Email, string pass, DateTime BornDate, string PhoneNumber,string UserRolID)
        {
            Users u = new Users();
            u.ID = ID;
            u.UserID = UserID;
            u.Name = Name;
            u.Surname = Surname;
            u.Email = Email;
            u.pass = pass;
            u.UserRolID = UserRolID;
            u.PhoneNumber = PhoneNumber;
            u.BornDate = BornDate;

            context.Userlar.Add(u);
            //context.SaveChanges();

              return Json(new { success = true, responseText = "Eklenmiştir" });
           // return RedirectToAction("Index");
        }
    }
}
