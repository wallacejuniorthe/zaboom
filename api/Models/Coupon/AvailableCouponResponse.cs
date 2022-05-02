namespace WebApi.Models.Accounts;

using System.ComponentModel.DataAnnotations;

public class AvailableCouponResponse
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public int QuantityUsed { get; set; }
    public string FinishAt { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Regulation { get; set; }
    public string? Code { get; set; }
    public PartnerResponse Partner { get; set; }
}