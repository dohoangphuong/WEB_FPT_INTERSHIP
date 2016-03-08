using Chapter03._2_MVC_Entity_TaiKhoan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chapter03._2_MVC_Entity_TaiKhoan.Controllers
{
    public class TaiKhoanController : Controller
    {
        //database
        protected ACCOUNT_LINQEntities account_all = new ACCOUNT_LINQEntities();
        //
        // GET: /TaiKhoan/

        public ActionResult Index()
        {
            return View("TaiKhoan", account_all.Account);
        }

        public ActionResult EditAccount()
        {
            return View("EditAccount");
        }

        //[HttpPost]        //chỉ dùng cho post
        public ActionResult SelectAccount(Account acc)
        {
            return View("EditAccount", acc);
            // return RedirectToAction("Index"); //trở về hàm "Index" 
        }
    }
}
