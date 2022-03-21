namespace WebApi.Models.Accounts;

using System.ComponentModel.DataAnnotations;

public class RegisterRequest
{
    public int? Id { get; set; }

    [Required(AllowEmptyStrings = false,ErrorMessage = "nome inválido")]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    public string? Phone1 { get; set; }
    public string? Cpf { get; set; }

    [Required]
    [MinLength(6),MaxLength(14)]
    public string Password { get; set; }

    [Required]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }

/*    [Range(typeof(bool), "true", "true")]
    public bool AcceptTerms { get; set; }*/
}