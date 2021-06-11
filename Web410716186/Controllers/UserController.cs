﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Web410716186.ViewModels;

namespace Web410716186.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Signup()
        {
            return View(new SignUpData());
        }

        [HttpPost]
        public ActionResult SignUp(SignUpData data)
         {
            

            if(ModelState.IsValid)
            {
                data.Message = "註冊成功";
            }
            return View(data);
        }
    }
}