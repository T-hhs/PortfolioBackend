namespace PortfolioBackend.Features.Projects.CreateProject;

public sealed record class CreateProjectResponse(int Id, string Title, string Description, string Category, string GitLink, string Date);
