namespace PortfolioBackend.Features.Projects.GetProject;

public sealed record class GetProjectResponse(int Id, string Title, string Description, string Category, string GitLink, string Date);
