using DataLayerLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayerLibrary.Services.Interfaces
{
    /// <summary>
    /// Сервис для книги в дата слое.
    /// </summary>
    public interface IBookDataLayerServices
    {
        /// <summary>
        /// Метод получения списка всех книнг.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Book>> GetAllBooks(int pageSizeint, int pageNumber, string filter, string sorted);

        /// <summary>
        /// Метод для добавления книги.
        /// </summary>
        /// <param name="book">Книга.</param>
        Task CreateBook(Book book);

        /// <summary>
        /// Метод для получения книги.
        /// </summary>
        /// <param name="id">Идентификатор книги.</param>
        /// <returns></returns>
        Task<Book> GetBook(int id);

        /// <summary>
        /// Метод для удаления книги.
        /// </summary>
        /// <param name="id">Идентификатор книги.</param>
        Task DeleteBook(int id);

       /* /// <summary>
        /// Метод сортировки библтоеки по параметрам.
        /// </summary>
        /// <param name="sortedModel">Параметр сортировки.</param>
        /// <returns></returns>
        public Task Sorted(SortedModel sortedModel);*/

    }
}
