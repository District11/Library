using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.DtoModel
{
    public enum SortedModelDto
    {
        /// <summary>
        /// Сортировка по наименованию книги.
        /// </summary>
        NameBookSorted,

        /// <summary>
        /// Сортировка по городу издателя
        /// </summary>
        CityPublisherSorted,

        /// <summary>
        /// Сортировка по колличеству страниц в книге
        /// </summary>
        CountPagesSorted,

        /// <summary>
        /// Сортировка по Фамилии
        /// </summary>
        LastNameSorted
    }
}
