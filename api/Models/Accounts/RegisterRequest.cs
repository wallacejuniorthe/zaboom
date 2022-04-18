namespace WebApi.Models.Accounts;

using System.ComponentModel.DataAnnotations;

public class RegisterRequest
{
    public int? Id { get; set; }

    [Required(AllowEmptyStrings = false,ErrorMessage = "Nome é um campo obrigatório")]
    public string Name { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Email é um campo obrigatório")]
    [EmailAddress]
    public string Email { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Celular é um campo obrigatório")]
    public string? Phone1 { get; set; }
    public string? Cpf { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Senha é um campo obrigatório")]
    [MinLength(6),MaxLength(14)]
    public string Password { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Confirmação de senha é um campo obrigatório")]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }

/*    [Range(typeof(bool), "true", "true")]
    public bool AcceptTerms { get; set; }*/
}