using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThirdPartyLogin.Model;

namespace ThirdPartyLogin.Web.Areas.Open.Controllers
{
    public class AccountController : Controller
    {
        // GET: Open/Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            return Json(true);
        }

        /// <summary>
        /// ThirdParty login
        /// </summary>
        /// <param name="appid"></param>
        /// <param name="redirectUri"></param>
        /// <returns></returns>
        public ActionResult Oauth(string appid, string redirectUri)
        {
            return View();
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(string userName, string password)
        {
            return Json(true);
        }

        [HttpGet]
        public ActionResult Token(string appId, string secret, string code)
        {
            //验证appid和secret
            //使用code生成对应user的token
            return Json(Guid.NewGuid(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 刷新token
        /// </summary>
        /// <returns></returns>
        [CustomerAuthorizationFilter]
        [HttpGet]
        public ActionResult Reflesh()
        {
            return Json(Guid.NewGuid(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 需要token验证才能拿到用户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [CustomerAuthorizationFilter]
        public ActionResult UserInfo()
        {
            //TODO veriry token 
            //找到这个token对应的用户信息
            var user = new User();
            return Json(user, JsonRequestBehavior.AllowGet);
        }
    }
}