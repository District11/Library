using AutoMapper;
using BusinessLayerLibrary.Services.Implementations;
using BusinessLayerLibrary.Services.Interfaces;
using DataLayerLibrary;
using DataLayerLibrary.Models;
using DataLayerLibrary.Services.Implementations;
using DataLayerLibrary.Services.Interfaces;
using Library.Mapper;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestLibrary.PublisherTest
{
    public class PublisherTestCase
    {
        private readonly PublisherBusinessLayer publisherBusinessLayer;
        private IPublisherBusinessLayer GetPublisher(Mock<IPublisherDataLayerServices> mock) {

            var configuration = new MapperConfiguration(cnfg => cnfg.AddProfile(new LibraryProfile()));
            IMapper mapper = new Mapper(configuration);

            return new PublisherBusinessLayer (mock.Object, mapper);
        }


        [Theory]
        [ClassData(typeof(PublisherTestModel))]
        public async void GetPublisherTestCase(int id, Publisher publisher1)
        {
            var mock = new Mock<IPublisherDataLayerServices>();
            mock.Setup(request => request.GetPublisher(1)).Returns(Task.FromResult(publisher1));

            var publisherService = GetPublisher(mock);
            var publisher = await publisherBusinessLayer.GetPublisher(id);
            Assert.Equal(id, publisher.Id);


        }

        /*private List<PublisherTestModel> GetTestUser() {
            var users = new List<PublisherTestModel>
            {
               new PublisherTestModel {Id = 1, Name = "Sova", City = "Mosckow"},
               //new UserTest {Id = 2, Name = "Del", City = "PiterBurg"},
              // new UserTest {Id = 3, Name = "JIona", City = "Saratov"},
            };
            return users;
        }*/
    }
}
