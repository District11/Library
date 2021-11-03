using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.DtoModel
{
    public enum SortedModelDto
    {
        NameBookSorted, //Сортировка по наименованию книги
        CityPublisherSorted, // Сортировка по городу издателя
        CountPagesSorted, //Сортировка по колличеству страниц в книге
        LastNameSorted //Сортировка по Фамилии
    }
}
