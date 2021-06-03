using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;

namespace Web410716186.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(string name,string account,string password)
         {
            if (name.IsNullOrWhiteSpace())
            {
                ViewBag.NameMessage = "請輸入姓名";
            }
            if (account.IsNullOrWhiteSpace())
            {
                ViewBag.accountMessage = "請輸入帳號";
            }
            if (password.IsNullOrWhiteSpace())
            {
                ViewBag.passwordMessage = "請輸入密碼";
            }

            if(name.IsNullOrWhiteSpace() == false &&
                !account.IsNullOrWhiteSpace() &&
                 !password.IsNullOrWhiteSpace())
            {
                ViewBag.Message = "註冊成功";
            }
            return View();
        }
    }
}