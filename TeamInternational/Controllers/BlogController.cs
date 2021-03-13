using Microsoft.AspNetCore.Mvc;
using TeamInternational.Application.Abstraction;
using TeamInternational.Application.Response;

namespace TeamInternational.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogApplicationService blogApplicationService;

        public BlogController(IBlogApplicationService blogApplicationService)
        {
            this.blogApplicationService = blogApplicationService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var response = blogApplicationService.Get();

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }
    }
}
