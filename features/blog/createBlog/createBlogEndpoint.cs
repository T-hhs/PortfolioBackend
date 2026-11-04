using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace PortfolioBackend.Features.Blogs.CreateBlog;

public static class CreateBlogEndpoint
{
    public static RouteHandlerBuilder MapCreateBlogEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapPost("/create", CreateBlogHandler.CreateBlogHandle)
            .WithName("CreateBlog");
    }
}
