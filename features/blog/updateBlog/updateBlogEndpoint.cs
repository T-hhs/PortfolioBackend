using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace PortfolioBackend.Features.Blogs.UpdateBlog;

public static class UpdateBlogEndpoint
{
    public static RouteHandlerBuilder MapUpdateBlogEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapPut("/update/{id:int}", UpdateBlogHandler.UpdateBlogHandle)
            .WithName("UpdateBlog");
    }
}
