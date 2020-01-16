using Microsoft.AspNetCore.Mvc;

namespace OrchardCoreBlazorSample.Module1.Controllers
{
    // Sample controller for displaying a Blazor component implemented in OrchardCoreBlazorSample.Module1.Blazor project.
    public class TestController : Controller
    {
        [Route("test/module1")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
