﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayerLibrary.Model
{
    public class Book
    {
        /// <summary>
        /// Идентификатор книги.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Автор книги.
        /// </summary>
        public Author Author { get; set; }

        /// <summary>
        /// Название книги.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Количество страниц в книге.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Автор книги.
        /// </summary>
        public Publisher Publisher { get; set; }
    }
}
