using Microsoft.AspNetCore.Http;

namespace PortfolioBackend.Features.Blogs.CreateBlog;

public static class CreateBlogHandler
{
    public static async Task<IResult> CreateBlogHandle(
        CreateBlogRequest request, backendDB dbContext, CancellationToken cancellationToken)
    {
        var blog = new Blog { Title = request.Title, Content = request.Content, Date = DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm tt") };
        dbContext.Blogs.Add(blog);
        await dbContext.SaveChangesAsync(cancellationToken);

        var response = new CreateBlogResponse(blog.Id, blog.Title, blog.Content, blog.Date);
        return TypedResults.CreatedAtRoute(
            response,
            routeName: "GetBlog",
            routeValues: new { id = blog.Id });
    }
}
