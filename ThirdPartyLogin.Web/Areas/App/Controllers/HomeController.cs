using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ThirdPartyLogin.Web.Areas.App.Controllers
{
    public class HomeController : Controller
    {
        // GET: App/Home
        public ActionResult Index(string code, string state)
        {
            var client = new HttpClient();
            var tokenUri = "http://localhost:4553/Open/Account/Token?appId=appid&secret=secret&code=code";

            var token = client.GetStringAsync(tokenUri).Result;

            //set token into cookie
            client.DefaultRequestHeaders.Add("token", token);

            var UserUri = "http://localhost:4553/Open/Account/UserInfo";
            var userJson = client.GetStringAsync(UserUri).Result;
            //Json->User
            //和app系统用户信息进行匹配
            return View();
        }
    }
}