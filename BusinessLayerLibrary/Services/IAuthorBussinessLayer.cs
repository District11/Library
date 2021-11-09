
using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services
{
    public interface IAuthorBussinessLayer
    {
        /// <summary>
        /// Метод получения списка всех книнг.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Author>> GetAllAuthors();

        /// <summary>
        /// Метод для добавления автора
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        Task<bool> CreateAuthor(Author author);

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
