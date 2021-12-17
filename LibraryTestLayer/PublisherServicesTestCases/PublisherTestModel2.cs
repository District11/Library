using DataLayerLibrary.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTestLayer.PublisherServicesTestCases
{
     public class PublisherTestModel2: IEnumerable<object[]>
    {
        static int Id = 1;

        Publisher publisher0 = new Publisher()
        {
            Id = Id,
            City = "Pizdec",
            Name = "Saratov"
        };

        Publisher publisher1 = new Publisher()
        {
            Id = Id,
            City = "Ahuetb",
            Name = "Saratov"
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { publisher0, publisher1};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
