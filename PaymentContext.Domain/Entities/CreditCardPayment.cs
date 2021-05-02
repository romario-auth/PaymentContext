using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(string cardHoldeName, string cardNumber, string lastTransactionNumber, DateTime paidDate,
            DateTime experiteDate,
            decimal total,
            decimal totalPaid,
            string payer,
            Document document,
            Address address,
            Email email) : base(
                paidDate, experiteDate, total, totalPaid, payer, document, address, email)
        {
            CardHoldeName = cardHoldeName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHoldeName {get; private set;}
        public string CardNumber { get; private set; }
        public string LastTransactionNumber {get; private set;}
    }
}