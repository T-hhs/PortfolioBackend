using System.ComponentModel.DataAnnotations;

namespace PortfolioBackend.Features.Projects.UpdateProject;
public sealed class UpdateProjectRequest
{
    [Required, StringLength(50, MinimumLength = 3)]
    public string Title {get; init;} = string.Empty;

    [Required, StringLength(255, MinimumLength = 10)]
    public string Description {get; init;} = string.Empty;

    [Required, StringLength(255, MinimumLength = 10)]
    public string GitLink {get; init;} = string.Empty;

    [Required, StringLength(50, MinimumLength = 1)]
    public string Category {get; init;} = string.Empty;
}