using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixture
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>
            new()
            {
                new User
                    {
                        Id = 1,
                        Name = "Romualdo",
                        Email = "romualdo@test.com.br",
                        Address = new Address
                        {
                            City = "Salvador",
                            Street = "123 main St",
                            ZipCode = "12312312"
                        }
                    },
                new User
                    {
                        Id = 2,
                        Name = "Carlla",
                        Email = "Carlla@test.com.br",
                        Address = new Address
                        {
                            City = "Aracaju",
                            Street = "456 second St",
                            ZipCode = "45645645"
                        }
                    },
                new User
                    {
                        Id = 3,
                        Name = "Teste",
                        Email = "testUser@test.com.br",
                        Address = new Address
                        {
                            City = "Algumlugar",
                            Street = "789 third St",
                            ZipCode = "78978978"
                        }
                    }
            };
    }
}
