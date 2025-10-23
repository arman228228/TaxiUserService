using System.ComponentModel.DataAnnotations;

namespace Application.DTOs;

public class DriverDto
{
    [Required]
    [MaxLength(32)]
    public string Name { get; set; }
    
    [Required]
    public int UserId { get; set; } 
}