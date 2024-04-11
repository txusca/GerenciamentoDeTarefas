using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDeTarefas.Models;

public class Task
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public DateTime DueDate { get; set; }
    [Required]
    public int Status { get; set; }
    [Required]
    public int Priority { get; set; }
    [Required]
    public User Assignee { get; set; }
    [Required]
    public int AssigneeUserId { get; set; }
    [Required]
    public User Creator { get; set; }
    [Required]
    public int CreatorUserId { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    public ICollection<Comment> Comments { get; set; }
    [Required]
    public DateTime UpdatedAt { get; set; }
}
