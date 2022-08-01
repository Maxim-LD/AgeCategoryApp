using AgeCategoryApp.Logic;
using Microsoft.AspNetCore.Mvc;

namespace AgeCategoryApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgeCategoryAppServiceController : ControllerBase
    {
        private readonly IAgeCategoryAppService _ageCategory;
        public AgeCategoryAppServiceController(IAgeCategoryAppService ageCategory)
        {
            _ageCategory = ageCategory;
        }
        [HttpGet]
        public IActionResult GetAge(int age)
        {
            var result = _ageCategory.GetAge(age);
            return Ok(result);
        }
    }
}
