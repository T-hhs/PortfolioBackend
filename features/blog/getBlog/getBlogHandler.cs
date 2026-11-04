using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace PortfolioBackend.Features.Blogs.GetBlog;

public static class GetBlogHandler
{
    public static async Task<IResult> GetBlogHandle(
        int id, backendDB dbContext, CancellationToken cancellationToken)
    {
        var blog = await dbContext.Blogs
            .Where(blog => blog.Id == id)
            .Select(blog => new GetBlogResponse(blog.Id, blog.Title, blog.Content, blog.Date))
            .AsNoTracking()
            .FirstOrDefaultAsync(cancellationToken);

        return blog is null ? TypedResults.NotFound() : TypedResults.Ok(blog);
    }
}
