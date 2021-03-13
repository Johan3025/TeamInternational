using Microsoft.AspNetCore.Mvc;
using TeamInternational.Application.Abstraction;
using TeamInternational.Application.Request;
using TeamInternational.Application.Response;

namespace TeamInternational.Api.Controllers
{
    [Route("api/v1/[controller]")]
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
            var response = blogApplicationService.GetAll();

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("~/api/v1/[controller]/{id}/[action]", Name = "GetPlayerById")]
        public IActionResult GetPlayerById(int id)
        {
            var response =  blogApplicationService.GetPlayerById(id);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpPost("[action]")]
        public IActionResult CreateBlog([FromBody] BlogRequest blogRequest)
        { 
            var response = blogApplicationService.AddBlog(blogRequest);

            return Created("Post", response);
        }

        [HttpPost("[action]")]
        public IActionResult UpdateBlog([FromBody] BlogRequest blogRequest)
        {
            var response = blogApplicationService.UpdateBlog(blogRequest);

            return Created("Post", response);
        }

        [HttpDelete("[action]")]
        public IActionResult DeleteBlog ([FromBody] BlogRequest blogRequest)
        {
            var response = blogApplicationService.DeleteBlog(blogRequest);

            if (response)
            {
                return Ok();
            }
            else
            {
                return NoContent();
            }
        }
    }
}
