
using MyFirstExperimentWithMCP;

namespace MyFirstExperimentWithMCP;

internal class Program
{
    private static async Task Main(string[] args)
    {
        await DisplayMenuAsync();
    }

    /// <summary>
    /// Displays the interactive menu and handles user selection.
    /// </summary>
    private static async Task DisplayMenuAsync()
    {
        while (true)
        {
            Console.WriteLine("\nGitHub Issue Management Console");
            Console.WriteLine("1. List open issues");
            Console.WriteLine("2. See details of a selected issue");
            Console.WriteLine("3. Delete an issue");
            Console.WriteLine("0. Exit");
            Console.Write("Select an option: ");

            var input = Console.ReadLine();
            if (!int.TryParse(input, out var option))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (option)
            {
                case 1:
                    await ListOpenIssuesAsync();
                    break;
                case 2:
                    await SeeIssueDetailsAsync();
                    break;
                case 3:
                    await DeleteIssueAsync();
                    break;
                case 0:
                    Console.WriteLine("Exiting application.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    /// <summary>
    /// Lists open issues from GitHub.
    /// </summary>
    private static async Task ListOpenIssuesAsync()
    {
        // TODO: Implement GitHub API call to list open issues
        Console.WriteLine("[Stub] Listing open issues...");
        await Task.Delay(500);
    }

    /// <summary>
    /// Prompts for an issue ID and displays its details.
    /// </summary>
    private static async Task SeeIssueDetailsAsync()
    {
        Console.Write("Enter Issue ID: ");
        var input = Console.ReadLine();
        if (!int.TryParse(input, out var issueId))
        {
            Console.WriteLine("Invalid Issue ID.");
            return;
        }
        // TODO: Implement GitHub API call to get issue details
        Console.WriteLine($"[Stub] Showing details for issue {issueId}...");
        await Task.Delay(500);
    }

    /// <summary>
    /// Prompts for an issue ID and deletes the issue.
    /// </summary>
    private static async Task DeleteIssueAsync()
    {
        Console.Write("Enter Issue ID to delete: ");
        var input = Console.ReadLine();
        if (!int.TryParse(input, out var issueId))
        {
            Console.WriteLine("Invalid Issue ID.");
            return;
        }
        // TODO: Implement GitHub API call to delete the issue
        Console.WriteLine($"[Stub] Deleting issue {issueId}...");
        await Task.Delay(500);
    }
}
