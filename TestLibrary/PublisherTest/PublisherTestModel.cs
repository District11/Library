using DataLayerLibrary.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.PublisherTest
{

    public class PublisherTestModel : IEnumerable<object[]>
    {
        static Publisher publisher = new Publisher()
        {
            Id = 1,
            City = "Pizdec",
            Name = "Saratov"
        };

        static IEnumerable<Publisher> publisherslist = new List<Publisher> {publisher};

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { publisherslist}; 
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
