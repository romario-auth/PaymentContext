using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(
            string transactionCode,
            DateTime paidDate,
            DateTime experiteDate,
            decimal total,
            decimal totalPaid,
            string payer,
            Document document,
            Address address,
            Email email) : base(
                paidDate, experiteDate, total, totalPaid, payer, document, address, email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }
}