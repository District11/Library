using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DtoModel
{
    /// <summary>
    /// Dto для создания сущности книги.
    /// </summary>
    public class BookRequest
    {
        /// <summary>
        /// Id книги.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название книги
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Колличество страниц.
        /// </summary>
        public int NumberOfPage { get; set; }

        /// <summary>
        /// Список id авторов одной книги.
        /// </summary>
        public List<int> AuthorId { get; set; }

        /// <summary>
        /// Id издательства для книги.
        /// </summary>
        public int PublisherId { get; set; }
    }
}
