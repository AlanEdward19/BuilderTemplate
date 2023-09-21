using Application.Services.Order;
using Application.Services.Payments.Builder;
using Core.Contracts.Order;
using Core.Contracts.Payments.Factory;
using Core.ValueObjects;
using Microsoft.AspNetCore.Mvc;

namespace BuilderTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public OrdersController()
        {
            
        }

        [HttpPost]
        public IActionResult Post([FromServices] InternationalOrderAbstractFactory internationalOrderAbstractFactory,
            [FromServices] NationalOrderAbstractFactory nationalOrderAbstractFactory, OrderValueObject model)
        {
            IOrderAbstractFactory orderAbstractFactory = model.IsInternational != null && model.IsInternational.Value
                ? internationalOrderAbstractFactory
                : nationalOrderAbstractFactory;

            #region Abstract Factory

            var paymentResult = orderAbstractFactory.GetPaymentService(model.PaymentInfo.PaymentMethod).Process(model);

            var deliverResult = orderAbstractFactory.GetDeliveryService().Deliver(model);

            #endregion

            #region Builder

            var slip = new PaymentSlipBuilder()
                .WithReceiver(model.Receiver)
                .WithPayer(model.Payer)
                .WithDates(DateTime.Today, DateTime.Today.AddDays(3))
                .WithPaymentDocument("codigo", "numero", 100)
                .Build();

            #endregion

            return Ok(new
            {
                PaymentResult = paymentResult,
                DeliverStatus = deliverResult,
                PaymentSlip = slip
            });
        }
    }
}
