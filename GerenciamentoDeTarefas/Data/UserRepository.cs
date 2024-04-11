using GerenciamentoDeTarefas.Dtos;
using GerenciamentoDeTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoDeTarefas.Data;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<User> GetUsers()
    {
        return _context.Users.ToList();
    }

    public User GetUser(int id)
    {
        return _context.Users.FirstOrDefault(u => u.Id == id)!;
    }

    public User Login(User user)
    {
        return _context.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password)!;
    }

    public void RegisterUser(User user)
    {
        if (user is null)
        {
            throw new ArgumentNullException(nameof(user));
        }

        _context.Users.Add(user);
    }
    
    

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}