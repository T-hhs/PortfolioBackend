namespace PortfolioBackend.Features.Blogs.GetBlog;

public sealed record class GetBlogResponse(int Id, string Title, string Content, string Date);
