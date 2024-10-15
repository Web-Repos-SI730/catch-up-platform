using System.Net.Mime;
using CatchUpPlatform.API.News.Domain.Services;
using CatchUpPlatform.API.News.Interfaces.REST.Resources;
using CatchUpPlatform.API.News.Interfaces.REST.Transform;
using CatchUpPlatform.API.News.Shared.Domain.Model.Queries;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CatchUpPlatform.API.News.Interfaces.REST;

[ApiController]
[Route("api/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[Tags("Favorite Sources")]
public class FavoriteSourcesController(
    IFavoriteSourceCommandService favoriteSourceCommandService,
    IFavoriteSourceQueryService favoriteSourceQueryService
) : ControllerBase
{
    [HttpPost]
    [SwaggerOperation(
        Summary = "Create a new favorite source",
        Description = "Create a new favorite source within the specified news API Key",
        OperationId = "CreateFavoriteSource")
    ]

    [SwaggerResponse(StatusCodes.Status201Created, "The favorite source was created", typeof(FavoriteSourceResource))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "The request is invalid")]

    public async Task<ActionResult> CreateFavoriteSource([FromBody] CreateFavoriteSourceResource resource)
    {
        var createFavoriteSourceCommand =
            CreateFavoriteSourceCommandFromResourceAssembler.ToCommandFromResource(resource);
        var result = await favoriteSourceCommandService.Handle(createFavoriteSourceCommand);
        if (result is null) return BadRequest();
        return CreatedAtAction(nameof(GetFavoriteSourceById), new { id = result.Id },
            FavoriteSourceResourceFromEntityAssembler.ToResourceFromEntity(result));
    }
    [HttpGet("{id}")]
    [SwaggerOperation(
        Summary = "Get favorite source by id",
        Description = "Get favorite source by id",
        OperationId = "GetFavoriteSourceById")
    ]
    [SwaggerResponse(StatusCodes.Status200OK, "The favorite source was found", typeof(FavoriteSourceResource))]
    [SwaggerResponse(StatusCodes.Status404NotFound, "The favorite source was not found")]
    public async Task<ActionResult> GetFavoriteSourceById(int id)
    {
        var getFavoriteSourceByIdQuery = new GetFavoriteSourceByIdQuery(id);
        var result = await favoriteSourceQueryService.Handle(getFavoriteSourceByIdQuery);
        if (result is null) return NotFound();
        var resource = FavoriteSourceResourceFromEntityAssembler.ToResourceFromEntity(result);
        return Ok(resource);
    }



}