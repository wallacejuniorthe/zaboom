namespace WebApi.Models.Accounts;

using System.ComponentModel.DataAnnotations;

public class ChangePasswordRequest
{
    [Required]
    public int Id { get; set; }

    [Required]
    [MinLength(6), MaxLength(12)]
    public string Password { get; set; }

    [Required]
    [MinLength(6), MaxLength(12)]
    public string NewPassword { get; set; }

    [Required]
    [Compare("NewPassword")]
    public string ConfirmNewPassword { get; set; }

}