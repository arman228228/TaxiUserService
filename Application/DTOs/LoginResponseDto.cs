using System.ComponentModel.DataAnnotations;

namespace Application.DTOs;

public class LoginDto
{
    [Required]
    [MaxLength(64)]
    public string Email { get; set; }
    
    [Required]
    [MaxLength(16)]
    public string Password { get; set; }
}