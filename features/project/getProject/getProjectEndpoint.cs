using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace PortfolioBackend.Features.Projects.GetProject;

public static class GetProjectEndpoint
{
    public static RouteHandlerBuilder MapGetProjectEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapGet("/get/{id:int}", GetProjectHandler.GetProjectHandle)
            .WithName("GetProject");
    }
}
