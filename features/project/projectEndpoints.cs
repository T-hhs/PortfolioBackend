using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using PortfolioBackend.Features.Projects.CreateProject;
using PortfolioBackend.Features.Projects.GetProject;
using PortfolioBackend.Features.Projects.DeleteProject;
using PortfolioBackend.Features.Projects.GetProjects;
using PortfolioBackend.Features.Projects.UpdateProject;

namespace PortfolioBackend.Features.Projects;

public static class ProjectEndpoints
{
    public static RouteGroupBuilder MapAllProjectEndpoints(this IEndpointRouteBuilder endpoints)
    {
        RouteGroupBuilder projectGroup = endpoints.MapGroup("/projects").WithTags("Projects");

        projectGroup.MapCreateProjectEndpoint();
        projectGroup.MapGetProjectEndpoint();
        projectGroup.MapGetProjectsEndpoint();
        projectGroup.MapUpdateProjectEndpoint();
        projectGroup.MapDeleteProjectEndpoint();



        return projectGroup;
    }
}
