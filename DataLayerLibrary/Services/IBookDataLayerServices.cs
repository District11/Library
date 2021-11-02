using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLibrary.Services
{
    /// <summary>
    /// Сервис для книги.
    /// </summary>
    public interface IBookDataLayerServices
    {
        /// <summary>
        /// Метод для добавления книги.
        /// </summary>
        /// <param name="book">Книга</param>
        public void AddBook(Book book);

        /// <summary>
        /// Метод для получения книги.
        /// </summary>
        /// <param name="Id">Идентификатор книги</param>
        /// <returns></returns>
        public Book GetBook(int Id);

        /// <summary>
        /// Метод для удаления книги.
        /// </summary>
        /// <param name="Id">Идентификатор книги</param>
        public void DeleteBook(int Id);

    }
}
