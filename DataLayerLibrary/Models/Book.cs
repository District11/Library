using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace DataLayerLibrary.Models
{
    /// <summary>
    /// Модель книги.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Идентификатор книги.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название книги.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Количество страниц в книге.
        /// </summary>
        public int NumberOfPage { get; set; }

        /// <summary>
        /// Список авторов книги.
        /// </summary>
        public List<Author> Authors { get; set; }

        /// <summary>
        /// Автор книги.
        /// </summary>
        public Publisher Publisher { get; set; }

        /// <summary>
        /// Выражение для сортироки книги по полям
        /// </summary>
        /// <param name="sortBy">Параметр сортировки</param>
        /// <returns></returns>
        public static Expression<Func<Book, object>> GetSortExpressions(string sortBy)
        {
            return sortBy?.ToLower() switch
            {
                "name" => b => b.Name,
                "numberofpage" => b => b.NumberOfPage,
                "publisher" => b => b.Publisher, 
                _ => p => p.Id
            };
        }
    }
}
