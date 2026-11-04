using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace PortfolioBackend.Features.Projects.DeleteProject;

public static class DeleteProjectEndpoint
{
    public static RouteHandlerBuilder MapDeleteProjectEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapDelete("/delete/{id:int}", DeleteProjectHandler.DeleteProjectHandle)
            .WithName("DeleteProject");
    }
}
