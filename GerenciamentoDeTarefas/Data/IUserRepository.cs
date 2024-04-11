using GerenciamentoDeTarefas.Models;

namespace GerenciamentoDeTarefas.Data;

public interface IUserRepository
{
    IEnumerable<User> GetUsers();
    User GetUser(int id);
    User Login(User user);
    void RegisterUser(User user);
    void SaveChanges();
}
