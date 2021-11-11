using DataLayerLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services.Interfaces
{
    /// <summary>
    /// Сервис для книги в бизнес слое.
    /// </summary>
    public interface IBookBusinessLayerServices
    {
        /// <summary>
        /// Метод получения списка всех книнг.
        /// </summary>
        /// <param name="pageSize">Размер страницы</param>
        /// <param name="pageNumber">Номер страницы</param>
        /// <param name="filter">Параметр фильтра</param>
        /// <param name="sorted">Параметр сортировки</param>
        /// <returns></returns>
        Task<IEnumerable<Book>> GetAllBooks(int pageSize, int pageNumber, string filter, string sorted);

        /// <summary>
        /// Метод для добавления книги.
        /// </summary>
        /// <param name="book">Книга</param>
        Task<Book> CreateBook(Book book);

        /// <summary>
        /// Метод для получения книги.
        /// </summary>
        /// <param name="book">Идентификатор книги</param>
        /// <returns></returns>
        Task<Book> GetBook(int id);

        /// <summary>
        /// Метод для удаления книги.
        /// </summary>
        /// <param name="book">Идентификатор книги</param>
        Task<bool> DeleteBook(int id);


    }
}
