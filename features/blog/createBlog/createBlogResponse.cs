namespace PortfolioBackend.Features.Blogs.CreateBlog;

public sealed record class CreateBlogResponse(int Id, string Title, string Content, string Date);
