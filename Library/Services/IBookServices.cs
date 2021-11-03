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
        Task<IEnumerable<BookView>> GetAllBooks(int pageSizeint, int pageNumber);

        /// <summary>
        /// Метод для добавления книги.
        /// </summary>
        /// <param name="book">Книга</param>
        Task<bool> AddBook(BookView book);

        /// <summary>
        /// Метод для получения книги.
        /// </summary>
        /// <param name="id">Идентификатор книги</param>
        /// <returns></returns>
        Task<BookView> GetBook(int id);

        /// <summary>
        /// Метод для удаления книги.
        /// </summary>
        /// <param name="id">Идентификатор книги</param>
        Task<bool> DeleteBook(int id);

        Task Sorted(SortedModelView sortedModelView);
    }
}
