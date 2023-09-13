using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

// $ The database context is the main class that coordinates Entity Framework functionality for a data model. This class is created by deriving from the Microsoft.EntityFrameworkCore.DbContext class.
public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
    /* 
        - null! indicates that the default value is null but that the compiler should treat it as "not null". 
        - This means that the compiler understands that even though the value is set to null, null values ​​will not be allowed for this property at run time.
    */
}