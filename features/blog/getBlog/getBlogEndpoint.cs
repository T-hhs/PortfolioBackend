using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace PortfolioBackend.Features.Blogs.GetBlog;

public static class GetBlogEndpoint
{
    public static RouteHandlerBuilder MapGetBlogEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapGet("/get/{id:int}", GetBlogHandler.GetBlogHandle)
            .WithName("GetBlog");
    }
}
