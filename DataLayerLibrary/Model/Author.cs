using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLibrary.Model
{
    /// <summary>
    /// Модель автора.
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Идентификатор автора.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Фамилия автора.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Имя автора.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Отчество автора. 
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Деятельность автора.
        /// </summary>
        public string Activity { get; set; }

        /// <summary>
        /// Выражение для сортироки автора по полям
        /// </summary>
        /// <param name="sortBy">Параметр сортировки</param>
        /// <returns></returns>
        public static Expression<Func<Author, object>> GetSortExpressions(string sortBy)
        {
            return sortBy?.ToLower() switch
            {
                "lastname" => a => a.LastName,
                "middlename" => a => a.MiddleName,
                "name" => a => a.Name,
                _ => a => a.Id
            };
        }

    }
}
