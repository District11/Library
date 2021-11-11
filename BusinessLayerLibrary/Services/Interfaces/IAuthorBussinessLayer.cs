
using DataLayerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services.Interfaces
{
    /// <summary>
    /// Сервис автора в бизнес слое.
    /// </summary>
    public interface IAuthorBussinessLayer
    {
        /// <summary>
        /// Метод получения списка всех Авторов.
        /// </summary>
        /// <param name="pageSize">Размер страницы</param>
        /// <param name="pageNumber">Номер страницы</param>
        /// <param name="filter">Параметр фильтра</param>
        /// <param name="sorted">Параметр сортировки</param>
        /// <returns></returns>
        Task<IEnumerable<Author>> GetAllAuthors(int pageSize, int pageNumber, string filter, string sorted);

        /// <summary>
        /// Метод для добавления автора
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        Task<Author> CreateAuthor(Author author);

        /// <summary>
        /// Метод для получения автора.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Author> GetAuthor(int id);

        /// <summary>
        /// Метод для удаления автора.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteAuthor(int id);
    }
}
