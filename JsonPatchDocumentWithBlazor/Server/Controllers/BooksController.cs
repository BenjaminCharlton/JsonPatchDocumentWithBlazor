using JsonPatchDocumentWithBlazor.Shared;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JsonPatchDocumentWithBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        [HttpPatch("{id:int}")]
        public async Task<ActionResult> PatchAsync(
            int id,
            [FromBody] JsonPatchDocument<Book> patch)
        {
            // We're just going to fake an asynchronous database call and return a 200 status code to the client
            await Task.FromResult(true);
            return Ok();
        }
    }
}
