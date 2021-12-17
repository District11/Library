using AutoMapper;
using BusinessLayerLibrary.Services.Implementations;
using BusinessLayerLibrary.Services.Interfaces;
using DataLayerLibrary.Models;
using DataLayerLibrary.Services.Interfaces;
using Library.Mapper;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LibraryTestLayer.PublisherServicesTestCases
{
    public class PublisherTests
    {
        private readonly PublisherBusinessLayer publisherBusinessLayer;
        private IPublisherBusinessLayer GetPublisher(Mock<IPublisherDataLayerServices> mock)
        {

            var configuration = new MapperConfiguration(cnfg => cnfg.AddProfile(new LibraryProfile()));
            IMapper mapper = new Mapper(configuration);

            return new PublisherBusinessLayer(mock.Object, mapper);
        }


        [Theory]
        [ClassData(typeof(PublisherTestModel))]
        public async void GetPublisherTestCase(int id, Publisher publisher1)
        {
            var mock = new Mock<IPublisherDataLayerServices>();
            mock.Setup(request => request.GetPublisher(id)).Returns(Task.FromResult(publisher1));

            var publisherService = GetPublisher(mock);
            var publisher = await publisherService.GetPublisher(id);
            Assert.Equal(id, publisher.Id);
        }


        [Theory]
        [ClassData(typeof(PublisherTestModel2))]
        public async void CreatePublisherTestCase(Publisher publisher1, Publisher publisher2)
        {
            var mock = new Mock<IPublisherDataLayerServices>();
            mock.Setup(request => request.CreatePublisher(publisher1)).Returns(Task.FromResult(publisher1));

            var publisherServices = GetPublisher(mock);
            var publisher = await publisherServices.CreatePublisher(publisher1);
            Assert.True(publisher.Id == publisher1.Id);
        }

        [Theory]
        [ClassData(typeof(PublisherTestModel3))]
        public async void GetAllPublisher(IEnumerable<Publisher> list)
        {
            var mock = new Mock<IPublisherDataLayerServices>();
            mock.Setup(request => request.GetAllPublishersModifie(1, 10, "", "")).Returns(Task.FromResult(list));

            var publisherServices = GetPublisher(mock);
            var publishers = await publisherServices.GetAllPublishers(1, 10, "", "");
            Assert.Equal(list.Select(x => x.Id), publishers.Select(x => x.Id));
        }
    }
}
