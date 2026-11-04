using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace PortfolioBackend.Features.Blogs.DeleteBlog;

public static class DeleteBlogEndpoint
{
    public static RouteHandlerBuilder MapDeleteBlogEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapDelete("/delete/{id:int}", DeleteBlogHandler.DeleteBlogHandle)
            .WithName("DeleteBlog");
    }
}
