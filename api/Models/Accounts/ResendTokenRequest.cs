namespace WebApi.Models.Accounts;

using System.ComponentModel.DataAnnotations;

public class ResendTokenRequest
{
    [Required]
    public int Id { get; set; }
}