using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chapter02_MVC_LinQ.Models;

namespace Chapter02_MVC_LinQ.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        AccountDataContext db = new AccountDataContext(); 

        public ActionResult Index()
        {
           /* var a = db.SelectAccount();//Store Procedure
            return View("Account", a);*/

            return View("Account", db.Accounts.ToList());
            //    return View("Account");
        }

    }
}
