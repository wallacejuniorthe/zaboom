namespace WebApi.Models.Accounts;

using System.ComponentModel.DataAnnotations;

public class RegisterRequest
{
    public int? Id { get; set; }

    [Required(AllowEmptyStrings = false,ErrorMessage = "Nome � um campo obrigat�rio")]
    public string Name { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Email � um campo obrigat�rio")]
    [EmailAddress]
    public string Email { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Celular � um campo obrigat�rio")]
    public string? Phone1 { get; set; }
    public string? Cpf { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Senha � um campo obrigat�rio")]
    [MinLength(6),MaxLength(14)]
    public string Password { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Confirma��o de senha � um campo obrigat�rio")]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }

/*    [Range(typeof(bool), "true", "true")]
    public bool AcceptTerms { get; set; }*/
}