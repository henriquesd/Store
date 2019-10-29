using Store.Domain.Entities;
using Store.Domain.Repositories.Interfaces;

// da para utilizar frameworks de Mocks; no exemplo deste código está fazendo de maneira manual;

namespace Store.Tests.Repositories
{
   public class FakeCustomerRepository : ICustomerRepository
    {
        public Customer Get(string document)
        {
            if (document == "12345678911")
                return new Customer("Bruce Wayne", "batman@balta.io");

            return null;
        }
    }
}