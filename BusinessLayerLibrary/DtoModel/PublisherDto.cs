using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.DtoModel
{
    /// <summary>
    /// Модель издателя.
    /// </summary>
    public class PublisherDto
    {
        /// <summary>
        /// Идентификатор издателя.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование организации.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Город.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Список книги у издателя
        /// </summary>
        public List<BookDto> Books { get; set; }
    }
}
