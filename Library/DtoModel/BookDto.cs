using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
