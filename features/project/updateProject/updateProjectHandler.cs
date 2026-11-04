using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace PortfolioBackend.Features.Projects.UpdateProject;

public static class UpdateProjectHandler
{
    public static async Task<IResult> UpdateProjectHandle(
        int id, UpdateProjectRequest request, backendDB dbContext,
        CancellationToken cancellationToken)
    {
        var proj = await dbContext.Projects
            .FirstOrDefaultAsync(proj => proj.Id == id, cancellationToken);

        if (proj is null)
        {
            return TypedResults.NotFound();
        }

        proj.Title = request.Title;
        proj.Description = request.Description;
        proj.Category = request.Category;
        proj.Date = DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm tt");
        await dbContext.SaveChangesAsync(cancellationToken);

        return TypedResults.NoContent();
    }
}
