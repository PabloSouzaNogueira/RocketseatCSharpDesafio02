using Microsoft.AspNetCore.Mvc;
using RocketseatCSharpDesafio02.Entities;
using RocketseatCSharpDesafio02.Models.Responses;

namespace RocketseatCSharpDesafio02.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : Controller
{
    readonly IBookService _bookService;

    public BookController(IBookService bookService) : base()
    {
        _bookService = bookService;
    }

    // GET api/<BookController>/5
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(BaseResponse<BookResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status404NotFound)]
    public IActionResult GetBook([FromRoute] int id)
    {
        var book = _bookService.GetBook(id);

        if(book != null)
            return Created(string.Empty, new { Data = book });

        return NotFound(new { Data = "Erro na requisição." });
    }

    // POST api/<BookController>
    [HttpPost]
    [ProducesResponseType(typeof(BaseResponse<int>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
    public IActionResult CreateBook([FromBody] BookRequest bookRequest)
    {
        var bookId = _bookService.CreateBook(bookRequest);

        if (bookId.HasValue)
            return Created(string.Empty, new { Data = bookId });

        return BadRequest(new { Data = "Erro na requisição." });
    }

    // PUT api/<BookController>/5
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
    public IActionResult UpdateBook([FromRoute] int id, [FromBody] BookRequest bookRequest)
    {
        var bookId = _bookService.UpdateBook(id, bookRequest);

        if (bookId.HasValue)
            return NoContent();

        return BadRequest(new { Data = "Erro na requisição." });
    }

    // DELETE api/<BookController>/5
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
    public IActionResult DeleteBook(int id)
    {
        var bookId = _bookService.DeleteBook(id);

        if (bookId.HasValue)
            return NoContent();

        return BadRequest(new { Data =  "Erro na requisição." });
    }
}