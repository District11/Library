using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Model
{
    public class PublisherView
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
        public List<BookView> Books { get; set; }
    }
}
