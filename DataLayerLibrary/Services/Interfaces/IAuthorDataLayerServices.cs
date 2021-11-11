using DataLayerLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayerLibrary.Services.Interfaces
{
    /// <summary>
    /// Сервис автора в дата слое
    /// </summary>
    public interface IAuthorDataLayerServices
    {
        /// <summary>
        /// Метод получения списка всех авторов.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Author>> GetAllAuthors(int pageSize, int pageNumber, string filter, string sorted);

        /// <summary>
        /// Метод для добавления автора.
        /// </summary>
        /// <param name="author">Автор.</param>
        Task CreateAuthor(Author author);

        /// <summary>
        /// Метод для получения автора.
        /// </summary>
        /// <param name="id">Идентификатор автора.</param>
        /// <returns></returns>
        Task<Author> GetAuthor(int id);

        /// <summary>
        /// Метод для удаления автора.
        /// </summary>
        /// <param name="id">Идентификатор автора.</param>
        Task DeleteAuthor(int id);
    }
}
