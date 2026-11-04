using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace PortfolioBackend.Features.Projects.GetProject;

public static class GetProjectHandler
{
    public static async Task<IResult> GetProjectHandle(
        int id, backendDB dbContext, CancellationToken cancellationToken)
    {
        var proj = await dbContext.Projects
            .Where(proj => proj.Id == id)
            .Select(proj => new GetProjectResponse(proj.Id, proj.Title, proj.Description, proj.Category, proj.GitLink, proj.Date))
            .AsNoTracking()
            .FirstOrDefaultAsync(cancellationToken);

        return proj is null ? TypedResults.NotFound() : TypedResults.Ok(proj);
    }
}
