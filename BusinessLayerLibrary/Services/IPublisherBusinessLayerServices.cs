using BusinessLayerLibrary.DtoModel;
using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services
{
    public interface IPublisherBusinessLayerServices
    {
        /// <summary>
        /// Метод для добавления издателя.
        /// </summary>
        /// <param name="publisherdto"> Издатель.</param>
        public void AddPublisher(PublisherDto publisherdto);

        /// <summary>
        /// Метод для получения информации о издателе.
        /// </summary>
        /// <param name="id">Идентификатор издателя.</param>
        /// <returns></returns>
        public PublisherDto GetPublisher(int id);

        /// <summary>
        /// Метод для удаления информации о издателе.
        /// </summary>
        /// <param name="id">Идентификатор издателя.</param>
        public void DeletePublisher(int id);
    }
}
