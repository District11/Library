using DataLayerLibrary.Services;
using DataLayerLibrary.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayerLibrary.Extentions
{
    public static class DataLayerExtentions 
    {
        public static IServiceCollection AddDataLayerExtentions(this IServiceCollection service)
        {
           // service.AddScoped<IAuthorDataLayerServices, AuthorDataLayerServices>();
            service.AddScoped<IBookDataLayerServices, BookDataLayerServices>();
          //  service.AddScoped<IPublisherDataLayerServices, PublisherDataLayerServices>();
            return service;
        }
    }
}
