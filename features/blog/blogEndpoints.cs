using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using PortfolioBackend.Features.Blogs.CreateBlog;
using PortfolioBackend.Features.Blogs.GetBlog;
using PortfolioBackend.Features.Blogs.DeleteBlog;
using PortfolioBackend.Features.Blogs.GetBlogs;
using PortfolioBackend.Features.Blogs.UpdateBlog;

namespace PortfolioBackend.Features.Blogs;

public static class BlogEndpoints
{
    public static RouteGroupBuilder MapAllBlogEndpoints(this IEndpointRouteBuilder endpoints)
    {
        RouteGroupBuilder blogGroup = endpoints.MapGroup("/blogs").WithTags("Blogs");

        blogGroup.MapCreateBlogEndpoint();
        blogGroup.MapGetBlogEndpoint();
        blogGroup.MapGetBlogsEndpoint();
        blogGroup.MapUpdateBlogEndpoint();
        blogGroup.MapDeleteBlogEndpoint();



        return blogGroup;
    }
}
