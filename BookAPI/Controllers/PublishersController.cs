using BookAPI.Data;
using BookAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        public PublishersService PublishersService { get; set; }
        public PublishersController(PublishersService publishersService)
        {
            PublishersService = publishersService;
        }

        [HttpPost]
        public IActionResult AddPublisher([FromBody] PublisherVM publisher)
        {
            PublishersService.AddPublisher(publisher);
            return Ok();
        }

        [HttpDelete("id")]
        public IActionResult DeletePublisher([FromQuery] int id)
        {
            PublishersService.DeletePublisher(id);
            return Ok();
        }
    }
}
