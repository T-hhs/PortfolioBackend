using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace PortfolioBackend.Features.Blogs.UpdateBlog;

public static class UpdateBlogHandler
{
    public static async Task<IResult> UpdateBlogHandle(
        int id, UpdateBlogRequest request, backendDB dbContext,
        CancellationToken cancellationToken)
    {
        var blog = await dbContext.Blogs
            .FirstOrDefaultAsync(blog => blog.Id == id, cancellationToken);

        if (blog is null)
        {
            return TypedResults.NotFound();
        }

        blog.Title = request.Title;
        blog.Content = request.Content;
        blog.Date = DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm tt");
        await dbContext.SaveChangesAsync(cancellationToken);

        return TypedResults.NoContent();
    }
}
