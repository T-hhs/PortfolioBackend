namespace PortfolioBackend.Features.Projects.GetProjects;

public sealed record class GetProjectsResponse(int Id, string Title, string Description, string Category, string GitLink, string Date);
