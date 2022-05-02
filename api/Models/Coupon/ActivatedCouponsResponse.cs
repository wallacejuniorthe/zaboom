namespace WebApi.Models.Accounts;

using System.ComponentModel.DataAnnotations;

public class ActivatedCouponsResponse
{
    public int CouponId { get; set; }
    public int AccountId { get; set; }
    public string Description { get; set; }
    public string Regulation { get; set; }
    public PartnerResponse Partner { get; set; }
}