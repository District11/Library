using DataLayerLibrary.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTestLayer.PublisherServicesTestCases
{
    public class PublisherTestModel : IEnumerable<object[]>
    {
        static int Id = 1;

        Publisher publisher = new Publisher()
        {
            Id = Id,
            City = "Pizdec",
            Name = "Saratov"
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { Id, publisher };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
