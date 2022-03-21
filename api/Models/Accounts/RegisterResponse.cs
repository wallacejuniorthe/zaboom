namespace WebApi.Models.Accounts;

using System.ComponentModel.DataAnnotations;

public class RegisterResponse{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}