﻿using CatchUpPlatform.API.News.Domain.Model.Commands;
using CatchUpPlatform.API.News.Interfaces.REST.Resources;

namespace CatchUpPlatform.API.News.Interfaces.REST.Transform;

public static class CreateFavoriteSourceCommandFromResourceAssembler
{
                                                                //ASEGURATE DE LLAMAR AL RESOURCE GILAZO
    public static CreateFavoriteSourceCommand ToCommandFromResource(CreateFavoriteSourceResource resource)
    {
        return new CreateFavoriteSourceCommand(resource.NewsApiKey, resource.SourceId);
    }
}