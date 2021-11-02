using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Services
{
    interface IBookServices
    {
        /// <summary>
        /// Метод получения списка всех книнг
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Book>> GetAllBooks();

        /// <summary>
        /// Метод для добавления книги.
        /// </summary>
        /// <param name="book">Книга</param>
        Task<bool> AddBook(Book book);

        /// <summary>
        /// Метод для получения книги.
        /// </summary>
        /// <param name="id">Идентификатор книги</param>
        /// <returns></returns>
        Task<Book> GetBook(int id);

        /// <summary>
        /// Метод для удаления книги.
        /// </summary>
        /// <param name="id">Идентификатор книги</param>
        Task<bool> DeleteBook(int id);
    }
}
