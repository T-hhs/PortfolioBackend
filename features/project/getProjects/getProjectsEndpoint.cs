using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace PortfolioBackend.Features.Projects.GetProjects;

public static class GetProjectsEndpoint
{
    public static RouteHandlerBuilder MapGetProjectsEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapGet("/get", GetProjectsHandler.GetProjectsHandle)
            .WithName("GetProjects");
    }
}
