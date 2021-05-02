using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _substription;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _substription = new List<Subscription>();
        }

        public Name Name {get; private set;}
        public Document Document {get; private set;}
        public Email Email {get; private set;}
        public Address Address { get; private set;}
        public IReadOnlyCollection<Subscription> Subscriptions { get{return _substription.ToArray();}}

        public void AddSubscription (Subscription subscription)
        {
            // Cancelar todas as outras assinaturas, e coloca esta
            // como principal
            foreach (var sub in Subscriptions)
            {
                sub.Inactivate();
            }

            _substription.Add(subscription);
        }
    }
}