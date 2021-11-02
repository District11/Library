using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLibrary.Services
{
    public interface IPublisherDataLayerServices
    {
        /// <summary>
        /// Метод для добавления издателя.
        /// </summary>
        /// <param name="publisher"> Издатель.</param>
        public void AddPublisher(Publisher publisher);

        /// <summary>
        /// Метод для получения информации о издателе.
        /// </summary>
        /// <param name="Id">Идентификатор издателя.</param>
        /// <returns></returns>
        public Publisher GetPublisher(int Id);

        /// <summary>
        /// Метод для удаления информации о издателе.
        /// </summary>
        /// <param name="Id">Идентификатор издателя.</param>
        public void DeletePublisher(int Id);
    }
}
