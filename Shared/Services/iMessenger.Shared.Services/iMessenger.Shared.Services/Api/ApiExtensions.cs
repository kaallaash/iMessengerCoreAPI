﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace iMessenger.Shared.Services.Api;

public static class ApiExtensions
{
    public static async Task<ActionResult<TResult>> WithActionResult<TResult>(this Task<TResult> task)
    {
        try
        {
            var result = await task;

            return new OkObjectResult(result);
        }
        catch (ApiException e) when (e.StatusCode == StatusCodes.Status404NotFound)
        {
            return new NotFoundResult();
        }
    }
}
