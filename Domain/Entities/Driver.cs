using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Driver
{
    public int Id { get; set; }
    
    [Required]
    [MaxLength(32)]
    public string Name { get; set; }
    
    [Required]
    public int UserId { get; set; }

    public User User { get; set; }
}