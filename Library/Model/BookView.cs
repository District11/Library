using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Model
{
    public class BookView
    {

        /// <summary>
        /// Идентификатор книги.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Автор книги.
        /// </summary>
        public AuthorView Author { get; set; }

        /// <summary>
        /// Название книги.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Количество страниц в книге.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Автор книги.
        /// </summary>
        public PublisherView Publisher { get; set; }
    }
}
