
using AutoMapper;
using BusinessLayerLibrary.Mapper;
using BusinessLayerLibrary.Services;
using BusinessLayerLibrary.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BusinessLayerLibrary.Extentions
{
    public static class BusinessLayerCollectionExtension
    {
        public static IServiceCollection AddBusinessLayerCollection(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(LibraryProfile).Assembly);
           // services.AddScoped<IAuthorBusinessLayerServices, AuthorBusinessLayerServices>();
            services.AddScoped<IBookBusinessLayerServices, BookBusinessLayerServices>();
            //services.AddScoped<IPublisherBusinessLayerServices, PublisherBusinessLayerServices>();

            return services;
        }
    }
}
