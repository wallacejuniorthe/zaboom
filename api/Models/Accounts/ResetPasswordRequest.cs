namespace WebApi.Models.Accounts;

using System.ComponentModel.DataAnnotations;

public class ResetPasswordRequest
{
    [Required]
    public string Code { get; set; }

    [Required]
    [MinLength(6)]
    public string Password { get; set; }

    [Required]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }
}