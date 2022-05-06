using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigForms
{
    public class Person
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        public static Person Generate()
        {
            var faker = new Faker();

            var result = new Person
            {
                Description = faker.Random.Word(),
                Name = faker.Person.FullName,
                Age = faker.Random.Int(18, 35),
                Phone = faker.Person.Phone
            };

            return result;
        }
    }
}
