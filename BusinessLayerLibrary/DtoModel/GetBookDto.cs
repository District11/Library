using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.DtoModel
{
    /// <summary>
    /// Dto для получения сущности книги.
    /// </summary>
    public class GetBookDto
    {
        /// <summary>
        /// Идентификатор книги.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Автор книги.
        /// </summary>
        public List<Author> Author { get; set; }

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
        public PublisherDto Publisher { get; set; }
    }
}
