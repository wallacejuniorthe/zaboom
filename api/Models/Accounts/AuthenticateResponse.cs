namespace WebApi.Models.Accounts;

using System.Text.Json.Serialization;

public class AuthenticateResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    public bool IsVerified { get; set; }
    public string JwtToken { get; set; }

    [JsonIgnore]
    public string RefreshToken { get; set; }
}