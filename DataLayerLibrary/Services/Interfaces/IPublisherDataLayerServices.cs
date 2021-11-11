using DataLayerLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayerLibrary.Services.Interfaces
{
    /// <summary>
    /// Сервис издательства в в дата слое
    /// </summary>
    public interface IPublisherDataLayerServices
    {
        /// <summary>
        /// Метод получения списка всех издателей. С пагинацией сортировкой и фильтрацией
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Publisher>> GetAllPublishersModifie(int pageSize, int pageNumber, string filter, string sorted);

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
