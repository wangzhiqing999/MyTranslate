using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyTranslate.Service;

using MyTranslate.Model;
using MyTranslate.DataAccess;



namespace MyTranslate.ServiceImpl
{
    public class BookServiceImpl : CommonServiceImpl, IBookService
    {




        /// <summary>
        /// 取得书籍列表.
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public List<Book> GetBookList(string status = null)
        {
            using (MyTranslateContext context = new MyTranslateContext())
            {
                var query =
                    from data in context.Books
                    select data;


                if (!String.IsNullOrEmpty(status))
                {
                    query = query.Where(p => p.Status == status);
                }

                List<Book> resultList = query.ToList();

                return resultList;
            }
        }




        /// <summary>
        /// 新增书籍数据.
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public bool NewBook(Book book)
        {
            try
            {

                using (MyTranslateContext context = new MyTranslateContext())
                {

                    Book oldBook = context.Books.Find(book.BookCode);
                    if (oldBook != null)
                    {
                        ResultMessage = String.Format("书籍代码 {0} 已存在！", book.BookCode);
                        return false;
                    }


                    book.IsActive = true;
                    book.BeforeInsertOperation();

                    context.Books.Add(book);



                    // 同时， 新增  “名称” 章节.
                    Chapter nameChapter = new Chapter()
                    {
                        // 书代码.
                        BookCode = book.BookCode,
                        // 章节代码.
                        ChapterCode = book.BookCode + "/NAMES",

                        ChapterName = "命名",

                    };



                    nameChapter.IsActive = true;
                    nameChapter.BeforeInsertOperation();

                    context.Chapters.Add(nameChapter);


                    context.SaveChanges();

                    return true;
                }

            }
            catch (Exception ex)
            {
                ResultMessage = ex.Message;

                return false;
            }
            
        }



        /// <summary>
        /// 更新书籍数据.
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public bool UpdateBook(Book book)
        {
            try
            {

                using (MyTranslateContext context = new MyTranslateContext())
                {

                    Book oldBook = context.Books.Find(book.BookCode);
                    if (oldBook == null)
                    {
                        ResultMessage = String.Format("书籍代码 {0} 不存在！", book.BookCode);
                        return false;
                    }

                    // 书名.
                    oldBook.BookName = book.BookName;

                    // Url 地址.
                    oldBook.BookUrl = book.BookUrl;

                    // 有效性.
                    oldBook.IsActive = book.IsActive;


                    // 更新前处理.
                    oldBook.BeforeUpdateOperation();


                    // 物理保存.
                    context.SaveChanges();

                    return true;
                }

            }
            catch (Exception ex)
            {
                ResultMessage = ex.Message;

                return false;
            }
        }




        /// <summary>
        /// 获取书籍.
        /// </summary>
        /// <param name="bookCode"></param>
        /// <returns></returns>
        public Book GetBook(string bookCode)
        {
            using (MyTranslateContext context = new MyTranslateContext())
            {
                Book book = context.Books.Find(bookCode);

                return book;
            }
        }





        /// <summary>
        /// 新增或更新 书籍与章节..
        /// </summary>
        /// <param name="book"></param>
        /// <param name="replaceAll"></param>
        /// <returns></returns>
        public bool InsertOrUpdateBookAndChapter(Book book, bool replaceAll = true)
        {

            try
            {

                using (MyTranslateContext context = new MyTranslateContext())
                {

                    Book oldBook = context.Books.Find(book.BookCode);
                    if (oldBook == null)
                    {
                        // 数据库中，数据不存在.

                        // 新增逻辑.


                        // 新增前处理.
                        book.BeforeInsertOperation();
                        foreach (Chapter chapter in book.Chapters)
                        {
                            // 新增前处理.
                            chapter.BeforeInsertOperation();

                            foreach (Line line in chapter.Lines)
                            {
                                // 新增前处理.
                                line.BeforeInsertOperation();
                            }

                        }


                        context.Books.Add(book);
                    }
                    else
                    {
                        // 数据库中， 数据已存在， 

                        // 更新逻辑.

                        // 书名.
                        oldBook.BookName = book.BookName;
                        // Url 地址.
                        oldBook.BookUrl = book.BookUrl;
                        // 有效性.
                        oldBook.IsActive = book.IsActive;

                        // 更新前处理.
                        oldBook.BeforeUpdateOperation();



                        foreach (Chapter chapter in book.Chapters)
                        {
                            // 检查数据库中， 是否存在指定章节.
                            Chapter dbChapter = context.Chapters.Include("Lines").FirstOrDefault(p => p.ChapterCode == chapter.ChapterCode);

                            if (dbChapter != null && !replaceAll)
                            {
                                // 数据库中， 已存在章节。
                                // 但是本次操作， 是只更新。
                                // 那么 本章节则忽略.
                                continue;
                            }



                            if (dbChapter == null)
                            {
                                // 数据库中， 章节不存在.

                                // 新增逻辑.

                                // 新增前处理.
                                chapter.BeforeInsertOperation();

                                foreach (Line line in chapter.Lines)
                                {
                                    // 新增前处理.
                                    line.BeforeInsertOperation();
                                }
                                context.Chapters.Add(chapter);
                            }
                            else
                            {
                                // 数据库中，章节存在.

                                // 更新逻辑.

                                // 名称.
                                dbChapter.ChapterName = chapter.ChapterName;
                                dbChapter.ChapterTranslateName = chapter.ChapterTranslateName;

                                dbChapter.BeforeUpdateOperation();


                                List<Line> newLineList = new List<Line>();

                                // 行.
                                foreach (Line line in chapter.Lines)
                                {

                                    Line dbLine = null;


                                    if (chapter.ChapterCode.Contains("NAMES"))
                                    {
                                        // 命名章节.
                                        // 按照  原始文本进行匹配.
                                        dbLine = dbChapter.Lines.FirstOrDefault(p => p.SourceText == line.SourceText);
                                    }
                                    else
                                    {
                                        // 普通章节.
                                        // 按照 行号匹配.
                                        dbLine = dbChapter.Lines.FirstOrDefault(p => p.LineNumber == line.LineNumber);
                                    }



                                    if (dbLine == null)
                                    {
                                        // 新增
                                        newLineList.Add(line);
                                    }
                                    else
                                    {
                                        // 更新.
                                        dbLine.SourceText = line.SourceText;
                                        dbLine.MachineText = line.MachineText;
                                        dbLine.TranslateText = line.TranslateText;
                                        dbLine.Status = line.Status;
                                        dbLine.BeforeUpdateOperation();
                                    }
                                }


                                if (newLineList.Count > 0)
                                {
                                    foreach (Line newLine in newLineList)
                                    {
                                        // 新增的，需要重置 流水ID.
                                        newLine.LineID = 0;
                                        newLine.Chapter = null;
                                        newLine.CreateUser = null;
                                        newLine.BeforeInsertOperation();

                                        dbChapter.Lines.Add(newLine);
                                    }
                                }


                            }
                        }

                    }
                    


                    // 物理保存.
                    context.SaveChanges();

                    return true;
                }

            }
            catch (Exception ex)
            {
                ResultMessage = ex.Message;

                return false;
            }

        }


    }
}
