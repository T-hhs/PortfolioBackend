using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace PortfolioBackend.Features.Projects.GetProjects;

public static class GetProjectsHandler
{
    public static async Task<IResult> GetProjectsHandle(
        backendDB dbContext, CancellationToken cancellationToken)
    {
        var projects = await dbContext.Projects
            .AsNoTracking()
            .OrderBy(proj => proj.Id)
            .Select(proj => new GetProjectsResponse(proj.Id, proj.Title, proj.Description, proj.Category, proj.GitLink, proj.Date))
            .ToListAsync(cancellationToken);

        return TypedResults.Ok(projects);
    }
}
