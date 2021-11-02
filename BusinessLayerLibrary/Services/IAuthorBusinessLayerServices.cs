using BusinessLayerLibrary.DtoModel;
using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services
{
    public interface IAuthorBusinessLayerServices
    {
        /// <summary>
        /// Метод для добавления автора.
        /// </summary>
        void AddAuthor(AuthorDto author);

        /// <summary>
        /// Метод для получение информации об автору.
        /// </summary>
        /// <param name="Id">Идентификатор автора.</param>
        /// <returns></returns>
        Author GetAuthor(int Id);

        /// <summary>
        /// Метод для удаления информации об авторе.
        /// </summary>
        /// <param name="Id">Идентификатор автора.</param>
        void DeleteAuthor(int Id);
    }
}
