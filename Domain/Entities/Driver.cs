using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Driver
{
    public int Id { get; set; }
    
    [Required]
    public int UserId { get; set; }

    public User User { get; set; }
}