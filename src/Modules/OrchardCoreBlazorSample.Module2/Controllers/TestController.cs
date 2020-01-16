using Microsoft.AspNetCore.Mvc;

namespace OrchardCoreBlazorSample.Module2.Controllers
{
    // Sample controller for displaying a parameterized Blazor component implemented in OrchardCoreBlazorSample.Module1.Blazor project.
    public class TestController : Controller
    {
        [Route("test/module2")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
