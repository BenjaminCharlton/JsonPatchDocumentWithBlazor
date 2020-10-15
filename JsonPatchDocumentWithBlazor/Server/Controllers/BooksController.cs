using JsonPatchDocumentWithBlazor.Shared;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonPatchDocumentWithBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private static readonly List<Book> _books = new List<Book>()
        {
            new Book() { Id = 123, Title="How to make JsonPatchDocument work with Blazor - First Edition" },
            new Book() { Id = 211, Title="Setting properties of the HTML body element in Blazor" },
            new Book() { Id = 101, Title="Why ASP.NET Core Web API ignores TypeConverters in HTTP requests" },
        };


        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            // We're just going to fake an asynchronous database call and return a 200 status code to the client
            await Task.FromResult(true);
            return Ok(_books);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            // We're just going to fake an asynchronous database call and return a 200 status code to the client
            await Task.FromResult(true);
            return Ok(_books.Where(b => b.Id == id).FirstOrDefault());
        }

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
