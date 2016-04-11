using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyTranslate.Model;

namespace MyTranslate.Service
{

    public interface IChapterService : ICommonService
    {

        /// <summary>
        /// 取得章节列表.
        /// </summary>
        /// <param name="bookCode"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        List<Chapter> GetChapterList(string bookCode, string status = null);



        /// <summary>
        /// 新章节.
        /// </summary>
        /// <param name="chapter"></param>
        /// <param name="lineTextArray"></param>
        /// <returns></returns>
        bool NewChapter(Chapter chapter, string[] lineTextArray);



        /// <summary>
        /// 取得章节.
        /// </summary>
        /// <param name="chapterCode"></param>
        /// <returns></returns>
        Chapter GetChapter(string chapterCode);




        /// <summary>
        /// 取得章节的 源文本.
        /// </summary>
        /// <param name="chapterCode"></param>
        /// <returns></returns>
        string[] GetChapterLineSourceText(string chapterCode);


        /// <summary>
        /// 取得章节的 翻译文本.
        /// </summary>
        /// <param name="chapterCode"></param>
        /// <returns></returns>
        string[] GetChapterLineTranslateText(string chapterCode);











        /// <summary>
        /// 机翻.
        /// </summary>
        /// <param name="chapterCode"></param>
        /// <param name="lineTextArray"></param>
        /// <returns></returns>
        bool AutoTrans(string chapterCode, string[] lineTextArray);




        /// <summary>
        /// 新增或更新章节.
        /// </summary>
        /// <param name="chapter"></param>
        /// <returns></returns>
        bool InsertOrUpdate(Chapter chapter);


    }

}
