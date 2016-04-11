using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyTranslate.Model;


namespace MyTranslate.Service
{

    public interface IBookService : ICommonService
    {

        /// <summary>
        /// 取得书籍列表.
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        List<Book> GetBookList(string status = null);



        /// <summary>
        /// 新书.
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        bool NewBook(Book book);



        /// <summary>
        /// 更新书籍数据.
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        bool UpdateBook(Book book);



        /// <summary>
        /// 获取书籍.
        /// </summary>
        /// <param name="bookCode"></param>
        /// <returns></returns>
        Book GetBook(string bookCode);





        /// <summary>
        /// 新增或更新 书籍与章节.
        /// </summary>
        /// <param name="book"></param>
        /// <param name="replaceAll"></param>
        /// <returns></returns>
        bool InsertOrUpdateBookAndChapter(Book book, bool replaceAll = true);

    }



}
