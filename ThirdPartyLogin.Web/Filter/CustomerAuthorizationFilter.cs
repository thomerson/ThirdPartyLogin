using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThirdPartyLogin.Web
{
    public class CustomerAuthorizationFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            var token = filterContext.HttpContext.Request.Cookies["token"];
            //Token 验证
            var result = true;
            if (!result) //如果验证没通过
            {

                //token 验证没通过 跳转到用户登录页 或者返回403
                filterContext.Result = new RedirectResult("/App/Account/Index");
            }
        }
    }
}