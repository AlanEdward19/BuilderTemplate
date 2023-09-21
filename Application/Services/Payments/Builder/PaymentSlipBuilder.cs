using Application.ViewModels;
using Core.Entities;

namespace Application.Services.Payments.Builder;

public class PaymentSlipBuilder
{
    private PaymentSlipViewModel _model = new();

    public PaymentSlipBuilder()
    {
        
    }

    public PaymentSlipBuilder WithReceiver(Receiver receiver)
    {
        _model.Receiver = receiver;

        return this;
    }

    public PaymentSlipBuilder WithPayer(Payer payer)
    {
        _model.Payer = payer;

        return this;
    }

    public PaymentSlipBuilder WithPaymentDocument(string barCode, string ourNumber, decimal documentAmount)
    {
        _model.BarCode = barCode;
        _model.OurNumber = ourNumber;
        _model.DocumentAmount = documentAmount;

        return this;
    }

    public PaymentSlipBuilder WithDates(DateTime processedAt, DateTime expiresAt)
    {
        _model.ProcessedAt = processedAt;
        _model.ExpiresAt = expiresAt;

        return this;
    }

    public PaymentSlipViewModel Build()
    {
        return _model;
    }
}