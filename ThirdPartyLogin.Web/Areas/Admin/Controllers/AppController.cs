using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThirdPartyLogin.Model;

namespace ThirdPartyLogin.Web.Areas.Admin.Controllers
{
    public class AppController : Controller
    {
        // GET: Admin/App
        public ActionResult Index()
        {
            return View();
        }

        //TODO 分页
        [HttpGet]
        public ActionResult Search(Application query)
        {
            var list = new List<Application>()
            {
                new Application(){ AppId = "WX10001",Name="微信",Description = "微信公众号",IsDisabled=false,IsPassed=true},
                new Application(){ AppId = "WX10002",Name="微信",Description = "微信小程序",IsDisabled = true,IsPassed=false},
                new Application(){ AppId = "QQ10001",Name="QQ",Description = "QQ",IsDisabled=false,IsPassed=true},
                new Application(){ AppId = "WB10003",Name="微博",Description = "微博",IsDisabled=false,IsPassed=true},
                new Application(){ AppId = "GG10004",Name="谷歌",Description = "谷歌",IsDisabled=false,IsPassed=true},
                new Application(){ AppId = "BD10005",Name="百度",Description = "百度",IsDisabled=false,IsPassed=true,}
            };
            var result = list.Where(w => true);
            if (query.IsDisabled != null)
            {
                result = result.Where(w => w.IsDisabled == query.IsDisabled);
            }
            if (query.IsPassed != null)
            {
                result = result.Where(w => w.IsPassed == query.IsPassed);
            }
            if (!string.IsNullOrWhiteSpace(query.AppId))
            {
                result = result.Where(w => w.AppId == query.AppId);
            }
            return Json(result.ToList(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult Audit(string appId)
        {
            return Json(true);
        }

        /// <summary>
        /// 禁用
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public ActionResult Disable(string appId)
        {
            return Json(true);
        }
    }
}