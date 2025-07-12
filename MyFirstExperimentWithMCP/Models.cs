// Models for GitHub Issue Management

namespace MyFirstExperimentWithMCP;

/// <summary>
/// Represents a GitHub issue.
/// </summary>
public class Issue
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? State { get; set; }
    public string? Url { get; set; }
}

/// <summary>
/// Represents detailed information about a GitHub issue.
/// </summary>
public class IssueDetails : Issue
{
    public string? Body { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ClosedAt { get; set; }
    public string? Author { get; set; }
}
