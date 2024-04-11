using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDeTarefas.Models;

public class Comment
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string Content { get; set; }
    [Required]
    public User Author { get; set; }
    [Required]
    public int AuthorId { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
}
