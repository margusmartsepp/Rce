using Rce.Domain.Abstractions;

namespace Rce.Domain.Models
{
    public class Customer : IIdentifiableEntity<int>
    {
        public int CustomerId { get; set; }
        public string Nickname { get; set; }

        public int EntityId
        {
            get { return CustomerId; }
            set { CustomerId = value; }
        }
    }
}