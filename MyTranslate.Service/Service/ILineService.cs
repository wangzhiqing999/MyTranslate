using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyTranslate.Model;


namespace MyTranslate.Service
{



    public interface ILineService : ICommonService
    {

        /// <summary>
        /// 取得章节的行列表.
        /// </summary>
        /// <param name="chapterCode"></param>
        /// <returns></returns>
        List<Line> GetChapterLineList(string chapterCode);




        /// <summary>
        /// 取得指定书的，  包含指定名词的 行列表
        /// </summary>
        /// <param name="bookCode"></param>
        /// <param name="sourceName"></param>
        /// <returns></returns>
        List<Line> GetLineListByName(string bookCode, string sourceName);





        /// <summary>
        /// 新增一行.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        bool NewOneLine(Line line);



        /// <summary>
        /// 更新一行.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        bool UpdateOneLine(Line line);



        

    }



}
