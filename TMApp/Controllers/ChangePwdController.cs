using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMApp.Models;

namespace TMApp.Controllers
{
    public class ChangePwdController : Controller
    {
        // GET: ChangePwd
        public ActionResult ChangePwdView()
        {
            return View();
        }

        //    public ActionResult ChangePwd( string New, Register User)
        //    {

        //        string NewPwd = Convert.ToString(Request["txtPwd"].ToString());
        //        string Email = (string)Session["Email"];
        //        TMAppContext db = new TMAppContext();
        //        var VerifyUser = db.RegistersTable.Where(m => m.Password.Equals(User.Password) && m.Email.Equals(Email)).FirstOrDefault();
        //        if (VerifyUser != null)
        //        {
        //            VerifyUser.Password = NewPwd; ;
        //            db.SaveChanges();
        //            TempData["msg"] = "<script>alert('Passowrd Reset');</script>";
        //        }
        //        else
        //        {

        //            TempData["Error"] = "<script>alert('Incorrect Password');</script>";
        //        }

        //        return View();
        //    }


        //}
    }
}