using iMessenger.Contract;

using iMessenger.Shared.Services.Api;

using Microsoft.AspNetCore.Mvc;

namespace iMessengerCoreAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RGDialogsClientsController : Controller
{
    private readonly IRGDialogsClientsService _RGDialogsClientsService;

    public RGDialogsClientsController(
        IRGDialogsClientsService rGDialogsClientsService)
    {
        _RGDialogsClientsService = rGDialogsClientsService;
    }

    [HttpGet("get")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(void), StatusCodes.Status404NotFound)]
    public async Task<ActionResult<object>> Get(
    [FromQuery] string[] ids)
    {
        return await _RGDialogsClientsService.Get(ids)
            .WithActionResult()
            .ConfigureAwait(false);
    }
}