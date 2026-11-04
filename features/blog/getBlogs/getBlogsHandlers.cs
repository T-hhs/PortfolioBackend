using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace PortfolioBackend.Features.Blogs.GetBlogs;

public static class GetBlogsHandler
{
    public static async Task<IResult> GetBlogsHandle(
        backendDB dbContext, CancellationToken cancellationToken)
    {
        var blogs = await dbContext.Blogs
            .AsNoTracking()
            .OrderBy(blog => blog.Id)
            .Select(blog => new GetBlogsResponse(blog.Id, blog.Title, blog.Content, blog.Date))
            .ToListAsync(cancellationToken);

        return TypedResults.Ok(blogs);
    }
}
