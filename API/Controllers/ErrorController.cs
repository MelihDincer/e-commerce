using Microsoft.AspNetCore.Mvc;

namespace API;

[ApiController]
[Route("/api/[controller]")]
public class ErrorController : ControllerBase 
{
    [HttpGet("not-found")]
    public IActionResult NotFoundError()
    {
        return NotFound();
    }

    [HttpGet("bad-request")]
    public IActionResult BadRequestError()
    {
        return BadRequest("Geçersiz istek.");
    }

    [HttpGet("unauthorized")]
    public IActionResult UnAuthorizedError()
    {
        return Unauthorized("Yetkiniz bulunmamaktadır!");
    }

    [HttpGet("validation-error")]
    public IActionResult ValidationError()
    {
        ModelState.AddModelError("validation error 1", "validation error details");
        ModelState.AddModelError("validation error 2", "validation error details");
        return ValidationProblem();
    }

    [HttpGet("server-error")]
    public IActionResult ServerError()
    {
        throw new Exception("server error");
    }
}