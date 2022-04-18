namespace WebApi.Models.Accounts;

using System.ComponentModel.DataAnnotations;

public class ValidateAccountTokenRequest
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Token { get; set; }
}