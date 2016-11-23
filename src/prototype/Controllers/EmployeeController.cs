// using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace prototype
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
	{
        public IActionResult Get()
        {
            var message = "Hello World!";
            return Json(message);
        }
    }
}
