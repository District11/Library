using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLibrary.Model
{
    public class Paging
    {
        /// <summary>
        /// Номер страницы.
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// Размер страницы
        /// </summary>
        public int PageSize { get; set; }
    }
}
