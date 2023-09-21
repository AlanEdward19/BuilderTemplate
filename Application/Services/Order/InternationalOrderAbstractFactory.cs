using Application.Services.Deliveries;
using Application.Services.Payments;
using Core.Contracts.Deliveries;
using Core.Contracts.Order;
using Core.Contracts.Payments;
using Core.Enums;

namespace Application.Services.Order;

public class InternationalOrderAbstractFactory : IOrderAbstractFactory
{
    private readonly IDeliveryService _deliveryService;
    private readonly IPaymentService _paymentService;

    public InternationalOrderAbstractFactory(CreditCardService paymentService,
        InternationalDeliveryService deliveryService)
    {
        _paymentService = paymentService;
        _deliveryService = deliveryService;
    }

    public IPaymentService GetPaymentService(EPaymentMethod method)
    {
        return _paymentService;
    }

    public IDeliveryService GetDeliveryService()
    {
        return _deliveryService;
    }
}