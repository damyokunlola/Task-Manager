using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMApp.Models;

namespace TMApp.Controllers
{
    public class LoginController : Controller
    {
        
       
        
        public ActionResult LoginView()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Authorize(TMApp.Models.Register reg,TMApp.Models.UserLogin LogUse) 
        {
          
                using (TMAppContext db= new TMAppContext())
                {
                    var UserDetails = db.RegistersTable.Where(model => model.Username==(reg.Username) && model.Password==(reg.Password)).FirstOrDefault();
                    if (UserDetails != null)
                    {

                    UserLogin Login = new UserLogin();

                     Login.Username = reg.Username;
                    Login.Password = reg.Password;
                    Login.LoginDate = DateTime.Now;

                    db.UserLoginsTable.Add(Login);
                    db.SaveChanges();
               

                    Session["Username"] = Login.Username;
                    Session["Email"] = UserDetails.Email; 
                    return RedirectToAction("UserPage","UserPage");
                    }

                    else
                    {
                    TempData["Errormsg"] = "<script> alert('Wrong Username or Password');</script>";
                    return View("LoginView");


                }


                }
           
             
        }

                
            
          
           
        
    }
}