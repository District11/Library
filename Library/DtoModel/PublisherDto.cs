using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DtoModel
{
    /// <summary>
    /// Модель издателя.
    /// </summary>
    public class PublisherDto
    {
        /// <summary>
        /// Наименование организации.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Город.
        /// </summary>
        public string City { get; set; }
    }
}
