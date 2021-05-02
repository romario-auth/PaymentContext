using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private IList<Subscription> _substription;
        public Student(string firstName, string lastName, string document, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            _substription = new List<Subscription>();
        }

        public string FirstName {get; private set;}
        public string LastName {get; private set;}
        public string Document {get; private set;}
        public string Email {get; private set;}
        public string Adress { get; private set;}
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