using BusinessLayerLibrary.DtoModel;
using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services
{
    /// <summary>
    /// Сервис для книги.
    /// </summary>
    public interface IBookBusinessLayerServices
    {
        /// <summary>
        /// Метод для добавления книги.
        /// </summary>
        /// <param name="book">Книга</param>
        public void AddBook(BookDto book);

        /// <summary>
        /// Метод для получения книги.
        /// </summary>
        /// <param name="Id">Идентификатор книги</param>
        /// <returns></returns>
        public BookDto GetBook(int id);

        /// <summary>
        /// Метод для удаления книги.
        /// </summary>
        /// <param name="Id">Идентификатор книги</param>
        public void DeleteBook(int id);

    }
}
