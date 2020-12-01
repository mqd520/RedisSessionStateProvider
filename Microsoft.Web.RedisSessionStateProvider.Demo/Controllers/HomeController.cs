using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Microsoft.Web.RedisSessionStateProvider.Demo.Def;

namespace Microsoft.Web.RedisSessionStateProvider.Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SaveSession()
        {
            Random ran = new Random();
            int n = ran.Next(1, 100);

            Session["userData"] = new UserInfo
            {
                Id = n,
                NickName = string.Format("AAtest{0}", n.ToString().PadLeft(3, '0')),
                UserName = string.Format("AAtest{0}", n.ToString().PadLeft(3, '0')),
                ExpireTime = DateTime.Now.AddMonths(1),
                LoginIp = "127.0.0.1",
                LoginTime = DateTime.Now,
                RegisterIp = "127.0.0.1",
                RegisterTime = DateTime.Now.AddDays(-2)
            };

            return View();
        }

        public ActionResult GetSession()
        {
            var data = Session["userData"];
            var userData = data as UserInfo;
            ViewBag.UserData = data;

            return View();
        }
    }
}