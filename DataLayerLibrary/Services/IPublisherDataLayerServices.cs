

using DataLayerLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayerLibrary.Services
{
    public interface IPublisherDataLayerServices
    {
        /// <summary>
        /// Метод получения списка всех издателей.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Publisher>> GetAllPublishers();

        /// <summary>
        /// Метод для добавления издателя.
        /// </summary>
        /// <param name="publisher">Издатель.</param>
        Task CreatePublisher(Publisher  publisher);

        /// <summary>
        /// Метод для получения издателя.
        /// </summary>
        /// <param name="id">Идентификатор издателя.</param>
        /// <returns></returns>
        Task<Publisher> GetPublisher(int id);

        /// <summary>
        /// Метод для удаления издателя.
        /// </summary>
        /// <param name="id">Идентификатор издателя.</param>
        Task DeletePublisher(int id);
    }
}
