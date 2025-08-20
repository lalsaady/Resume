using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Models;

namespace Resume.Controllers;

[ApiController]
[Route("/")]
public class TerminalController : Controller
{
    private readonly TerminalDbContext _db;

    public TerminalController(TerminalDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("run")]
    public async Task<IActionResult> Run([FromQuery] string? cmd)
    {
        // If no command is provided, return a blank output
        if (string.IsNullOrWhiteSpace(cmd))
            return Ok(new { output = " " });

        // Handle the 'clear' command
        if (string.Equals(cmd, "clear", StringComparison.OrdinalIgnoreCase))
            return Ok(new { clear = true });

        // Handle the 'help' command
        if (string.Equals(cmd.Trim(), "help", StringComparison.OrdinalIgnoreCase))
        {
            return Ok(new
            {
                output = @"Available commands:
- help           Show help
- about          About me
- education      Education background
- languages      Programming languages I can use
- tools          Technologies I am familiar with
- experience     Work history
- projects       Personal projects
- contact        How to reach me
- clear          Clear the screen"
            });
        }

        // Query database for items of the command type
        var items = await _db.TerminalItems
            .Where(x => x.Type.Trim().ToLower() == cmd.Trim().ToLower())
            .Select(x => x.Item)
            .ToListAsync();

        Console.WriteLine($"[RunCommand] cmd='{cmd}', matched {items.Count} item(s).");

        // If no items found, return a not found message
        if (!items.Any())
            return Ok(new { output = "Command not found, type 'help' to see available commands." });

        // Join the items by newlines
        var output = string.Join("\n", items);
        return Ok(new { output });
    }
}
