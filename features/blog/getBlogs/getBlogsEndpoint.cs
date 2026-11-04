using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace PortfolioBackend.Features.Blogs.GetBlogs;

public static class GetBlogsEndpoint
{
    public static RouteHandlerBuilder MapGetBlogsEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapGet("/get", GetBlogsHandler.GetBlogsHandle)
            .WithName("GetBlogs");
    }
}
