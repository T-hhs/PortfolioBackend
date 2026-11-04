using System.ComponentModel.DataAnnotations;

namespace PortfolioBackend.Features.Blogs.UpdateBlog;
public sealed class UpdateBlogRequest
{
    [Required, StringLength(50, MinimumLength = 3)]
    public string Title {get; init;} = string.Empty;

    [Required, StringLength(255, MinimumLength = 10)]
    public string Content {get; init;} = string.Empty;
}