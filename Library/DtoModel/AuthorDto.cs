using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DtoModel
{
    public class AuthorDto
    {
        /// <summary>
        /// Идентификатор автора.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Фамилия автора.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Имя автора.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Отчество автора. 
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Деятельность автора.
        /// </summary>
        public string Activity { get; set; }

        /// <summary>
        /// Список книг у автора.
        /// </summary>
        public List<AuthorBook> AuthorBooks { get; set; }

        /// <summary>
        /// Список книг.
        /// </summary>
        public List<Book> ListBooks { get; set; }
    }
}
