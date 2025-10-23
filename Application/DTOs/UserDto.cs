using System.ComponentModel.DataAnnotations;

namespace Application.DTOs;

public class UserDto
{
    [Required]
    [MaxLength(32)]
    public string Name { get; set; }
    
    [Required]
    [MaxLength(16)]
    public string Password { get; set; }
}