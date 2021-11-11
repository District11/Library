using System.Collections.Generic;

namespace Library.DtoModel
{
    public class BookDto
    {    
        /// <summary>
        /// Название книги.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Количество страниц в книге.
        /// </summary>
        public int NumberOfPage { get; set; }

        /// <summary>
        /// Автор книги.
        /// </summary>
        public List<int> AuthorId { get; set; }

        /// <summary>
        /// Издатель.
        /// </summary>
        public int PublisherId { get; set; }
    }
}
