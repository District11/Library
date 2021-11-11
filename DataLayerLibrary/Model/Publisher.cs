using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLibrary.Model
{
    /// <summary>
    /// Модель издательства.
    /// </summary>
    public class Publisher
    {
        /// <summary>
        /// Идентификатор издателя.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование организации.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Город.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Выражение для сортироки издательства по полям
        /// </summary>
        /// <param name="sortBy">Параметр сортировки</param>
        /// <returns></returns>
        public static Expression<Func<Publisher, object>> GetSortExpressions(string sortBy)
        {
            return sortBy?.ToLower() switch
            {
                "name" => p => p.Name,
                "сity" => p => p.City,
                _ => p => p.Id
            };
        }
    }
}
