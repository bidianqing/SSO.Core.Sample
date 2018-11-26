using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Order.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index(string returnUrl)
        {
            return Redirect(string.Concat("http://passport.domain.localhost/login?returnUrl=http://order.domain.localhost", returnUrl));
        }
    }
}
