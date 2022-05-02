namespace WebApi.Models.Accounts;

using System.ComponentModel.DataAnnotations;

public class ActivateCouponRequest
{
    [Required]
    public int Id { get; set; }

}