using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class User
{
    public int Id { get; set; }

    [Required]
    [MaxLength(32)]
    public string Name { get; set; }
    
    [Required]
    [MaxLength(16)]
    public string Password { get; set; }
    
    [Required]
    [MaxLength(16)]
    public string Email { get; set; }
}