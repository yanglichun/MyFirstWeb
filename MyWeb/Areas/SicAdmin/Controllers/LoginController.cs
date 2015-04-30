using MyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWeb.Areas.SicAdmin.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /SicAdmin/LoginManage/
        private ShareicanEntities1 db = new ShareicanEntities1();

        public ActionResult Index()
        {
            return View();
        }
        public void Validate()
        {
            string admin = Request.Form["admin"];
            string pwd = Request.Form["password"];
            Models.Admin ma = db.Admins.Where(a=>a.id==1).FirstOrDefault();
            Models.Admin pw = db.Admins.Where(a => a.id == 1).FirstOrDefault();
            if(admin==ma.ToString()&&pwd==pw.ToString())
            {

                Controllers.PageHelper.WriteJsMsg("登陆成功","/sicadmin");
            }
            //return View();
        }
    }
}
