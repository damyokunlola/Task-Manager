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
        public ActionResult Authorize(TMApp.Models.Register reg) 
        {
          

                using (TMAppContext db= new TMAppContext())
                {

                    var UserDetails = db.RegistersTable.Where(model => model.Username==(reg.Username) && model.Password==(reg.Password)).FirstOrDefault();
                    if (UserDetails != null)
                    {
                    Session["Log_Username"] = reg.Username;
                    return RedirectToAction("UserPage","Userpage");
                    }

                    else
                    {
                       
                        reg.ErrorMessage = "username or password incorrect";
                 
                        
                    }


                }
           
              return View("LoginView");
        }

                
            
          
           
        
    }
}