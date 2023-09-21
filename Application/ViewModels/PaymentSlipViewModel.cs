using Core.Entities;

namespace Application.ViewModels;

public class PaymentSlipViewModel
{
    public string BarCode { get; set; }
    public string OurNumber { get; set; }
    public DateTime ExpiresAt { get; set; }
    public DateTime ProcessedAt { get; set; }
    public decimal DocumentAmount { get; set; }
    public Payer Payer { get; set; }
    public Receiver Receiver { get; set; }

    public PaymentSlipViewModel()
    {
        
    }
}