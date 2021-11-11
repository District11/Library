using DataLayerLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services.Interfaces
{
    /// <summary>
    /// Сервес издательства в бизнес слое.
    /// </summary>
    public interface IPublisherBusinessLayer
    {
        /// <summary>
        /// Метод получения списка всех издателей.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Publisher>> GetAllPublishers(int pageSize, int pageNumber, string filter, string sorted);

        /// <summary>
        /// Метод для добавления издателя.
        /// </summary>
        /// <param name="book">Издатель.</param>
        Task<Publisher> CreatePublisher(Publisher publisher);

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
        Task<bool> DeletePublisher(int id);
    }
}
