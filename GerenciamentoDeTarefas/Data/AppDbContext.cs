using GerenciamentoDeTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoDeTarefas.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Models.Task> Tasks { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
    {

    }
}
