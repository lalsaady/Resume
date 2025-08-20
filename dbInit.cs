using Microsoft.EntityFrameworkCore;
using Resume.Models;

public static class DbInit
{
    public static void Init(TerminalDbContext db)
    {
        db.Database.EnsureCreated();

        if (!db.TerminalItems.Any())
        {
            db.TerminalItems.AddRange(
                new TerminalModel("about", "Hi I’m Layla, a backend software developer based in Cleveland, Ohio. I am passionate about building APIs that enable the best user experience, advocating for political issues, and diving into the biology and psychology of the human condition."),

                new TerminalModel("languages", "Go"),
                new TerminalModel("languages", "Python"),
                new TerminalModel("languages", "JavaScript"),
                new TerminalModel("languages", "Scala"),
                new TerminalModel("languages", "SQL"),
                new TerminalModel("languages", "Lisp"),
                new TerminalModel("languages", "Ruby"),
                new TerminalModel("languages", "C#"),

                new TerminalModel("tools", "Postgres"),
                new TerminalModel("tools", "Spanner"),
                new TerminalModel("tools", "gRPC"),
                new TerminalModel("tools", "REST"),
                new TerminalModel("tools", "Kubernetes"),
                new TerminalModel("tools", "Docker"),
                new TerminalModel("tools", "Git"),
                new TerminalModel("tools", "Bash"),
                new TerminalModel("tools", "Argo"),
                new TerminalModel("tools", "GCP"),
                new TerminalModel("tools", "Workato"),
                new TerminalModel("tools", "Retool"),
                new TerminalModel("tools", "Maxio"),
                new TerminalModel("tools", "Kratos"),
                new TerminalModel("tools", "Temporal"),
                new TerminalModel("tools", "Grafana"),
                new TerminalModel("tools", "BubbleTea"),
                new TerminalModel("tools", "Pandas"),
                new TerminalModel("tools", "NumPy"),
                new TerminalModel("tools", "ASP.NET"),

                new TerminalModel("education", "B.S. in Cybersecurity, Mercyhurst University, 2022"),
                new TerminalModel("education", "M.S. in Data Science, Mercyhurst University, 2023"),

                new TerminalModel("projects", "<span class='highlight'>Terminal Resume</span>\nA browser-based, terminal-style interactive resume built with ASP.NET Core, Entity Framework Core (SQLite), and JavaScript.\n"),
                new TerminalModel("projects", "<span class='highlight'>Dispatcher</span>\nA Go app for dispatching routes to delivery drivers using K-means clustering."),

                new TerminalModel("contact", "LinkedIn: <a href=\"https://linkedin.com/in/lalsaady\">linkedin.com/in/lalsaady</a>"),
                new TerminalModel("contact", "GitHub: <a href=\"https://github.com/lalsaady\">github.com/lalsaady</a>"),

                new TerminalModel("experience", "<span class='highlight'>Censys</span>\nSoftware Engineer I\n<span class='date'>March 2023 - May 2025</span>\n"),
                new TerminalModel("experience", "<span class='highlight'>Internet 2.0</span>\nData Science Contractor\n<span class='date'>October 2022 - December 2022</span>\n"),
                new TerminalModel("experience", "<span class='highlight'>Cybersecurity Infrastructure and Security Agency (CISA)</span>\nSoftware Engineer Intern\n<span class='date'>June 2022 - August 2022</span>\n"),
                new TerminalModel("experience", "<span class='highlight'>David Corry Chrysler Dodge Jeep Ram (CDJR)</span>\nCybersecurity Analyst Team Lead\n<span class='date'>January 2022 - April 2022</span>\n"),
                new TerminalModel("experience", "<span class='highlight'>National Nuclear Security Agency (NNSA)</span>\nSupply Chain Analyst Contractor\n<span class='date'>January 2022 - April 2022</span>\n"),
                new TerminalModel("experience", "<span class='highlight'>Federal Resources Corporation</span>\nCybersecurity Analyst Intern\n<span class='date'>September 2021 - December 2021</span>")
            );

            db.SaveChanges();
        }
    }
}
