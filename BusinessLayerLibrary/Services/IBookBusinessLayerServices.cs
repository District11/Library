﻿using BusinessLayerLibrary.DtoModel;
using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services
{
    /// <summary>
    /// Сервис для книги.
    /// </summary>
    public interface IBookBusinessLayerServices
    {
        /// <summary>
        /// Метод получения списка всех книнг
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<BookDto>> GetAllBooks();

        /// <summary>
        /// Метод для добавления книги.
        /// </summary>
        /// <param name="book">Книга</param>
        Task<bool> AddBook(BookDto book);

        /// <summary>
        /// Метод для получения книги.
        /// </summary>
        /// <param name="book">Идентификатор книги</param>
        /// <returns></returns>
        Task<Book> GetBook(int id);

        /// <summary>
        /// Метод для удаления книги.
        /// </summary>
        /// <param name="book">Идентификатор книги</param>
        Task<bool> DeleteBook(int id);

    }
}
