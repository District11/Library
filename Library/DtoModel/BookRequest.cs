using System.Collections.Generic;

namespace Library.DtoModel
{
    /// <summary>
    /// Dto для создания сущности книги.
    /// </summary>
    public class BookRequest
    {
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
