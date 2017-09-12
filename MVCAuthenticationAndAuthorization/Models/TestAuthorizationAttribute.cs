using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuthenticationAndAuthorization.Models
{
    public class TestAuthorizationAttribute : FilterAttribute, IAuthorizationFilter
    {
        public string _roles;
        public TestAuthorizationAttribute(params string[] roles)
        {
           // _roles = roles;
        }
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            //throw new NotImplementedException();
        }
    }
}