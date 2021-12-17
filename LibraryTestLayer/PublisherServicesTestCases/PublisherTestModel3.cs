using DataLayerLibrary.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTestLayer.PublisherServicesTestCases
{
    public class PublisherTestModel3:IEnumerable<object[]>
    {
        static int Id = 1;

       static Publisher publisher0 = new Publisher()
        {
            Id = Id,
            City = "Pizdec",
            Name = "Saratov"
        };

        IEnumerable<Publisher> list = new List<Publisher> { publisher0 };

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { list};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
