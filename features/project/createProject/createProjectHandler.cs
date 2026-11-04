using Microsoft.AspNetCore.Http;

namespace PortfolioBackend.Features.Projects.CreateProject;

public static class CreateProjectHandler
{
    public static async Task<IResult> CreateProjectHandle(
        CreateProjectRequest request, backendDB dbContext, CancellationToken cancellationToken)
    {
        var proj = new Project { Title = request.Title, Description = request.Description, Category = request.Category, GitLink = request.GitLink, Date = DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm tt") };
        dbContext.Projects.Add(proj);
        await dbContext.SaveChangesAsync(cancellationToken);

        var response = new CreateProjectResponse(proj.Id, proj.Title, proj.Description, proj.Category, proj.GitLink, proj.Date);
        return TypedResults.CreatedAtRoute(
            response,
            routeName: "GetProject",
            routeValues: new { id = proj.Id });
    }
}
