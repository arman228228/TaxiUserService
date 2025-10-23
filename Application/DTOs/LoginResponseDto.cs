using System.ComponentModel.DataAnnotations;

namespace Application.DTOs;

public class LoginResponseDto
{
    public string Token { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}