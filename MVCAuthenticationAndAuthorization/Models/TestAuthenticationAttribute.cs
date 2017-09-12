using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace MVCAuthenticationAndAuthorization.Models
{
    public class TestAuthenticationAttribute : FilterAttribute, IAuthenticationFilter
    {
        
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if(filterContext.HttpContext.User.Identity.IsAuthenticated)
            {

            }
            else
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
            
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            //throw new NotImplementedException();
        }
    }
}