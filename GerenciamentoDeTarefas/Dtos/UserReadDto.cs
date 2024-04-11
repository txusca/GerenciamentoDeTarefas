using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDeTarefas.Dtos;

public class UserReadDto
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int PermisionLevel { get; set; }
}