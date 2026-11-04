using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace PortfolioBackend.Features.Projects.DeleteProject;

public static class DeleteProjectHandler
{
    public static async Task<IResult> DeleteProjectHandle(
        int id, backendDB dbContext, CancellationToken cancellationToken)
    {
        var proj = await dbContext.Projects
            .FirstOrDefaultAsync(proj => proj.Id == id, cancellationToken);

        if (proj is null)
        {
            return TypedResults.NotFound();
        }

        dbContext.Projects.Remove(proj);
        await dbContext.SaveChangesAsync(cancellationToken);

        return TypedResults.NoContent();
    }
}
