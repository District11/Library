using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLibrary.Model
{
    /// <summary>
    /// Модель издателя.
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
    }
}
