using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services
{
    public interface IPublisherBusinessLayer
    {
        /// <summary>
        /// Метод получения списка всех издателей.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Publisher>> GetAllPublishers();

        /// <summary>
        /// Метод для добавления издателя.
        /// </summary>
        /// <param name="book">Издатель.</param>
        Task<bool> CreatePublisher(Publisher publisher);

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
