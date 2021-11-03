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
        /// Метод получения списка всех книнг
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Book>> GetAllBooks(int pageSizeint, int pageNumber);

        /// <summary>
        /// Метод для добавления книги.
        /// </summary>
        /// <param name="book">Книга</param>
        Task AddBook(Book book);

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
        Task DeleteBook(int id);

        public Task Sorted(SortedModel sortedModel);

        public Task 
    }
}
