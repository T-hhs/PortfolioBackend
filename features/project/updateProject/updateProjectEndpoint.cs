using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace PortfolioBackend.Features.Projects.UpdateProject;

public static class UpdateProjectEndpoint
{
    public static RouteHandlerBuilder MapUpdateProjectEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapPut("/update/{id:int}", UpdateProjectHandler.UpdateProjectHandle)
            .WithName("UpdateProject");
    }
}
