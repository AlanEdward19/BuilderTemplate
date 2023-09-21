using Core.Entities;

namespace Core.ValueObjects;

public class OrderValueObject
{
    public CustomerValueObject Customer { get; set; }
    public List<OrderItemValueObject> Items { get; set; }
    public DeliveryAddressValueObject DeliveryAddress { get; set; }
    public PaymentAddressValueObject PaymentAddress { get; set; }
    public PaymentInfoValueObject PaymentInfo { get; set; }
    public Receiver Receiver { get; set; }
    public Payer Payer { get; set; }
    public bool? IsInternational { get; set; }
}