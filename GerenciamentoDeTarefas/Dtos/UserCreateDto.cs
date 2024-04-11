using System.ComponentModel.DataAnnotations;
using GerenciamentoDeTarefas.Helpers;

namespace GerenciamentoDeTarefas.Dtos;

public class UserCreateDto
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public int PermisionLevel { get; set; }
    
    public bool ValidPassword(string password)
    {
        return Password == password.GenerateHash();
    }

    public void SetPasswordHash()
    {
        Password = Password.GenerateHash();
    }
}