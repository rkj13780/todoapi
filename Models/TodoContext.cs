using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}

// dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
// dotnet add package Microsoft.EntityFrameworkCore.Design
// dotnet tool install --global dotnet-aspnet-codegenerator
// dotnet aspnet-codegenerator controller -name TodoItemsController -async -api -m TodoApi.Models.TodoItem -dc TodoApi.Models.TodoContext -outDir Controllers