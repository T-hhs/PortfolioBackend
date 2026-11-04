namespace PortfolioBackend.Features.Blogs.GetBlogs;

public sealed record class GetBlogsResponse(int Id, string Title, string Content, string Date);
